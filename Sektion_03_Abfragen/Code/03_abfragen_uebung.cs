using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_03
{
    class _03_abfragen_uebung
    {
        public static void Run()
        {
            bool isRich = true;
            int countOfDogs = 5;
            string country = "Germany";

            Console.WriteLine(isRich && countOfDogs > 10);
            Console.WriteLine(!isRich && countOfDogs > 5 && countOfDogs < 8 && country == "Germany");
            Console.WriteLine(countOfDogs % 2 == 0 && country != "Germany");
            Console.WriteLine(isRich && countOfDogs <= 0 && (country == "Germany" || country == "Austria"));
        }
    }
}
