using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę n:");
        int n = Convert.ToInt32(Console.ReadLine());

        int liczba = 2;
        int iloscLiczbPierwszych = 0;

        while (iloscLiczbPierwszych < n)
        {
            if (czyLiczbaPierwsza(liczba))
            {
                Console.WriteLine(liczba);
                iloscLiczbPierwszych++;
            }

            liczba++;
        }
    }

    static bool czyLiczbaPierwsza(int liczba)
    {
        if (liczba < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
                return false;
        }

        return true;
    }
}
