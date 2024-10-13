using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp20
{
    internal class Program  //har nu ändrat baserat på dina kommentarer då användaren inte behöver skriva in ett värde för boktyp och behöver nu endast skriva in titeln och vem skribent//
    {
        public class Bok //klassen bok vilket är huvud klassen vi arbetar med //
        {
            public string titel { get; set; }
            public string skribent { get; set; } // definerar tre egenskaper åt bok klassen //
            public string boktyp { get; set; }

            public Bok(string titel1, string skribent1) //konstruktor till huvudklassen den används när en instans av klassen skappats  //
            {
                titel = titel1;
                skribent = skribent1; //sparar våra värden i bokens objekt //

            }

        }

        public class Roman : Bok // en underklass av boken som heter roman den ärver egenskaperna från bok och kan ändra dem //
        {

            public Roman(string titel1, string skribent1) : base(titel1, skribent1) //underklass konstruktorn för vår Roman underklass, tack vare base kan vi skicka innehålet i den till bok klassen // 
            {
                boktyp = "Roman";
            }
        }

        public class Tidskrift : Bok // underklass 2 av bok klassen här är string boktyp1 ändrad till skrifttyp //
        {


            public Tidskrift(string titel1, string skribent1) : base(titel1, skribent1)
            {
                boktyp = "Tidskrift";
            }
        }

        public class novellsamling : Bok // underklass 3 som heter novellsamling // 
        {


            public novellsamling(string titel1, string skribent1) : base(titel1, skribent1)
            {
                boktyp = "Novel";
            }
        }


        static void Main(string[] args) //programme startar här i Main // 
        {
            List<Bok> biblotek = new List<Bok>(); //List <bok> låter oss lagra böckerna i en lista för ändring eller lägga till flera böcker // 
            while (true) //while låter oss hålla igång en loop tills vi väljer val 5//
            {



                Console.WriteLine("1 vill du lägga till en roman "); //lägger till en roman i listan av böcker //
                Console.WriteLine("2 ska du lägga till en tidskrift "); //lägger till en tidskriftt i listan av böcker //
                Console.WriteLine("3 ska du lägga till en novel till samlingen"); //lägger till en novel i listan av böcker //
                Console.WriteLine("4 vill du se alla böcker "); //låter oss se alla böcker vi sparat i listan //
                Console.WriteLine("5 stäng programmet "); //tack vare Exit avslutas programmet då användaren känner sig nöjd//

                Console.WriteLine("välj ett val "); //som sagt så kan användaren lägga in så många böcker hen vill till den väljer att avsluta //
                string val = Console.ReadLine();

                switch (val) // användandet av en switch låter oss välja mellan vilken typ av bok som ska läggas till eller om användaren vill se alla böcker eller avsluta programmet//
                {
                    case "1":
                        Console.WriteLine("Vilken titel har romanen ");
                        string romantiteln = Console.ReadLine();
                        Console.WriteLine("Vem är skrivbent ");
                        string romanbent = Console.ReadLine();


                        Roman romanBok = new Roman(romantiteln, romanbent); //låter oss skapa en ny roman och sen lägga in den i listan tillsamans med dem andra böckerna //
                        biblotek.Add(romanBok);
                        break;

                    case "2":
                        Console.WriteLine("Vilken titel har tidskriften ");
                        string tidstiteln = Console.ReadLine();
                        Console.WriteLine("Vem är skrivbent ");
                        string tidnbent = Console.ReadLine();


                        Tidskrift Tidskriftbok = new Tidskrift(tidstiteln, tidnbent);
                        biblotek.Add(Tidskriftbok);
                        break;



                    case "3":
                        Console.WriteLine("Vilken titel har novelen ");
                        string noveltiteln = Console.ReadLine();
                        Console.WriteLine("Vem är skrivbent ");
                        string novelbent = Console.ReadLine();


                        novellsamling Novel = new novellsamling(noveltiteln, novelbent);
                        biblotek.Add(Novel);
                        break;

                    case "4":
                        Console.WriteLine("Visar nu alla böcker i bilioteket ");
                        foreach (var item in biblotek)
                        {
                            Console.WriteLine($"{item.titel}, {item.skribent}, {item.boktyp}");

                        }
                        break;
                    case "5":
                        Environment.Exit(0); //låter oss avsluta programmet när val 5 har gjorts //
                        break;

                    default:
                        Console.WriteLine(" inget giltigt har valts "); //felhantering för om inget val har gjorts // 
                        break;
                }
            }
        }
    }
}

