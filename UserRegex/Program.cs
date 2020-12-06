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
                Console.WriteLine("Enter Last Name");
                string last_name = Console.ReadLine();
                Boolean output = UserRegistration.regexLastName(last_name);
                if (output == true)
                {
                    Console.WriteLine("Valid Last Name");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Please Enter valid Last Name starting with capital letter and should have minimum 3 Character in the string");
                }
            }
            
        }
    }
}
