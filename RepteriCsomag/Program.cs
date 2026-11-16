using System;

class Program
{
    static void Main()
    {
        int sDb = 0;
        int mDb = 0;
        int lDb = 0;

        while (true)
        {
            double suly = BekerSuly();

            if (suly == 0)
            {
                break;
            }

            if (suly > 30)
            {
                Console.WriteLine("A csomag túl nehéz!");
                Console.WriteLine("Kérem, adjon meg egy új csomagot.");
            }
            else if (suly >= 0.1 && suly <= 5.0)
            {
                sDb++;
                Console.WriteLine("A csomag az S tárolóba került.");
            }
            else if (suly >= 5.1 && suly <= 15.0)
            {
                mDb++;
                Console.WriteLine("A csomag az M tárolóba került.");
            }
            else if (suly >= 15.1 && suly <= 30.0)
            {
                lDb++;
                Console.WriteLine("A csomag az L tárolóba került.");
            }
            else
            {
                Console.WriteLine("Érvénytelen tömeg!");
            }
        }

        Console.WriteLine();
        Console.WriteLine("A válogatás befejeződött.");
        Console.WriteLine("S tárolóban lévő csomagok száma: " + sDb);
        Console.WriteLine("M tárolóban lévő csomagok száma: " + mDb);
        Console.WriteLine("L tárolóban lévő csomagok száma: " + lDb);
    }

    static double BekerSuly()
    {
        double suly;

        while (true)
        {
            Console.Write("Adja meg a csomag tömegét kilogrammban: ");

            bool sikeres = double.TryParse(Console.ReadLine(), out suly);

            if (sikeres && suly >= 0)
            {
                return suly;
            }

            Console.WriteLine("Hibás adat! Adjon meg egy 0 vagy annál nagyobb számot.");
        }
    }
}
