using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Obliczanie sredniej wszystkich ocen ucznia");
        Console.WriteLine("Ile ocen ucznia chcesz podac ? ");
        int ile = int.Parse(Console.ReadLine());
        double suma = 0;

        for (int i = 0; i < ile; i++)
        {
            Console.WriteLine("Podaj ocene: ");
            double ocena = double.Parse(Console.ReadLine());
            suma += ocena;
        }

        double srednia = suma / ile;
        Console.WriteLine("Srednia: " + Math.Round(srednia, 2));

        if (srednia >= 3.0)
        {
            Console.WriteLine("Uczen zdal");
        }
        else
        {
            Console.WriteLine("Uczen nie zdal");
        }
    }
}