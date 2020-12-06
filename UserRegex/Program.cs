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
                Console.WriteLine("Enter mobile number");
                string mobNo = Console.ReadLine();
                Boolean output = UserRegistration.regexMobileNo(mobNo);
                if (output == true)
                {
                    Console.WriteLine("Mobile number correct");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Enter mobile number in this format : 91 9987984567");
                }
            }

        }
    }
}
