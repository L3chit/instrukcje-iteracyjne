using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wysokość trójkąta:");
        int wysokosc = Convert.ToInt32(Console.ReadLine());

        int szerokosc = 2 * wysokosc - 1;
        int srodek = szerokosc / 2;

        for (int i = 0; i < wysokosc; i++)
        {
            int iloscPlusow = 2 * i + 1;
            int poczatek = srodek - i;

            for (int j = 0; j < szerokosc; j++)
            {
                if (j >= poczatek && j < poczatek + iloscPlusow)
                    Console.Write("+");
                else
                    Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}
