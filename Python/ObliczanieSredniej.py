print("Obliczanie sredniej wszystkich ocen ucznia")
ile = int(input("Ile ocen ucznia chcesz podac ? "))
suma = 0

for i in range(ile):
    ocena = float(input("Podaj ocene: "))
    suma += ocena

srednia = suma / ile
print("Srednia: ", round(srednia, 2))

if srednia >= 3.0:
    print("Uczen zdal")
else:
    print("Uczen nie zdal")