import datetime
 
# metodą .datatime.now() odczytujemy aktualną datę i czas z naszego systemu operacyjnego
teraz = datetime.datetime.now()
print('Czas systemu operacyjnego: ', teraz)
 
# atrybutem .day metody .datatime() pobieramy dzień miesiąca
dzien = str(teraz.day)
print('Dzień: ', teraz.day)
 
# atrybutem .month metody .datatime() pobieramy miesiąc
miesiac = str(teraz.month)
print('Miesiąc: ', miesiac)
 
# atrybutem .year metody .datatime() pobieramy rok
rok = str(teraz.year)
print('Rok: ', rok)
 
# atrybutem .hour metody .datatime() pobieramy godzinę
godzina = str(teraz.hour)
print('Godzina: ', godzina)
 
# atrybutem .minute metody .datatime() pobieramy minutę
minuta = str(teraz.minute)
print('Minuta: ', minuta)
 
# atrybutem .second metody .datatime() pobieramy sekundę
sekunda = str(teraz.second)
print('Sekunda: ', sekunda)