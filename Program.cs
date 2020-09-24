using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing
            const int AantalGetallen = 1000;
            double[] fibonnaci = vullArrayMetFibonacci(AantalGetallen);
            int volgnr = 0;
            while (volgnr < 1 || volgnr > AantalGetallen)
            {
                Console.WriteLine("Geef het volgende (1.." + AantalGetallen + ") van het getal op dat moet berekend worden");
                volgnr = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Het getal is {fibonnaci[volgnr - 1]}");
        }

        public static double[] vullArrayMetFibonacci(int aantalGetallen)
        {
            double[] fibonacci = new double[aantalGetallen];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < aantalGetallen; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            return fibonacci;
        }

        public static double berekenFibonnaciZonderArray(int volgnummer)
        {
            int a = 0;
            int b = 1;
            int getal = 0;

            switch (volgnummer)
            {
                case 0:
                    getal = a;
                    break;
                case 1:
                    getal = b;
                    break;
                default:
                    {
                        for (int i = 3; i <= volgnummer; i++)
                        {
                            getal = a + b;
                            a = b;
                            b = getal;
                        }
                        break;
                    }

            }
            return getal;
        }

    }
}
