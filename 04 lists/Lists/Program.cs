using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();    
            program.Run();
        }

        void Run()
        {
            string[] characters = { "Pac-Man", "Samus", "Crash bandicoot", "Spyro" };
            List<string> characterlist = new List<string>();

            characterlist.Add("Pac-man");

            foreach (string character in characters)
            {
                characterlist.Add(character);
            }

            for (int i = 0; i < characterlist.Count; i++)
            {
                Console.WriteLine(characterlist[i]);
            }

            foreach (string character in characterlist)
            {
                Console.WriteLine(character);
            }

            List<double> reviews = new List<double>() { 50,342,40};

            for (int i = 0; i < reviews.Count; i++)
            {
                reviews.Remove(342);
                reviews.RemoveAt(0);
                Console.WriteLine(reviews[i]);
            }

            

            Console.ReadLine();
        }
    }
}
