using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constuctors
{
    internal class QuizVraagAntwoord
    {
        internal QuizVraag vraag;
        internal QuizVraag antwoord;
        internal bool goed;

        internal QuizVraagAntwoord(QuizVraag vraag)
        {
            vraag = antwoord;
            goed = false;
        }

    }
}


