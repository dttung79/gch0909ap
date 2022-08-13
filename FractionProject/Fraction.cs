using System;

namespace FractionProject
{
    public class Fraction
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set 
            { 
                if (value == 0) throw new FractionException("Invalid denominator! Must be non-zero!");
                denominator = value; 
            }
        }
        public Fraction()
        {
            numerator = 0;
            denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public Fraction Add(Fraction other)
        {
            Fraction result = new Fraction();
            result.Numerator = Numerator * other.Denominator + other.Numerator * Denominator;
            result.Denominator = Denominator * other.Denominator;
            return result;
        }
        public Fraction Subtract(Fraction other)
        {
            int n = Numerator * other.Denominator - other.Numerator * Denominator;
            int d = Denominator * other.Denominator;
            return new Fraction(n, d);
        }
        public Fraction Multiply(Fraction other)
        {
            int n = Numerator * other.Numerator;
            int d = Denominator * other.Denominator;
            return new Fraction(n, d);
        }
        public Fraction Divide(Fraction other)
        {
            int n = Numerator * other.Denominator;
            int d = Denominator * other.Numerator;
            return new Fraction(n, d);
        }
        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }
    }
}