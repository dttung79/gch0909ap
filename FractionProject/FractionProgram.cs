using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FractionProject
{
    public class FractionProgram : MenuProgram
    {
        protected override void PrintMenu()
        {
            Console.WriteLine("1. Add fractions");
            Console.WriteLine("2. Subtract fractions");
            Console.WriteLine("3. Multiply fractions");
            Console.WriteLine("4. Divide fractions");
            Console.WriteLine("0. Exit");
        }
        protected void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddFractions(); break;
                case 2: SubtractFractions(); break;
                case 3: MultiplyFractions(); break;
                case 4: DivideFractions(); break;
                case 0: Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
        private Fraction GetFraction(string message)
        {
            bool invalid = true;
            Fraction f = new Fraction();
            while (invalid)
            {
                try
                {
                    Console.WriteLine(message);
                    int numerator = GetInteger("Enter the numerator: ");
                    int denominator = GetInteger("Enter the denominator: ");
                    f = new Fraction(numerator, denominator);
                    invalid = false;
                }
                catch (FractionException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return f;
        }
        private int GetInteger(string message)
        {
            bool invalid = true;
            int number = 0;
            while (invalid)
            {
                Console.Write(message);
                try 
                {
                    number = int.Parse(Console.ReadLine());
                    invalid = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Must be integer!");
                }
            }
            return number;
        }
        private void AddFractions()
        {
            Fraction f1 = GetFraction("Enter the first fraction: ");
            Fraction f2 = GetFraction("Enter the second fraction: ");
            Fraction f3 = f1.Add(f2);
            Console.WriteLine(f1 + " + " + f2 + " = " + f3);
        }
        private DivideFraction()
        {
            Fraction f1 = GetFraction("Enter the first fraction: ");
            Fraction f2 = GetFraction("Enter the second fraction: ");
            try
            {
                Fraction f3 = f1.Divide(f2);
                Console.WriteLine(f1 + " / " + f2 + " = " + f3);
            }
            catch (FractionException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}