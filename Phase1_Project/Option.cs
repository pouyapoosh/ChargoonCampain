using Microsoft.VisualBasic.FileIO;
using Phase1_Project.Enum;
using Phase1_Project.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Phase1_Project
{
    public class Option
    {
        public static void Option1()
        {
            Console.Clear();

            List<DataModel.Person> People = new();

            Console.WriteLine("Enter your first name : ");
            var firstName = Console.ReadLine();
            while ((string.IsNullOrEmpty(firstName) == true || Regex.IsMatch(firstName, "^[a-zA-Z]") == false))
            {
                Console.WriteLine("Invalid input! Input your first name once more");
                firstName = Console.ReadLine();
            }

            Console.WriteLine("Enter your last name : ");
            var lastName = Console.ReadLine();
            while ((string.IsNullOrEmpty(lastName) == true || Regex.IsMatch(lastName, "^[a-zA-Z]") == false))
            {
                Console.WriteLine("Invalid input! Input your last name once more");
                lastName = Console.ReadLine();
            }

            Console.WriteLine("Enter your gender(m/f) : ");
            Gender gender;
        Label1:
            string g = Console.ReadLine().ToString().ToLower();
            switch (g)
            {
                case "m":
                    gender = Gender.Male;
                    break;
                case "f":
                    gender = Gender.Female;
                    break;
                default:
                    //throw new Exception("gender Is Invalid");
                    Console.WriteLine("gender Is Invalid! Input your gender once more");
                    goto Label1;
            }

            Console.WriteLine("Enter your personal ID : ");
            // int personalID = int.Parse(Console.ReadLine());
            var personalID = Console.ReadLine();
            if (String.IsNullOrEmpty(personalID))
            {
                Console.WriteLine("personal ID can't be empty! Input your personal ID once more");
                personalID = Console.ReadLine();
            }
            if (!int.TryParse(personalID, out int ID))
            {
                Console.WriteLine("Invalid input - must be a valid integer! Input your personal ID once more");
                personalID = Console.ReadLine();
            }

            Console.WriteLine("Enter your address : ");
            var address = Console.ReadLine();
            while ((string.IsNullOrEmpty(address) == true || Regex.IsMatch(address, "^[a-zA-Z]") == false))
            {
                Console.WriteLine("Invalid input! Input your address once more");
                address = Console.ReadLine();
            }
            Console.WriteLine();

            People.Add(new DataModel.Person() { FirstName = firstName, LastName = lastName, Gender = gender, PersonalID = ID, Address = address });

        Label2:
            String[] options = { "1- Theft", "2- Fire", "3- Dyspnea" };
            Menu.PrintMenu(options);

            int e = int.Parse(Console.ReadLine());
            switch (e)
            {
                case (int)Event.Theft:
                    new Police().ReceiveServices();
                    Logger.Write("Police", People[0]);
                    break;

                case (int)Event.Fire:
                    new FireStation().ReceiveServices();
                    Logger.Write("FireStation", People[0]);
                    break;

                case (int)Event.Dyspnea:
                    new Emergency().ReceiveServices();
                    Logger.Write("Emergency", People[0]);
                    break;
                default:
                    //throw new Exception("Number Is Invalid");
                    Console.WriteLine("Number Is Invalid!");
                    goto Label2;
            }
        }

        public static void Option2()
        {
            Console.Clear();

            System.Console.WriteLine("\n - History of previous requests -\n ");
        Label:
            String[] options = { "1.All services provided", "2.Fire services", "3.Emergency services", "4.Police service for men", "5.Police services for women" };
            int option = 0;
            Menu.PrintMenu(options);
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter an integer value between 1 and " + options.Length);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error happened. Please try again");
            }
            switch (option)
            {
                case 1:
                    Logger.ReadAll();
                    break;
                case 2:
                    Logger.FireFilter();
                    break;
                case 3:
                    Logger.EmergencyFilter();
                    break;
                case 4:
                    Logger.PoliceMenFilter();
                    break;
                case 5:
                    Logger.PoliceWomenFilter();
                    break;
                default:
                    //throw new Exception("Number Is Invalid");
                    Console.WriteLine("Number Is Invalid!\n");
                    goto Label;
            }
        }
    }
}



