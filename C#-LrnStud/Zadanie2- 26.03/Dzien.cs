namespace Zadanie2__26._03;

public struct Dzien
{
    public int NumerDniaMiesiaca { get; set; }
    public Miesiace Miesiac { get; set; }
    public PoryRoku PoryRoku { get; set; }

    public Dzien(int numerDniaMiesiaca, Miesiace miesiac, PoryRoku poryRoku)
    {
        this.NumerDniaMiesiaca = numerDniaMiesiaca;
        this.Miesiac = miesiac;
        this.PoryRoku = poryRoku;
    }

    public string Wyswietl()
    {
        string data = NumerDniaMiesiaca.ToString() + Miesiac.ToString() + PoryRoku.ToString();
        return data;
    }
}