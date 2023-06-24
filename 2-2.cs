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
            int liczba = random.Next(-4, 5) * 2;  // Losowanie liczby z przedziału [-4, 4] i mnożenie przez 2

            if (liczba >= -8 && liczba <= 8)
            {
                iloscLiczbParzystych++;
                Console.Write(liczba);

                if (iloscLiczbParzystych < n)
                    Console.Write(", ");
            }

            iloscLosowan++;
        }

        Console.WriteLine();
        Console.WriteLine("Ilość losowań: " + iloscLosowan);
    }
}
