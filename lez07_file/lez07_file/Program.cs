namespace lez07_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? path = "C:\\Users\\ACADEMY\\Desktop\\scrittura_test.txt";

            string frase = "Ciao, sono Giovanni Pace";

            try
            {
                if(path is not null)
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine("---------------------------");
                        sw.WriteLine(frase);
                        sw.WriteLine("---------------------------");
                    }

                    Console.WriteLine("STAPPOOOOOOOOOOOOOOO");
                }

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
