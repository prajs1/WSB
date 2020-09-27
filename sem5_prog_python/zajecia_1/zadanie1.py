name1 = input("Podaj swoje imie: ")
surname1 = input("Podaj swoje nazwisko: ")
age1 = input("Podaj swoj wiek: ")

name2 = input("Podaj swoje imie: ")
surname2 = input("Podaj swoje nazwisko: ")
age2 = input("Podaj swoj wiek: ")

avg_age = (float(age1) + float(age2)) / 2

print("User1: " + name1 + " " + surname1 + ", " + age1)
print("User2: " + name2 + " " + surname2 + ", " + age2)
print("Sredni wiek: {:.2f}".format(avg_age))
