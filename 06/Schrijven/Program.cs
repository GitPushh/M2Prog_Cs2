using System.Text.Json;
using static Schrijven.Program;

namespace Schrijven
{
    internal class Program
    {
        string[] kaasplankje = { "kaasplankje1", "kaasplankje2", "kaasplankje is veel teduur" };
        string[] gamesvanmij = { "Fallout4", "Fallout76", "Roblox" };
        string[] gamesvanmij2 = { "Windows", "Windows", "All" };

        static void Main(string[] args)
        {
            Program program = new Program();
            FavoriteGames favoriteGames = new FavoriteGames();
            program.run();

           

        }
        
        void run()
        {

            FavoriteGames[] favoriteGames = new FavoriteGames[]
            {
                new FavoriteGames { Games = "Fallout 4", Platform = "PC" },
                new FavoriteGames { Games = "Fallout 76", Platform = "PC" },
                new FavoriteGames { Games = "Roblox", Platform = "Cross-platform" }
            };
            string games = JsonSerializer.Serialize(favoriteGames) ;

           

            File.WriteAllLines("mijntext.txt", kaasplankje);
            File.WriteAllLines("Regels.txt", kaasplankje);
            File.WriteAllText("Games.json", games);

            string text2 = File.ReadAllText("Games.json");
            FavoriteGames[] products2 = JsonSerializer.Deserialize<FavoriteGames[]>(text2);
            foreach (var game in products2)
            {
                Console.WriteLine(game.Games);
                Console.WriteLine(game.Platform);
            }





        }
    }
}