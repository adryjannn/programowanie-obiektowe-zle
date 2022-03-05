using System;

namespace _05032022
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulamek test = new Ulamek(1, 2);
            
           
           
        }

        

        
 
    }


    class Ulamek : IEquatable, IComparable
    {
        private int licznik;
        private int mianownik;

        /// <summary>
        /// konstruktor bezargumentowy
        /// </summary>
        public Ulamek()
        {
        }

        /// <summary>
        /// konstrukot z argumentami
        /// </summary>

        public Ulamek(int l, int m)
        {
            licznik = l;
            mianownik = m;
        }
        /// <summary>
        /// Konstruktor kopiujący
        /// </summary>
       
        public Ulamek(Ulamek poprzednikUlamek)
        {
            licznik = poprzednikUlamek.licznik;
            mianownik = poprzednikUlamek.mianownik;
        }

        public void toString()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }


    public readonly struct Fraction
    {
        private readonly int num;
        private readonly int den;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            }
            num = numerator;
            den = denominator;
        }

        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.num, a.den);

        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);

        public static Fraction operator -(Fraction a, Fraction b)
            => a + (-b);

        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.num * b.num, a.den * b.den);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.num == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.num * b.den, a.den * b.num);
        }

        public override string ToString() => $"{num} / {den}";
    }

    class IEquatable
    {
    }
}
