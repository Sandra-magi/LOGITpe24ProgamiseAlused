namespace odd_nr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                Console.Write("Sisesta number: ");
                string kasutajaSisend = Console.ReadLine();

                if (int.TryParse(kasutajaSisend, out int number))
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"Number {number} on paaris.");
                    }
                    else
                    {
                        Console.WriteLine($"Number {number} on paaritu.");
                    }
                }
                else
                {
                    Console.WriteLine("Sisestasite vale numbri!");
                }
            }
        }

    }
}

