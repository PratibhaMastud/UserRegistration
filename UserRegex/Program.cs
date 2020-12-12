﻿using System;

namespace UserRegex
{
    class Program
    {
        static void Main(string[] args)
        {
  			int index1 = 0;

			// ASSIGING SOME VALID SAMPLES
			string[] validEmailSample = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com",
				"abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com",
				".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com",
				"abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };

			UserRegistration userRegistration = new UserRegistration();
			while (index1 < validEmailSample.Length)
			{
				string email = validEmailSample[index1];
				bool flag = userRegistration.regexEmail(email);
				if (flag == true)
				{
					Console.WriteLine("This is valid  email");
					Console.WriteLine("{0} :\t is the valid  email", email);
				}
				else
				{
					Console.WriteLine("This is Invalid  email");
					Console.WriteLine("{0} : \t is the Invalid  email", email);

				}
				index1++;
			}
		}
	}
           
   
