using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Wybierz kierunek swojej konwersji: ");
        Console.WriteLine("C - Celsjusz -> Fahrenheit");
        Console.WriteLine("F - Fahrenheit -> Celsjusz");
        string wybor = Console.ReadLine();

        if (wybor == "C" || wybor == "c")
        {
            Console.WriteLine("Podaj temperature w Celsjuszach: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = c * 1.8 + 32;
            Console.WriteLine(c + "°C = " + f + "°F");
        }
        else if (wybor == "F" || wybor == "f")
        {
            Console.WriteLine("Podaj temperature w Fahrenheitach: ");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) / 1.8;
            Console.WriteLine(f + "°F = " + c + "°C");
        }
        else
        {
            Console.WriteLine("Bledny wybor");
        }
    }
}