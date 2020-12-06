using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegex
{
    class UserRegistration
    {
        public static bool regexFirstName(string first_name)
        {
            String namePattern = "^[A-Z]{1}[a-z]{2,}";
            Regex obj = new Regex(namePattern);
            return obj.IsMatch(first_name);
        }
    }
}
