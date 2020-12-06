using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegex
{
    class UserRegistration
    {
        public static bool regexPhoneNumber(string phoneNumber)
        {
            string namePattern = "([+][9]{1}[1]{1}\\s)?[6-9]{1}[0-9]{9}";
            Regex obj = new Regex(namePattern);
            return obj.IsMatch(phoneNumber);
        }
    }
}
