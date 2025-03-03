namespace ForLoopKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*Ülesanne 3
             * Eelnevaid teadmisi kasutades kirjuta programm, mis väljastaks:
             * kill-koll kill-koll killadi-koll kill-koll kill-koll
             * killadi-koll kill-koll kill-koll killadi-koll*/
            //for loop for loopi sees

            for (int u = 0; u <= 1; u++)
            {
                for (int i = 0; i <= 1; i++)
                {
                    Console.Write("kill-koll");
                }
                Console.Write("kill-koll");
            }
            for (int k = 0; k < 4; k++)
            {
                Console.WriteLine("killadi-koll");
            }
            for (int e = 0; e < 4; e++)
            { }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("DONE!");
            Console.ReadKey();
        }
    }
}
