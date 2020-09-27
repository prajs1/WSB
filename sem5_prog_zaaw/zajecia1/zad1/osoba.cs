using System;

class Osoba
{
    private string name, surname, gender;
    private int age;
    Adres addressdata;

    public Osoba(string name, string surname, string gender, int age, string postalcode, string city, string street, string houseno, int apartmentno)
    {
        this.name = name;
        this.surname = surname;
        this.gender = gender;
        this.age = age;

        addressdata = new Adres(postalcode, city, street, houseno, apartmentno);
    }
}