namespace Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //miks arvuti selliselt arvutab?
            //kuna ta arvutab matemaatika reeglite järgi
            //korrutamine ja jagamine ennem ja siis liitmine ja lahutamine
            double calculation1 = 3 + 8 / (4 - 2) * 4;
            //Sulud esimesena, ehk (4-2) = 2
            //Siis jagamine ja korrutamine 8/2= 4 ja 4*4 = 16
            //Siis liitmine 3+16 = 19
            double calculation2 = (3 + 8) / (4 - 2) * 4;
            //Sulud esimesena 3+8 = 11 ja 4-2 = 2
            //Jagamine ja korrutamine 11/2 = 5.5, ja 5.5*4=22
            double calculation3 = (3 + 8) / (4 -2) * 4;
            //Samamoodi teed nagu calculation2-s.
            double calculation4 = ((3.0 + 8.0) / (4.0 - 2.0) * 4.0);
            //Sulud esimesena, 3.0 + 8.0 = 11 ja 4.0-2.0 = 2.0
            //Siis jagamine ja korrutamine 11.0/2.0 = 5.5 ja 5.5*4.0 = 22.0

            Console.WriteLine("Vastus: " + calculation1);
            //Ilma sulgudeta jagamine ja korrutamine
            Console.WriteLine("Vastus: " + calculation2);
            //Sulgude pärast muutub arvutuste järjekord
            Console.WriteLine("Vastus  " + calculation3);
            //Sama nagu calculation2
            Console.WriteLine("Vastus  " + calculation4);
            //Sama mis calculation2, aga kahekordselt
        }
    }
}
