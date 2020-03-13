using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter a numerical PIN. This number must be between 4 and 8 digits.");
            string userPin = Console.ReadLine();

            bool ValidPin(string Pin)
            {
                int number;
                bool parsable = Int32.TryParse(Pin, out number);
                if (!parsable || Pin.Length > 8 || Pin.Length < 4)
                {
                    return false;
                }
                else return true;
            }
            Console.WriteLine(ValidPin(userPin));
            Console.ReadLine();*/

            /*Console.WriteLine("Enter a phone number");
            string phone = Console.ReadLine();

            string phoneDigits = phone.Replace("(", "").Replace(")", "").Replace("-", "");

            bool ValidPhone(string Phone)
            {
                string firstThree = Phone.Substring(0, 3);
                if (firstThree == "555" || Phone.Length != 10)
                {
                    return false;
                }
                else return true;
            }

            Console.WriteLine(ValidPhone(phoneDigits));
            Console.ReadLine();*/

            Console.WriteLine("Please enter an email address");
            string userEmail = Console.ReadLine();

            bool ValidEmail(string email)
            {
                
            }

            Console.WriteLine(ValidEmail(userEmail));
            Console.ReadLine();

        }

        
        
        
    }
}
