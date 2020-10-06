using System;

class Osoba
{
    private string name, surname;
    private char gender;
    private int age;
    Adres addressdata;

    public string Name{
        set => name = value;
        get => name;
    }

    public string Surname{
        set => surname = value;
        get => surname;
    }

    public char Gender{
        set{
            if(value == 'M' || value == 'K' || value == 'm' || value == 'k')
                gender = value;
        }
        get => gender;
    }

    public int Age{
        set => age = value;
        get => age;
    }

    public Osoba(string name, string surname, char gender, int age, string postalcode, string city, string street, string houseno, int apartmentno)
    {
        this.name = name;
        this.surname = surname;
        this.gender = gender;
        this.age = age;

        addressdata = new Adres(postalcode, city, street, houseno, apartmentno);
    }

}