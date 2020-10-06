using System;

class Adres
{
    private string postalcode, city, street, houseno;
    private int apartmentno;

    public Adres(string postalcode, string city, string street, string houseno, int apartmentno)
    {
        this.postalcode = postalcode;
        this.city = city;
        this.street = street;
        this.houseno = houseno;
        this.apartmentno = apartmentno;
    }
}