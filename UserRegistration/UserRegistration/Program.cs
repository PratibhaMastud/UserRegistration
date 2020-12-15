using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration ");
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine(UserRegister.validateFirstName(firstName));
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine(UserRegister.validateLastName(lastName));
            Console.WriteLine("Enter Email Address");
            string email = Console.ReadLine();
            Console.WriteLine(UserRegister.validateEmail(email));
            Console.WriteLine("Enter Mobile Number");
            string mobileNo = Console.ReadLine();
            Console.WriteLine(UserRegister.validateMobileNo(mobileNo));
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            Console.WriteLine(UserRegister.validatePassword(password));
            Console.WriteLine("-------------------Email Sample Validator-----------------");
            EmailSamples.emailValidator();
        }
    }
}
