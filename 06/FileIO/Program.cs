namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            string[] lines = File.ReadAllLines("quiz.txt");
            string[] lines2 = File.ReadAllLines("nos.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"{lines[i]}");
            }
            for(int i = 0;i < lines2.Length; i++)
            {
                Console.WriteLine($"{lines2[i]}");
            }    
        }
    }
}
