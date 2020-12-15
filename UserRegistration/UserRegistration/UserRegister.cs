using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
   public class UserRegister
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
            string expression = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.,-]+$";
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

        public static bool validateEmailList(string email)
        {
            String emailPattern = "^([A-Za-z\\d-_\\+]+)(\\.[A-Za-z\\d-_]+)?@([a-zA-Z\\d]+)\\.([a-zA-Z]{2,4})(\\.[A-Za-z]{2,4})?$";
            Regex obj = new Regex(emailPattern);
            return obj.IsMatch(email);
        }
    }
}

