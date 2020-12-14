using System;
using UserRegistrationProject;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProject
{
   public class UserRegistration
    {
        public static bool validateFirstName(string name)
        {
            string expression = "^[A-Z]{1}[a-z]{2,}";
            Regex regexObj = new Regex(expression);
            return regexObj.IsMatch(name);
        }

        public static bool validateLastName(string name)
        {
            string expression = "^[A-Z]{1}[a-z]{2,}";
            Regex regexObj1 = new Regex(expression);
            return regexObj1.IsMatch(name);
        }

        public static bool validateEmail(string email)
        {
            string expression = "^([a-z]{3,})([.]{0,1}[a-z]*)@([a-z]{2}).([a-z]{2})([.]{1}[a-z]{2}){0,1}$";
            Regex regexObj2 = new Regex(expression);
            return regexObj2.IsMatch(email);
        }

        public static bool validateMobileNo(string mobileNo)
        {
            string expression = "([+][9]{1}[1]{1}[ ])?[6-9]{1}[0-9]{9}";
            Regex regexObj3 = new Regex(expression);
            return regexObj3.IsMatch(mobileNo);
        }

        public static bool validatePassword(string password)
        {
            string expression = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-]).{8,}$";
            Regex regexObj4 = new Regex(expression);
            return regexObj4.IsMatch(password);
        }
    }
}

