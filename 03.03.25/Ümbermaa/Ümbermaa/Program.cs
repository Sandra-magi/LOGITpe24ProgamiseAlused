namespace Ümbermaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //vaja arvutada, mitu kahe eurost münti läheb ümber maa
            //maa ümbermõõt tuleb välja arvutada raadiuse abil

            double coinDiameter = 25.75;
            double earthRadius = 6378000000;

            //arvutan ümbermõõdu
            double circumference = 2 * Math.PI * earthRadius;

            //arvutan mitu münti läheb ümber maa
            double numberOfCoins = circumference / coinDiameter;

            Console.WriteLine("Mitu 2 eurost münti läheb ümber maa: " + Math.Round(numberOfCoins));

        }
    }
}
