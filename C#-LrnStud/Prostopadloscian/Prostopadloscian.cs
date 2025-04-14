using System.Security.Cryptography;

namespace ConsoleApp1;

public class Prostopadloscian
{
    private float dlugosc;
    private float szerokosc;
    private float wysokosc;

    public Prostopadloscian()
    {
        dlugosc = 1f;
        szerokosc = 1f;
        wysokosc = 1f;
    }

    public Prostopadloscian(float dlugosc, float szerokosc, float wysokosc)
    {
        if (dlugosc <= 0f || szerokosc <= 0f || wysokosc <= 0f) //sprawdamy czy dlugosci sa bledne
        {
            throw new FormatException("Nieprawidlowe dane!");
        }

        this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
    }

    public float Objetosc()
    {
        return (dlugosc * szerokosc * wysokosc);
    }

    public bool Porownanie(Prostopadloscian prostopadloscian)
    {
        if (prostopadloscian.Objetosc() == Objetosc()){
            return true;
        }
        else
        {
            return false;
        }
    }
}