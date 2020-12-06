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
                Console.WriteLine("Enter Email");
                string email = Console.ReadLine();
                Boolean output = UserRegistration.regexEmail(email);
                if (output == true)
                {
                    Console.WriteLine("Valid email");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Enter email in this format : abc.xyz@co.in");
                }
            }

        }
    }
}
