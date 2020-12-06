using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegex
{
    class UserRegistration
    {
        public static bool regexMobileNo(string mobileNo)
        {
            string mobileExpression = "([+][9]{1}[1]{1}[ ])?[6-9]{1}[0-9]{9}";
            Regex rg = new Regex(mobileExpression);
            return rg.IsMatch(mobileNo);
        }
    }
}
