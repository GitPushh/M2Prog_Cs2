namespace Schrijven
{
    internal class Program
    {
        string[] kaas = { "feafea", "feafea", "kaasplank is lekker"};

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        void Run()
        {

            File.WriteAllLines("mijntekst.txt" ,kaas);

        }
    }

    public class FavoriteGame 
    {
        public string Name;
        public string Platform;
    }

}
