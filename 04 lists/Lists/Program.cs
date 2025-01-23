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

            List<Pickup> pickups = new List<Pickup>();
            for (int i = 0; i < 10; i++)
            {
                Pickup pickup = new Pickup()
                {
                    x = i,
                    y = 0
                };
                pickups.Add(pickup);
            }
          

            

            for (int i = pickups.Count - 1;  i>= 0 ; i--)
            {

                    if (pickups[i].x == 4)
                    {
                        pickups.RemoveAt(i);
                    Console.WriteLine($"Pickup {i} has been removed");
                    }

                Console.WriteLine($"{pickups[i].x} is still there");
                
            }


            Console.ReadLine();
           



        }
    }

    class Pickup 
    {
        internal int x, y;

    }

    class Mob 
    {
        internal bool isDead;
        internal int hp = 10;

        List<string> mobs = new List<string>() ;   
        
        Random random = new Random();
        

        void TakeDamage(int damage)
        {
            mobs.Add("kaas");
            mobs.Add("kaas");
            mobs.Add("kaas");


            hp -= 5;
            if (damage < 0) 
            { 
                isDead = true;  
            }

           
        }

        void kaas()
        {
            for (int i = 0; i < 100; i++)
            {
                foreach (string s in mobs)
                {
                    if(random.Next() < 30)
                    {
                        TakeDamage(1);
                    }
                }
            }
        }


    }


}
