using System;

namespace UserRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            int i = 0;
            while (i != 1)
            {
                Console.WriteLine("Enter First Name");
                string first_name = Console.ReadLine();
                Boolean output = UserRegistration.regexFirstName(first_name);
                if (output == true)
                {
                    Console.WriteLine("Valid firstName");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Please Enter valid First Name starting with capital letter and should have minimum 3 Character in the string");
                }
            }
            
        }
    }
}
