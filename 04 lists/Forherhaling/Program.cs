using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forherhaling
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
            double[] prijzen = new double[] {50, 20, 30 ,40};
            string[] artiekelen = { "Brood", "Kaas", "Dfea" , "FEad"};
            formulier[] formulieren = new formulier[2];

            formulieren[0] = new formulier() 
            { 
               feedback = "prijzig maar lekker", 
               Sterren = 5 
            };
            formulieren[1] = new formulier() 
            { 
                feedback = "prijzig fe lekker", 
                Sterren = 3 
            };

            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine(prijzen[i]);
                Console.WriteLine(artiekelen[i]);
            }

            foreach (formulier formulier in formulieren)
            {
                Console.WriteLine(formulier.feedback);
                Console.WriteLine(formulier.Sterren);


            }


            Console.ReadLine();            



        }


    }
}
