using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Danse_namespace;
using Fodbold_namespace;

namespace Password_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password, username, j;
            int password_length = 0;

            bool hasLower = false, hasUpper = false, hasDigit = false, specialChar = false, normal_char = false, hasWhitespace = false, hasNumbers = false, first_position = false, last_position = false;
            string normalChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string spl_Chars = "!#¤%&/()=?_-><^{}@£$€[]";
            string numbers = "1234567890", first_char, last_char;

            danse d = new danse();
            Fodbold f = new Fodbold();

        start:
            Console.WriteLine("\t\t\t USER LOGIN MENU");
            Console.Write("Enter username: ");
            username = Console.ReadLine();
            Console.Write("Password:  ");
            password = Console.ReadLine();

            password = password.Trim();
            password_length = password.Length;
            password.StartsWith(numbers);

            first_char = password.Substring(0, 1);
            last_char = password.Substring(password_length - 1, 1);


            for (int i = 0; i < password_length; i++)
            {
                if (char.IsLower(password[i])) hasLower = true;
                if (char.IsUpper(password[i])) hasUpper = true;
                if (char.IsDigit(password[i])) specialChar = true;
                if (normalChars.Contains(password[i])) normal_char = true;
                if (spl_Chars.Contains(password[i])) specialChar = true;
                if (password.Contains(" ")) hasWhitespace = true;
                if (numbers.Contains(password[i])) hasNumbers = true;
                if (numbers.Contains(first_char)) first_position = true;
                if (numbers.Contains(last_char)) last_position = true;

            }

            if (hasUpper && hasLower && specialChar && normal_char && hasNumbers && hasWhitespace == false && password_length > 12 && first_position == false && last_position == false && username.ToLower() != password.ToLower())
            {


                Console.WriteLine("Godkendt password.");
                string skrivetofile = username + " " + password;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\ramkai\Desktop\User_Details.txt", true))
                {
                    file.WriteLine(skrivetofile);
                }
                Console.Write("Vil du gerne ændre password?(Tryk y/Y eller n/N) ");
                string choice = Console.ReadLine();
                choice = choice.ToLower();
                if (choice == "y")
                {
                    Console.Clear();
                    goto start;
                }
                if (choice == "n")
                {
                    Console.WriteLine("Taking you to Game Menu....");
                    Console.Clear();
                    Console.WriteLine("\t\t\t MAIN MENU");
                    Console.WriteLine("\t 1.FODBOLD");
                    Console.WriteLine("\t 2.DANSE");
                    Console.WriteLine("\t 3.USER LOGIN MENU");
                    Console.WriteLine("\t 4.EXIT");
                    Console.Write("Tryk 1 for FODBOLD, 2 for DANSE,3 FOR USER LOGIN MENU,4 to EXIT:   ");
                    string f_d = Console.ReadLine();
                    switch (f_d)
                    {
                        case "1":
                            Console.Clear();
                            f.foldbold_method();
                            Console.Clear();
                            goto start;
                            

                        case "2":
                            Console.Clear();
                            d.danse_method();
                            Console.Clear();
                            goto start;

                        case "3":
                            Console.Clear();
                            goto start;

                        case "4":
                            Console.Clear();
                            Console.WriteLine("Closing all windows and exiting the application....");
                            Environment.Exit(0);
                            Console.ReadKey();
                            break;


                    }
                }

            }
            else
            {
                Console.WriteLine("Ikke Gondkendt password,Prøv igen...");
                Console.ReadKey();
                Console.Clear();
                goto start;

            }
            Console.ReadKey();

        }
    }
}
