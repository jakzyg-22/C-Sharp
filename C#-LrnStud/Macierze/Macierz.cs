using System;

namespace Zestaw6Zadanie1
{
    internal class Macierz
    {
        private double?[,] _macierz;

        // Konstruktor: losowa macierz
        public Macierz(int i, int j)
        {
            if (i <= 0 || j <= 0)
                throw new FormatException("Wymiary muszą być większe od zera.");

            Random r = new Random();
            _macierz = new double?[i, j];

            for (int l = 0; l < i; l++)
            {
                for (int k = 0; k < j; k++)
                    _macierz[l, k] = r.NextDouble();
            }
        }

        // Konstruktor: z gotowej tablicy
        public Macierz(double?[,] macierzKwadratowa)
        {
            this._macierz = macierzKwadratowa;
        }

        // Właściwość
        public double?[,] macierz
        {
            get { return _macierz; } //zwraca wartosc _macierz
            set
            {
                _macierz = value; //pozwala przypisac dwuwymiarowa tablice
                if (value.GetLength(0) == _macierz.GetLength(0) && value.GetLength(1) == _macierz.GetLength(1))
                {
                    this._macierz = value;
                }
                else
                {
                    throw new FormatException("Wymiary tych tablic sa rozne!");
                }
            }
        }

        // Transpozycja
        public Macierz Transpozycja()
        {
            int wiersze = _macierz.GetLength(0);
            int kolumny = _macierz.GetLength(1);

            double?[,] transponowana = new double?[kolumny, wiersze];

            for (int i = 0; i < wiersze; i++)
                for (int j = 0; j < kolumny; j++)
                    transponowana[j, i] = _macierz[i, j];

            return new Macierz(transponowana);
        }

        // Operator dodawania macierzy
        public static Macierz operator +(Macierz m1, Macierz m2)
        {
            int n = m1._macierz.GetLength(0);
            int m = m1._macierz.GetLength(1);

            if (n != m2._macierz.GetLength(0) || m != m2._macierz.GetLength(1))
                throw new ArgumentException("Macierze muszą mieć te same wymiary!");

            double?[,] wynik = new double?[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    wynik[i, j] = m1._macierz[i, j] + m2._macierz[i, j];

            return new Macierz(wynik);
        }

        // Operator mnożenia macierzy przez liczbę
        public static Macierz operator *(double a, Macierz m1)
        {
            int n = m1._macierz.GetLength(0);
            int m = m1._macierz.GetLength(1);

            double?[,] wynik = new double?[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    wynik[i, j] = a * m1._macierz[i, j];

            return new Macierz(wynik);
        }
        
        public static Macierz operator *(Macierz m1, double a)
        {
            int n = m1._macierz.GetLength(0);
            int m = m1._macierz.GetLength(1);

            double?[,] wynik = new double?[n, m];

            for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                wynik[i, j] = a * m1._macierz[i, j];

            return new Macierz(wynik);
        }
        
        public override string ToString()
        {
            int wiersze = _macierz.GetLength(0);
            int kolumny = _macierz.GetLength(1);
            string wynik = "";

            for (int i = 0; i < wiersze; i++)
            {
                for (int j = 0; j < kolumny; j++)
                {
                    wynik += $"{_macierz[i, j]:F2}\t"; // 2 miejsca po przecinku + tab
                }
                wynik += "\n";
            }

            return wynik;
        }


    }
    
}
