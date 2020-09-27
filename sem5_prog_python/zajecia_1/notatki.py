print("test")

#zaokraglanie
x = 10.1234
print(x)
print("{:.2f}".format(x))

#potegowanie
pow = 2**10
print(pow)

'''
komentarz w wielu liniach
'''

#konkatenacja + 
name = input("Podaj swoje imie: ")
print("Twoje imie: " + name)

surname = input("Podaj swoje nazwisko: ")
print("Twoje imie: " + name + ", nazwisko: " + surname)

#dzialanie na stringach

surname = "Kowalski"
print(surname[0])
print(surname[len(surname) -1])
print(surname[-1])

print()
print(surname[0]) # K
print(surname[0:3]) # Kow
print(surname[-2]) # k
print(surname[-2:]) # ki
print(surname[:-2]) #Kowals
print(surname[:-2:2]) #Kwl

#konwersja typu

x = "5"
print(type(x))

y = 4
print(type(y))

y = y / 2
print(type(y))
