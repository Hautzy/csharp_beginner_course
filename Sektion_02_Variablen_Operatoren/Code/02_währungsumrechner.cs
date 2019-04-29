using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_02
{
    class _02_währungsumrechner
    {
        public static void Run()
        {
            int euro;
            double moneyInDollar = 0;
            double moneyInSwFr = 0;
            const double euroToDollar = 1.12;
            const double euroToSwFr = 1.14;

            Console.Write("Enter euros: ");
            euro = Convert.ToInt32(Console.ReadLine());

            moneyInDollar = euro * euroToDollar;
            moneyInSwFr = euro * euroToSwFr;

            Console.WriteLine("Dollar: {0}", moneyInDollar);
            Console.WriteLine("Schweizer Franken: {0}", moneyInSwFr);

            Console.ReadLine();
        }
    }
}
