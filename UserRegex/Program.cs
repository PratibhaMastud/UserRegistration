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
                Console.WriteLine("Enter Password");
                string pass = Console.ReadLine();
                Boolean output = UserRegistration.regexPassword(pass);
                if (output == true)
                {
                    Console.WriteLine("Valid Password");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Password should have one Numeric Number");
                }
            }
        }
    }
}
