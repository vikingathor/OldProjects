using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Klient_till_Centraldatorn
{
    public partial class Form1 : Form
    {
        TcpClient Klient = new TcpClient();
        int port = 12345;
        List<string> BokLista = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
            Klient.NoDelay = true;

            TextFilInläsning("C:\\Users\\vikto\\Downloads\\avd_texter.txt");
            UppdateraListBox();
        }
        private void TextFilInläsning(string filnamn)
        {
            try
            {
                string[] rader = File.ReadAllLines(filnamn);
                BokLista.AddRange(rader);
            }
            catch
            {

            }
        }

        private void UppdateraListBox()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(BokLista.ToArray());
        }
        private void btnAnslut_Click(object sender, EventArgs e)
        {
            if (!Klient.Connected) StartConnection();
            
                btnAnslut.BackColor = Color.Green;
            

        }

        public async void StartConnection()
        {
            try
            {
                IPAddress Adressen = IPAddress.Parse("127.0.0.1");
                await Klient.ConnectAsync(Adressen, port);
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }
            {
                btnAnslut.Enabled = true;
                btnSänd.Enabled = true;
            }
        }

        private void btnSänd_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count> 0)
            {
                StartaSändning(listBox1.SelectedItems[0].ToString());
                BokLista.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                UppdateraListBox();
            }
            else
            {
                MessageBox.Show("välj ett object att skicka. ", Text);
            }
        }

        public async void StartaSändning(string message)
        {
            byte[] utdata = Encoding.Unicode.GetBytes(message);

            try
            {
                await Klient.GetStream().WriteAsync(utdata, 0, utdata.Length);
            }
            catch (Exception error ) { MessageBox.Show(error.Message, Text); return; }
            {

            }
        }
    }
}
