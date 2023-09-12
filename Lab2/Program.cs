// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Lab1
{

    class Address
    {
        public int index { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int house { get; set; }
        public int apartment { get; set; }
    }


    class Converter
    {
        public Converter()
        {
            double UAHtoUSD = 0.027;
            double USDtoUAH = 36.76;
            double Uah, Usd;
            int a;

            Console.WriteLine("enter UAH or USD value:");
            if (Console.ReadLine() == "Uah")
            {
                Console.WriteLine("Enter Uah value: ");
                Uah = int.Parse(Console.ReadLine());
                Console.WriteLine(Uah + "into USD = " + Uah * UAHtoUSD);
            }
            else
            {
                Console.WriteLine("Enter Usd value: ");
                Usd = int.Parse(Console.ReadLine());
                Console.WriteLine(Usd + "into USD = " + Usd * USDtoUAH);
            }
        }
    }


    class Employee
    {
        public Employee()
        {
            string FIO;
            int a = 15681;
            int b = 29169;
            int c = 36456;
            Console.WriteLine("Your FIO: ");
            Console.ReadLine();

            Console.WriteLine("Enter ur position:");
            string x = Console.ReadLine();
            if (x == "Leader")
            {
                Console.WriteLine("{0:F2}", ((c * 19.5) / 100) + " - taxes\n" + c + " - salary");
            }
            else if (x == "Driver")
            {
                Console.WriteLine("{0:F2}", ((b * 19.5) / 100) + " - taxes\n" + b + " - salary");
            }
            else
            {
                Console.WriteLine("{0:F2}", ((a * 19.5) / 100) + " - taxes\n" + a + " - salary");
            }
        }

    }


    class User
    {
        public User()
        {
            string login = "OUN";
            string name = "Stepan";
            string surname = "Bandera";
            int age = 50;
            DateTime date = DateTime.Now;
            Console.WriteLine($" login: {login} \n name: {name} \n surname: {surname} \n age: {age} \n Registration date: {date.ToString("yyyy-MM-dd HH:mm:ss")}");
        }

    }
    class MainClass
    {
        public static void Main()
        {
            Address address = new Address();
            address.index = 88888;
            address.country = "Ukraine";
            address.city = "Kyiv";
            address.street = "Banderi";
            address.house = 8;
            address.apartment = 8;
            Console.WriteLine($" index: {address.index} \n country: {address.country} \n city: {address.city} \n street: {address.street} \n house: {address.house} \n apartment: {address.apartment}");

            Employee employee = new Employee();
            Console.WriteLine();

            Converter converter = new Converter();
            Console.WriteLine();

            User user = new User();
            Console.WriteLine();
        }
    }

}


