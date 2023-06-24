using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę n:");
        int n = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        int iloscLosowan = 0;
        int iloscLiczbParzystych = 0;

        while (iloscLiczbParzystych < n)
        {
            int liczba = random.Next(-8, 9);
            iloscLosowan++;

            if (liczba % 2 == 0)
            {
                iloscLiczbParzystych++;
                Console.Write(liczba);

                if (iloscLiczbParzystych < n)
                    Console.Write(", ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Ilość losowań: " + iloscLosowan);
    }
}
