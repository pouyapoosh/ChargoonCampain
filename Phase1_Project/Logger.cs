using Phase1_Project.DataModel;
using Phase1_Project.Enum;
using Phase1_Project.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Phase1_Project
{
    public static class Logger
    {
        private static List<LogModel> LogsList { get; set; } = new List<LogModel>();
        public static void Write(string service, Person person)
        {
            LogsList.Add(new LogModel()
            {
                ServiceName = service,
                Person = person
            });
        }

        public static void ReadAll()
        {
            foreach (LogModel item in LogsList)
            {
                Console.WriteLine("first name: " + item.Person.FirstName + "\t" + "last name: " + item.Person.LastName + "\t" + "gender: "
                    + item.Person.Gender + "\t" + "personal ID: " + item.Person.PersonalID + "\t" + "address: "
                    + item.Person.Address + "\t" + "service: " + item.ServiceName);
            }
        }

        public static void FireFilter()
        {
            foreach (var item in LogsList)
            {
                if (item.ServiceName == "FireStation")
                {
                    Console.WriteLine("first name: " + item.Person.FirstName + "\t" + "last name: " + item.Person.LastName + "\t" + "gender: "
                        + item.Person.Gender + "\t" + "personal ID: " + item.Person.PersonalID + "\t" + "address: "
                        + item.Person.Address + "\t" + "service: " + item.ServiceName);
                }
            }
        }


        public static void EmergencyFilter()
        {
            foreach (var item in LogsList)
            {
                if (item.ServiceName == "Emergency")
                {
                    Console.WriteLine("first name: " + item.Person.FirstName + "\t" + "last name: " + item.Person.LastName + "\t" + "gender: "
                        + item.Person.Gender + "\t" + "personal ID: " + item.Person.PersonalID + "\t" + "address: "
                        + item.Person.Address + "\t" + "service: " + item.ServiceName);
                }
            }
        }

        public static void PoliceMenFilter()
        {
            foreach (var item in LogsList)
            {
                if (item.Person.Gender == Gender.Male && item.ServiceName == "Police")
                {
                    Console.WriteLine("first name: " + item.Person.FirstName + "\t" + "last name: " + item.Person.LastName + "\t" + "gender: "
                        + item.Person.Gender + "\t" + "personal ID: " + item.Person.PersonalID + "\t" + "address: "
                        + item.Person.Address + "\t" + "service: " + item.ServiceName);
                }
            }
        }

        public static void PoliceWomenFilter()
        {
            foreach (var item in LogsList)
            {
                if (item.Person.Gender == Gender.Female && item.ServiceName == "Police")
                {
                    Console.WriteLine("first name: " + item.Person.FirstName + "\t" + "last name: " + item.Person.LastName + "\t" + "gender: "
                        + item.Person.Gender + "\t" + "personal ID: " + item.Person.PersonalID + "\t" + "address: "
                        + item.Person.Address + "\t" + "service: " + item.ServiceName);
                }
            }
        }


    }
}
