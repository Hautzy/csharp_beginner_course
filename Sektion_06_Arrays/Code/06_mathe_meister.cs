using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_06
{
    class _06_mathe_meister
    {
        public static void Run()
        {
            const int CALC_COUNT = 10;
            const int MAX_NUMBER = 10;

            int corrects = 0;
            int wrongs = 0;

            int[,] calculations = new int[CALC_COUNT, 3];
            double[] calcResults = new double[CALC_COUNT];
            int[,] answers = new int[CALC_COUNT, 2];

            Random random = new Random();

            string input = "";

            for (int i = 0; i < calculations.GetLength(0); i++)
            {
                calculations[i, 0] = random.Next(1, MAX_NUMBER);
                calculations[i, 2] = random.Next(1, MAX_NUMBER);
                calculations[i, 1] = random.Next(0, 3);

                switch(calculations[i, 1])
                {
                    case 0:
                        calcResults[i] = calculations[i, 0] + calculations[i, 2];
                        break;
                    case 1:
                        calcResults[i] = calculations[i, 0] - calculations[i, 2];
                        break;
                    case 2:
                        calcResults[i] = calculations[i, 0] * calculations[i, 2];
                        break;
                }
            }

            do
            {
                int selection = random.Next(0, CALC_COUNT);
                char op = ' ';
                double result = 0.0;
                switch(calculations[selection, 1])
                {
                    case 0:
                        op = '+';
                        break;
                    case 1:
                        op = '-';
                        break;
                    case 2:
                        op = '*';
                        break;
                }
                Console.Write("\n{0} {1} {2} = ", calculations[selection, 0], op, calculations[selection, 2]);
                input = Console.ReadLine();
                if(input != "X" && input != "x")
                {
                    result = Convert.ToDouble(input);
                    if(calcResults[selection] == result)
                    {
                        answers[selection, 0]++;
                        corrects++;
                    }
                    else
                    {
                        answers[selection, 1]++;
                        wrongs++;
                    }
                }
            } while (input != "X" && input != "x");
            Console.WriteLine("\nStopping program...\n");

            Console.WriteLine("Results:\n");

            Console.WriteLine("{0, -16}{1, -12}{2, -12}", "Calculation", "Correct", "Wrong");
            for (int i = 0; i < calculations.GetLength(0); i++)
            {
                if (answers[i, 0] + answers[i, 1] > 0)
                {
                    char op = ' ';
                    switch (calculations[i, 1])
                    {
                        case 0:
                            op = '+';
                            break;
                        case 1:
                            op = '-';
                            break;
                        case 2:
                            op = '*';
                            break;
                    }
                    Console.WriteLine("{0, -16}{1, -12}{2, -12}", calculations[i, 0] + " " + op + " " + calculations[i, 2] + " = " + calcResults[i], answers[i, 0], answers[i, 1]);
                }
            }
            Console.WriteLine("\n{0} Corrects", corrects);
            Console.WriteLine("{0} Wrongs", wrongs);
            Console.ReadLine();
        }
    }
}
