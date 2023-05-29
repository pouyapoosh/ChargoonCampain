using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1_Project
{
    public class Menu
    {
        public static void PrintMenu(String[] options)
        {
            Console.WriteLine("Choose your option : ");

            foreach (String option in options)
            {
                Console.WriteLine(option);
            }
        }
    }
}
