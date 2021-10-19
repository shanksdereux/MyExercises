using System;

namespace TheCouponCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int theCorrectCode = 123;
            DateTime theExpirationDate = new DateTime(2021, 10, 17);
            string ExpirationDate = theExpirationDate.ToString("MMMM dd, yyyy");

            Console.WriteLine("Enter the code: ");
            string theCode = Console.ReadLine();

            Console.WriteLine("Enter the Date: ");
            string theDate = Console.ReadLine();

            Console.WriteLine(CheckCoupon(theCode, theCorrectCode.ToString(), theDate, ExpirationDate));
            Console.ReadKey();

        }

        private static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        {
            DateTime theCurrentDate = DateTime.Parse(currentDate);
            DateTime theExpirationDate = DateTime.Parse(expirationDate);

            if (enteredCode == correctCode && theCurrentDate <= theExpirationDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
