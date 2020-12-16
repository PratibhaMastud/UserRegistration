using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationPro
{
    public class UserRegistration
    {
        public static string messege = "Happy";
        public static string Pattern = "^([A-Z]{1})+[a-z]{2,}$";
        public static string EmailID = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.,-]+$";
        public static string MobileNo = "^([+][9]{1}[1]{1}[ ])[0-9]{10}";
        public static string Password = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-]).{8,}$";

        public bool FirstName(string First_Name)
        {
            try
            {
                Regex regex = new Regex(Pattern);
                bool result = regex.IsMatch(First_Name);
                return result;
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_FirstName, "Invalid Name Please Type Valid One");
            }
        }

        public bool LastName(string Last_Name)
        {
            try
            {
                Regex regexObj1 = new Regex(Pattern);
                bool result = regexObj1.IsMatch(Last_Name);
                return result;
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_LastName, "Invalid Name Please Type Valid One");
            }
        }
        public bool checkEmail(string Emailid)
        {
            try
            {
                Regex regexObj2 = new Regex(EmailID);
                bool result = regexObj2.IsMatch(Emailid);
                return result;
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_EmailId, "Invalid Email Please Type Valid One");
            }
        }

        public bool MobileNumber(string Mobile)
        {
            try
            {
                Regex regexObj3 = new Regex(MobileNo);
                bool result = regexObj3.IsMatch(Mobile);
                return result;
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_MobileNo, "Invalid Mobile No Please Type Valid One");
            }
        }

        public bool MessageCheck(string Msg)
        {
            Regex Ms = new Regex(messege);
            bool Validate = Ms.IsMatch(Msg);
            return Validate;
        }

        public bool Pasword(string Pwd)
        {
            try
            {
                Regex regexObj4 = new Regex(Pwd);
                bool result = regexObj4.IsMatch(Pwd);
                return result;
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_Password, "Invalid Password Please Type Valid One");
            }
        }

        /// <summary>
        /// Using Lambda Expression
        /// </summary>
        public static Func<string, bool> ValidateUserDetailFirstName = First_Name => Regex.IsMatch(First_Name, Pattern);
        public static Func<string, bool> ValidateUserDetailLAstNAme = Last_Name => Regex.IsMatch(Last_Name, Pattern);
        public static Func<string, bool> ValidateEMail = Mail => Regex.IsMatch(Mail, EmailID);
        public static Func<string, bool> ValidateMobile = Mobile => Regex.IsMatch(Mobile, MobileNo);
        public static Func<string, bool> ValidatePassword = Pwd => Regex.IsMatch(Pwd, Password);
    }
}


