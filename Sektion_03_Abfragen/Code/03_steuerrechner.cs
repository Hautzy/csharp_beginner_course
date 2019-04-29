using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_03
{
    class _03_steuerrechner
    {
        public static void Run()
        {
            const double TAX_OTHER = 0.2;
            const double TAX_GERMANY = 0.18;

            double tax = 0.0;
            double income = 0.0;
            string country = "";
            int children = 0;
            double incomeTax = 0.0;
            double countryTax = 0.0;

            Console.Write("yearly income: ");
            income = Convert.ToDouble(Console.ReadLine());

            Console.Write("country: ");
            country = Console.ReadLine();

            Console.Write("children: ");
            children = Convert.ToInt32(Console.ReadLine());

            if(country == "Germany")
            {
                countryTax = TAX_GERMANY;
            }
            else
            {
                countryTax = TAX_OTHER;
            }

            if(income > 100000)
            {
                incomeTax += 0.1;
            }
            else if(income > 60000)
            {
                incomeTax += 0.04;
            }

            if(children > 4)
            {
                children = 4;
            }

            tax = (countryTax + incomeTax) * income;
            tax -= tax * children * 0.05;

            Console.WriteLine("\ncountry tax: +{0}%", countryTax * 100);
            Console.WriteLine("income tax: +{0}%", incomeTax * 100);
            Console.WriteLine("children tax reduction: -{0}% from taxes", children * 0.05 * 100);

            Console.WriteLine("\nyour taxes are {0:c}", tax);
            Console.ReadLine();
        }
    }
}
