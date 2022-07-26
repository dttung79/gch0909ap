using System;

namespace CompanyVacation
{
    class Program
    {
        const int DANANG = 1;
        const int HALONG = 2;
        const int PHUYEN = 3;
        const int ADULT_DANANG = 100;
        const int ADULT_HALONG = 60;
        const int ADULT_PHUYEN = 120;
        const int CHILD_DANANG = 50;
        const int CHILD_HALONG = 30;
        const int CHILD_PHUYEN = 80;
        const int ADULT_DISCOUNT = 50;
        const int CHILD_DISCOUNT = 25;

        static void Main(string[] args)
        {
            while (true)
            {
                PrintPlaces();
                int place = GetPlace();
                int nAdults = GetFamilyMembers("adult");
                int nChildren = GetFamilyMembers("children");
                int payment = GetPayment(place, nAdults, nChildren);
                Pay(payment);
            }
        }
        static void PrintPlaces()
        {
            Console.WriteLine("1. Đà Nẵng ($100 người lớn, $50 trẻ em)");
            Console.WriteLine("2. Hạ Long ($60 người lớn, $30 trẻ em)");
            Console.WriteLine("3. Phú Yên ($120 người lớn, $80 trẻ em)");
        }
        static int GetPlace()
        {
            Console.Write("Enter place to go: ");
            int place = int.Parse(Console.ReadLine());
            return place;
        }
        static int GetFamilyMembers(string familyType)
        {
            Console.Write("Enter number of {0}: ", familyType);
            int n = int.Parse(Console.ReadLine());
            return n;
        }

        static int GetPayment(int place, int nAdults, int nChildren)
        {
            int adult_price = 0;
            int child_price = 0;
            switch (place)
            {
                case DANANG:
                    adult_price = ADULT_DANANG;
                    child_price = CHILD_DANANG;
                    break;
                case HALONG:
                    adult_price = ADULT_HALONG;
                    child_price = CHILD_HALONG;
                    break;
                case PHUYEN:
                    adult_price = ADULT_PHUYEN;
                    child_price = CHILD_PHUYEN;
                    break;
                default:
                    Console.WriteLine("Invalid place");
                    break;
            }
            int payment = (nAdults * adult_price) + (nChildren * child_price);
            int nAdultSupport = GetNumberOfSupport("adult");
            int nChildSupport = GetNumberOfSupport("children");
            payment -= (nAdultSupport * ADULT_DISCOUNT) + (nChildSupport * CHILD_DISCOUNT);
            return payment;
        }
        static int GetNumberOfSupport(string familyType)
        {
            Console.Write("Enter number of {0} support: ", familyType);
            int n = int.Parse(Console.ReadLine());
            // validate n based familyType
            return n;
        }
        static void Pay(int payment)
        {
            Console.WriteLine("Payment: {0}", payment);
            // enter payment, return change
        }
    }
}
