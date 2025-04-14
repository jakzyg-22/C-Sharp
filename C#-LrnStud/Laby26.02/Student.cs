namespace Laby26._02;

internal class Student
{
    private string imie;    
    private string nazwisko;
    private string nr_albumu;
    private float srednia;

    public Student(string imie, string nazwisko, string nr_albumu, float srednia)
    {
        if (srednia < 2 || srednia >= 5)
        {
            throw new FormatException("Nieprawidlowa wartosc sredniej");
        }
        else
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.nr_albumu = nr_albumu;
            this.srednia = srednia;
        }
    }
    public string getImie()
    {
        return imie;
    }

    public void setImie(string imie)
    {
        this.imie = imie.Trim(); //this zawsze wskazuje na biezacy obiekt
    }
    
    public string getNazwisko()
    {
        return nazwisko;
    }

    public void setNazwisko(string nazwisko)
    {
        this.nazwisko = nazwisko.Trim();
    }
    
    public string getNrAlbumu()
    {
        return nr_albumu;
    }

    public void setNrAlbumu(string nr_albumu)
    {
        this.nr_albumu = nr_albumu.Trim();
    }
    
    public float getSrednia()
    {
        return srednia;
    }

    public void setSrednia(float srednia)
    {
        if (srednia < 2 || srednia >= 5)
        {
            throw new FormatException();
        }
        else
        {
            this.srednia = srednia;   
        }
    }

    public float Stypendium()
    {
        float Stypendium;
        if (srednia >= 2 && srednia <= 5)
        {
            Stypendium = 0;
        }
        else if (srednia >= 4 && srednia <= 4.8)
        {
            Stypendium = 300;
        }
        else
        {
            Stypendium = 600;
        }
        return Stypendium;
    }
}