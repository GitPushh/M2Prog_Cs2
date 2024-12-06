using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RijSchool
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
           

            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H",
                kilometerStand = 20567,
                merk = "volkswagen"
            };

            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerStand = 65739,

            };

            RijLeraarcs rijLeraar = new RijLeraarcs()
            {
                leeftijd = 30,
                naam = "John",
                zzp = false
            };

            

            LesPakket lespakket = new LesPakket()
            {
                urenGekocht = 50,
                urenVerbruikt = 50,
                examenPogingen = 1,
                automaat = false
            };
            TheorieTest theorietest = new TheorieTest()
            {
                aantalFouten = 3,
                gehaald = false,

            };

            RijTest rijtest = new RijTest()
            {
                gehaald = true,
                afnameDatum = DateTime.Now,
            };

            Student student = new Student()
            {
                naam = "fdfd",
                leeftijd = 30,
                lesPakket = lespakket,
                theorieTest = theorietest,
                rijtest = rijtest
            };

            Student student2 = new Student()
            {
                naam = "kas",
                leeftijd = 25,
                lesPakket = lespakket,
                theorieTest = theorietest,
                rijtest = rijtest


            };

            Lesuur lesUur = new Lesuur()
            {
                auto = auto1,
                rijLeraar = rijLeraar,
                tijd = 1130,
                student = student

            };
            Lesuur lesUur2 = new Lesuur()
            {
                auto = auto2,
                rijLeraar = rijLeraar,
                tijd = 3310,
                student = student2

            };
            Dag dag = new Dag()
            {
                datum = DateTime.Now,
                

            };

           
        }
    }
}
