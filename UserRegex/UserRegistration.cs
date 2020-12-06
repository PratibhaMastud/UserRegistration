using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegex
{
    class UserRegistration
    {
        public static bool regexPassword(string pass)
        {
            string namePattern = "[0-9]{1}";//Rule:3
            Regex obj = new Regex(namePattern);
            return obj.IsMatch(pass);
        }
    }
}
