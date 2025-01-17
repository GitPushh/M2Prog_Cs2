using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
            Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();
            personeelOpNummer.Add(38294, "jim");
            personeelOpNummer.Add(789432, "tim");

            string jim = personeelOpNummer[38294];
            string tim = personeelOpNummer[789432];

           

            foreach(KeyValuePair<int, string> item in personeelOpNummer)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            foreach(int key in personeelOpNummer.Keys)
            {
                Console.WriteLine(key);
            }
            foreach(string value in personeelOpNummer.Values)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}
