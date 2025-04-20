print("Wybierz kierunek swojej konwersji: ")
print("C - Celsjusz -> Fahrenheit")
print("F - Fahrenheit -> Celsjusz")
wybor = input("Twoj wybor: ")

if wybor == "C" or wybor == "c":
    c = float(input("Podaj temperature w Celsjuszach: "))
    f = c * 1.8 + 32
    print(f"{c}°C = {f}°F")
elif wybor == "F" or wybor == "f":
    f = float(input("Podaj temperature w Fahrenheitach: "))
    c = (f - 32) / 1.8
    print(f"{f}°F = {c}°C")
else:
    print("Bledny wybor")