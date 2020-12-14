using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationProject
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration ");
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine(UserRegistration.validateFirstName(firstName));
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine(UserRegistration.validateLastName(lastName));
            Console.WriteLine("Enter Email Address");
            string email = Console.ReadLine();
            Console.WriteLine(UserRegistration.validateEmail(email));
            Console.WriteLine("Enter Mobile Number");
            string mobileNo = Console.ReadLine();
            Console.WriteLine(UserRegistration.validateMobileNo(mobileNo));
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            Console.WriteLine(UserRegistration.validatePassword(password));
        }
    }
}

