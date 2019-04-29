using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_02
{
    class _02_kreis_berechnung
    {
        public static void Run()
        {
            double radius = 0.0;
            double area = 0.0;
            double circumference;

            Console.Write("Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * Math.Pow(radius, 2);
            circumference = 2 * Math.PI * radius;

            Console.WriteLine("area: {0} cm^2", area);
            Console.WriteLine("circumference: {0} cm", circumference);

            Console.ReadLine();
        }
    }
}
