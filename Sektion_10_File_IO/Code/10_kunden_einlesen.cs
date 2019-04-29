using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Examples.sektion_10
{
    class _10_kunden_einlesen
    {
        public struct Customer
        {
            public string firstName;
            public string lastName;
            public string country;
            public double sales;
            public double taxPercentage;
            public double taxes;
            public string currency;
        }
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 100;

        public static void Run()
        {
            Customer[] customers = new Customer[10];
            int count = 0;
            string path = "kunden.csv";

            customers = ReadCustomers(path, customers, ref count);
            Print(customers, count);

            NewData(customers, count);
            Sort(customers, count);
            Writer(path, customers, count);
            
            Console.ReadLine();
        }

        public static void Writer(string path, Customer[] customers, int count)
        {
            Console.WriteLine("Writing...");
            string[] lines = new string[count];
            for (int i = 0; i < count; i++)
            {
                Customer c = customers[i];
                lines[i] = c.firstName + ";" + c.lastName + ";" + c.country + ";" + c.sales + ";" + c.taxPercentage + ";" + c.taxes + ";" + c.currency;
            }
            File.WriteAllLines(path, lines);
        }

        public static void NewData(Customer[] customers, int count)
        {
            Console.WriteLine("Generate new data...");
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                customers[i].sales = random.Next(MIN_VALUE, MAX_VALUE);
                customers[i].taxes = Math.Round(customers[i].sales * customers[i].taxPercentage, 2);
            }
        }

        public static Customer[] ReadCustomers(string path, Customer[] customers, ref int count)
        {
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(";");
                Customer customer = new Customer();
                customer.firstName = parts[0];
                customer.lastName = parts[1];
                customer.country = parts[2];
                customer.sales = Convert.ToDouble(parts[3]);
                customer.taxPercentage = Convert.ToDouble(parts[4]);
                customer.taxes = Convert.ToDouble(parts[5]);
                customer.currency = parts[6];
                customers = Add(customer, customers, ref count);
            }
            return customers;
        }

        public static Customer[] Add(Customer newCustomer, Customer[] customers, ref int count)
        {
            if(count >= customers.Length)
            {
                Customer[] arr = new Customer[customers.Length * 2];
                arr[count] = newCustomer;
                count++;
                return arr;
            }
            customers[count] = newCustomer;
            count++;
            return customers;
        }

        public static void Sort(Customer[] customers, int count)
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (customers[j].sales < customers[j + 1].sales)
                    {
                        Customer temp = customers[j];
                        customers[j] = customers[j + 1];
                        customers[j + 1] = temp;
                    }
                }
            }
        }

        public static void Print(Customer[] customers, int count)
        {
            Console.WriteLine("{0, -15} {1, -15} {2, -15} {3, -10} {4, -10} {5, -10}", "firstName", "lastName", "country", "sales", "tax(%)", "taxes");
            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                Customer c = customers[i];
                Console.WriteLine("{0, -15} {1, -15} {2, -15} {3, -10} {4, -10} {5, -10}", c.firstName, c.lastName, c.country, c.sales + " " + c.currency, c.taxPercentage * 100 + "%", c.taxes + " " + c.currency);
            }
        }
    }
}
