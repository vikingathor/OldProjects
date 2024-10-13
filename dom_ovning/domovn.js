//Uppgift 1 tag name selektor och klassmanipulation 

//Kommer att hämta alla element som är p 
var paragrafer = document.querySelectorAll('p');

paragrafer.forEach(function(paragrafer) {
paragrafer.classList.add('bodyCopy');
}
);

//Funktionen kommer att loopa genom var p element för att sedan skappa klassen bodycopy



//Uppgift 2 Selektorer och childnodes för klassmanipulation 

//Används för att komma till footer elementet inom Css

var footerTillCss = document.querySelector('footer');

//Nu ska vi hämta p elementet som kommer finna i footer 

var footerParagrafets = footerTillCss.querySelector('p');

//Slutligen lägga in klassen footerp till elementet p 

footerParagrafets.classList.ass('footerp');


//Uppgift 3 Class name selektorer, loopar och DOM manipulation 


//1 Ser till att alla li element väljs som har klassen navigation 
const navigeringsItems = document.querySelectorAll('li.navigation');

//2 Ser till att loopa igenom exakt var element 
navigeringsItems.forEach(item => {

//3 Ser till att hämta textinnehållet 
const täxten = item.textContent;

//4 Ser till att ett nytt a element skappas 
const länken = document.createElement('a');

//5 Ser till att sätta href till # och sedan textinnehållet 
länken.settAttribute('href', ´#${text}´);

//6 placerar textinnehållet inom a elementet 
länken.textContent = text;

//7 Ser till att remove allt textinnehåll från li elementet 
item.textContent = '';

//8 slutligen addar elementet a till elementet li 
item.appendChild(länken);


//Uppgift 4 id selektorer och attribute 


//använder mig av id lista2 för att kunna välja element
 const listatvå = document.getElementById('lista2');

//Hämtar parentNode för dem valda elementen 
const fader = listatvå.parentNode;

//ändrar style attributet till background color för parentNode
fader.style.backgroundColor = '#cfd8c';


//Uppgift 5 Finalen 


//1 väljer element som har ID lista1 
const listaEtt = document.getElementById('lista1');

//2 nu är det dags att hämta alla li element som finns inom #lista1
const listAllItems = listaEtt.querySelectorAll('li');

//3 Ser till att loopa igenom varje li element 
listAllItems.forEach((item, index) => {

//4 tar hjälp av moulus operatorn som kan hitta ojämna inex 
if (index % 2 !==0) {

//5 För att identifiera ojämna li element tillängnar vi färgen röd på dem
item.style.color = 'red';



