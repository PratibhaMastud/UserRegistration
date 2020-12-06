using System;

namespace UserRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i != 1)
            {
                Console.WriteLine("Enter phoneNumber");
                string phoneNumber = Console.ReadLine();
                Boolean output = UserRegistration.regexPhoneNumber(phoneNumber);
                if (output == true)
                {
                    Console.WriteLine("Valid phone Number");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Enter phone Number in format");
                }
            }
        }
    }
}
