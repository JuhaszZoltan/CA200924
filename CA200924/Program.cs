using System;

namespace CA200924
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] t = new int[50];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(10, 71);
                Console.Write($"{t[i]}, ");
            }

            //összeg
            int sum = 0;
            for (int i = 0; i < t.Length; i++)
                sum += t[i];
            Console.WriteLine($"\nÖsszeg: {sum}");
            Console.WriteLine($"Átlag: {(float)sum/t.Length}");

            int mini = 0;
            int maxi = 0;

            for (int i = 1; i < t.Length; i++)
            {
                if (t[maxi] < t[i]) maxi = i;
                if (t[mini] > t[i]) mini = i;
            }

            Console.WriteLine($"max value: {t[maxi]}");
            Console.WriteLine($"max index: {maxi}");
            Console.WriteLine($"max loc: {maxi + 1}");

            Console.WriteLine($"min value: {t[mini]}");
            Console.WriteLine($"min index: {mini}");
            Console.WriteLine($"min loc: {mini + 1}");

            int c = 0;
            int d = 3;
            for (int i = 0; i < t.Length; i++)
                if (t[i] % d == 0) c++;
            Console.WriteLine($"{d}-al/el osztható számok: {c} db");

            Console.Write("írj be egy számot: ");
            int input = int.Parse(Console.ReadLine());

            if(input %2 != 0) Console.WriteLine("nem páros");
            else
            {
                int i = 0;
                while (i < t.Length && t[i] != input) i++;
                if(i < t.Length)
                    Console.WriteLine($"A szám a {i + 1}. a tömbben");
                else Console.WriteLine("a szám nem található");
            }
            Console.ReadKey(true);
        }
    }
}
