using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwsza liczbe: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj druga liczbe: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Wybierz operacje z podanych: (+, -, *, /) ");
        string operacja = Console.ReadLine();

        double wynik;

        if (operacja == "+")
        {
            wynik = liczba1 + liczba2;
        }
        else if (operacja == "-")
        {
            wynik = liczba1 - liczba2;
        }
        else if (operacja == "*")
        {
            wynik = liczba1 * liczba2;
        }
        else if (operacja == "/")
        {
            if (liczba2 != 0)
                wynik = liczba1 / liczba2;
            else
            {
                Console.WriteLine("Nie mozna dzielic przez 0");
                return;
            }
        }
        else
        {
            Console.WriteLine("To nie jest operacja z podanych powyzej");
            return;
        }
        Console.WriteLine("Wynik: " + wynik);
    }
}