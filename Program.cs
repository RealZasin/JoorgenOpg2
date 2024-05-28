using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoorgenOpg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppgave: "Lag et par forskjellige variabler av typene: int, string, double."
            int number = 5;
            string dailyMessage = "Welcome back!";
            double points = 10;

            /*Oppgave: Lag to forskjellige variabler som bruker datastrukturene: Array, List
            og prøv å skriv ut.*/
            string[] elever = { "anders", "petter", "gunnar" };
            List<string> toys = new List<string>();
            toys.Add("spade");
            toys.Add("lekebil");
            toys.Add("bøtte");
            Console.WriteLine(elever); //Printer bare ut "System.String[] som er den tekniske representasjonen av arrayet
                                       //For å skrive ut selve innholdet kan man bruke en for loop eller string.Join

            //Metode nr.1
            for (int i = 0; i < elever.Length; i++)
            {
                Console.WriteLine(elever[i]);
            }

            for (int i = 0; i < elever.Length; i++)
            {
                Console.WriteLine(toys[i]);
            }

            //Metode nr.2
            Console.WriteLine(string.Join(",", toys));
            Console.WriteLine(string.Join(",", elever));
            

            /*Oppgave: Bruk for-loops til å skrive ut Array og List til 
             * konsollen, dersom vi har et array av typen string[] kan vi 
             * bruke en for-loop som itererer gjennom ved hjelp av lengden 
             * av arrayet, og med int[] kan vi bruke count for å telle 
             * antall elementer i arrayet istedenfor.*/

            string[] navnArray = { "Ola", "Kari", "Per", "Trine" };

            for (int i = 0; i < navnArray.Length; i++)
            {
                Console.WriteLine(navnArray[i]);
            }


            int[] tall = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < tall.Length; i++) // 'Length' for arrays.
            {
                Console.WriteLine(tall[i]);
            }


            List<string> navnList = new List<string>() { "Ola", "Kari", "Per", "Trine" };

            for (int i = 0; i < navnList.Count; i++) // 'Count' for Lists.
            {
                Console.WriteLine(navnList[i]);
            }


            /*Forsøk å lage en klasse som bruker en 
             * constructor { get; set; } og kall den i Program.cs*/
            MyClass myInstance = new MyClass("Hello, world!");
            Console.WriteLine( myInstance.MyProperty);
            

            /*Forsøk å lage noen enkle metoder som regner med tall gitt 
             * som parametre. Eksempel:  ps( kan AddNumbers bruke 
             * desimaltall? Dersom den ikke kan, hvordan kan man 
             * fikse problemet?)
        - DU KAN FISKE PROBLEMET MED Å BRUKE FLOAT ELLER DOUBLE ISTEDENFOR
        */

            double MathAdd(double a, double b)
            {
                return a + b;
            }
            Console.WriteLine(MathAdd(2.22, 4.44));
            

            /*Bruk string metoder som f.eks String.Split(“”) og se hva 
             * som skjer med strengene og hvordan de manipuleres med 
             * disse innebygde metodene.*/

            string sentence = "Hello, World! How are you today?";
            string[] words = sentence.Split('o');

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            




            Console.ReadKey();




        }





    }
    public class MyClass
    {
        public string MyProperty {  get; set; }

        public MyClass(string value)
        { 
        MyProperty = value;
        }


        
    }
}
