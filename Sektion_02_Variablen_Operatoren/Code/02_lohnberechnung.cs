using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_02
{
    class _02_lohnberechnung
    {
        public static void Run()
        {
            string name = "";
            int hours = 0;
            double moneyPerHour = 0;
            double money = 0;

            Console.Write("Name of employee: ");
            name = Console.ReadLine();

            Console.Write("Hours of work: ");
            hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Money per hour: ");
            moneyPerHour = Convert.ToDouble(Console.ReadLine());

            money = hours * moneyPerHour;
            Console.WriteLine("Employee {0} earned {1} in {2} hours.", name, money, hours);

            Console.ReadLine();
        }
    }
}
