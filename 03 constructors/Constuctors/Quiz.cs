using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constuctors
{

    
    internal class Quiz
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoord[] ingevuldeAntwoorden;
        internal void VoegVraagToeOpIndex(int index , QuizVraag vraag)
        {
           vragen[index] = vraag;
           
        }        
        internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            QuizVraag quizvraag = new QuizVraag(vraag,antwoord);
            VoegVraagToeOpIndex(index, quizvraag);
        }
        internal void StelVraag(int vraagIndex)
        {
            QuizVraag vraag = vragen[vraagIndex];
            QuizVraagAntwoord quizVraagAntwoord = new QuizVraagAntwoord(vraag);

            Console.WriteLine(vraag);
            
        }
        internal Quiz(int aantalVragen)
        {
            vragen = new QuizVraag[aantalVragen];
            ingevuldeAntwoorden = new QuizVraagAntwoord[aantalVragen];
        }


    }

    

   
}
