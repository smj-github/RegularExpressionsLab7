using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //------ First Name -------
            string firstName = GetUserInput("Please enter your first name. (Ex: John)");

            while (!ValidateName(firstName))
            {
                Console.WriteLine("Invalid Name. Try Again");
                firstName = Console.ReadLine();
            }
            Console.WriteLine("Valid first name");

            //---------- Last Name ---------
            string lastName = GetUserInput("\nPlease enter your last name. (Ex: Smith)");

            while (!ValidateName(lastName))
            {
                Console.WriteLine("Invalid Name. Try Again");
                lastName = Console.ReadLine();
            }
            Console.WriteLine("Valid last name");

            //--------- Emails --------
            string email = GetUserInput("\nPlease enter your email. (Ex: someone@gmail.com)");
            while (!ValidateEmail(email))
            {
                Console.WriteLine("Invalid Email. Try Again");
                email = Console.ReadLine();
            }
            Console.WriteLine("Valid email");

            //--------- Phone number --------
            string phoneNumber = GetUserInput("\nPlease enter your phone number. (Ex: 432-311-0312)");
            while (!ValidatePhoneNumber(phoneNumber))
            {
                Console.WriteLine("Invalid Phone number. Try Again");
                phoneNumber = Console.ReadLine();
            }
            Console.WriteLine("Valid phone number");

            //--------- Date --------
            string dateString = GetUserInput("\nPlease enter date as dd/mm/yyyy");
            while (!ValidateDate(dateString))
            {
                Console.WriteLine("Invalid Date. Try Again");
                dateString = Console.ReadLine();
            }
            Console.WriteLine("Valid date");

            //--------- HTML tag --------
            string htmlTag = GetUserInput("\nPlease enter html tag");
            while (!ValidateHTMLTag(htmlTag))
            {
                Console.WriteLine("Invalid tag. Try Again");
                htmlTag = Console.ReadLine();
            }
            Console.WriteLine("Valid tag");

        }

        // This method gets the input from the user
        public static string GetUserInput(string strMessage)
        {
            Console.WriteLine(strMessage);
            string input = Console.ReadLine();
            return input;
        }

        // This method validates the input so that the first letter is Upper case and 
        // has no digits, with a max of 30 characters in length
        public static bool ValidateName(string input)
        {
            //if(Regex.IsMatch(input, @"\b([A-Z][a-z]{1,29})\S\D\b"))
            //if (Regex.IsMatch(input, @"(^([A-Z][a-z]{1,29})\S\D$)"))
            //if (Regex.IsMatch(input, @"(^([A-Z][a-z]{1,29})\S\D?([A-Z][a-z]{1,29})\S\D$)"))
            if (Regex.IsMatch(input,@"^([A-Z][a-z]{1,29})$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
                
        public static bool ValidateEmail(string input)
        {            
            if (Regex.IsMatch(input, @"([a-zA-Z0-9\-\._]{5,30})@([a-zA-Z0-9\-\.]{5,10})\.([a-z]{2,5})$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidatePhoneNumber(string input)
        {
            if (Regex.IsMatch(input, @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$"))            
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateDate(string input)
        {            
            if (Regex.IsMatch(input, @"((0[1-9]|1[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/(\d\d\d\d))$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateHTMLTag(string input)
        {
            //if (Regex.IsMatch(input, "< (\"[^\"]*\"|'[^']*'|[^'\">])*>"))
            if (Regex.IsMatch(input, @"<(([a-z]*)|([a-z]*[1-9]))></(([a-z]*)|([a-z]*[1-9]))>"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
