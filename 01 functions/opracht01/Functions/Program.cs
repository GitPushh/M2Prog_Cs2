using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        Random rnd = new Random();

        string[] vragen = new string[]
        {
            "TestVraag",
            "What is the worst game you played but that you liked anyway?",
            "fffff",
            "What is the worst game you played but that you liked anyway?fff",

        };


        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            //class type
            // functie heet program
        }

        internal void Run()
        {

            string vraag0 = GetRandomVraag();
            
            Console.WriteLine(vraag0);  

            Console.WriteLine("Dit is nu de start van mijn programma");
            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();

            
            


        }

        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
        }
        internal void Vraag2()
        {
            Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
            string antwoord = Console.ReadLine();
        }
        internal void Vraag3()
        {
            Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
            string antwoord = Console.ReadLine();
            
        }
        internal void Vraag4()
        {
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();
        }
        internal void Vraag5()
        {
            Console.WriteLine("What is the worst game you played but that you liked anyway?");
            string antwoord = Console.ReadLine();
        }

        internal string Vraag7()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();   

            return antwoord;

        }

        

        internal string GetRandomVraag()
        {
            int randomNumber = rnd.Next(1, 4);

            return vragen[randomNumber];
        }
    }
}
