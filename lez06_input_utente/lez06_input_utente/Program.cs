namespace lez06_input_utente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il nome");
            string? inputNome = Console.ReadLine();

            Console.WriteLine("Inserisci il cognome");
            string? inputCognome = Console.ReadLine();

            Console.WriteLine("Inserisci la tua età");
            string? inputEtaStringa = Console.ReadLine();

            int inputEta = 0;

            try
            {
                inputEta = Convert.ToInt32(inputEtaStringa);
            }
            catch {
                Console.WriteLine("ERRORE");
            }

            Console.WriteLine($"" +
                $"Nome: {inputNome} " +
                $"cognome: {inputCognome} " +
                $"eta: {inputEta}");

        }
    }
}
