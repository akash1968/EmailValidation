using System;

namespace EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the emailId : ");
            string email = Console.ReadLine();
            RegEx re = new RegEx();
            re.EmailIdValidation(email);

        }
    }
}
