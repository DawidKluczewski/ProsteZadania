liczba1 = float(input("Podaj pierwsza liczbe: "))
liczba2 = float(input("Podaj druga liczbe: "))
operacja = input("Wybierz operacje z podanych: (+, -, *, /) ")

if operacja == "+":
    wynik = liczba1 + liczba2
elif operacja == "-":
    wynik = liczba1 - liczba2
elif operacja == "*":
    wynik = liczba1 * liczba2
elif operacja == "/":
    if liczba2 != 0:
        wynik = liczba1 / liczba2
    else:
        print("Nie mozna dzielic przez 0")
        exit()
else:
    print("To nie jest operacja z podanych powyzej")
    exit()

print("Wynik: ", wynik)