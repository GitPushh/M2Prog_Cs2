using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constuctors
{
    internal class Program
    {


        
        static void Main(string[] args)
        {
            Program program = new Program();    
            program.Run();
            Console.Read();

        }

        internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            vraag = "is kaas lekker?";
            
            
        }


        void Run()
        {
            QuizVraag quizvraag = new QuizVraag("hier komt e vraag", "hier komt het antwoord");
            Quiz quiz = new Quiz(10);
            quiz.VoegVraagToeOpIndex(0, quizvraag);
            
        }

        



    }




}
