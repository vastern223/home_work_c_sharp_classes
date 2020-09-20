using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp5.Products;

namespace ConsoleApp5
{
    partial class Factory
    {
        public string Name { get; set; }

        public Employee[] employee;

        public Products[] Products;

        public Factory()
        {
            Name = "no name";
            employee = null;
            Products = null;
        }

        public void Menu_for_creating_factory()
        {
            int num1 = 0;
            string Name = null;
            string SurName = null;
            DateTime Date_of_mannufacture;
            decimal Salary = 0;
            Console.Write("enter name Factory:");
            Name = Console.ReadLine();

            Console.Write("enter the number employee:");
            num1 = int.Parse(Console.ReadLine());

            employee = new Employee[num1];

            for (int i = 0; i < num1; i++)
            {
                Console.Write((i + 1) + ":enter Name employee:");
                Name = Console.ReadLine();
                Console.Write((i + 1) + ":enter SurName employee:");
                SurName = Console.ReadLine();
                Console.Write((i + 1) + ":enter Salary employee:");
                Salary = int.Parse(Console.ReadLine());
                Console.Write((i + 1) + ":enter year of birthday employee:");
                int year = int.Parse(Console.ReadLine());
                Console.Write((i + 1) + ":enter month of birthday employee:");
                int month = int.Parse(Console.ReadLine());
                Console.Write((i + 1) + ":enter day of birthday employee:");
                int day = int.Parse(Console.ReadLine());
                Date_of_mannufacture = new DateTime(year,month,day);

                employee[i] = new Employee(Name, SurName, Date_of_mannufacture, Salary);
                Console.WriteLine();
            }


            decimal Prise = 0;
            int type = 0;

            Console.Write("enter the number products:");
            num1 = int.Parse(Console.ReadLine());

            Products = new Products[num1];

            for (int i = 0; i < num1; i++)
            {
                Console.Write((i + 1) + ":enter Name products:");
                Name = Console.ReadLine();
                Console.Write((i + 1) + ":enter Prise products:");
                Prise = int.Parse(Console.ReadLine());
                Console.Write((i + 1) + ":enter type products:\n");
                Console.WriteLine(" 1-MealkProductType\n 2-MeatProductType\n 3-NonProductType");
                type = int.Parse(Console.ReadLine());
                Console.Write((i + 1) + ":enter year of graduation products:");
                int year = int.Parse(Console.ReadLine());
                Console.Write((i + 1) + ":enter month of issue products:");
                int month = int.Parse(Console.ReadLine());
                Console.Write((i + 1) + ":enter day of issue products: ");
                int day = int.Parse(Console.ReadLine());
                Date_of_mannufacture = new DateTime(year, month, day);

                Products[i] = new Products(Name, Prise, Date_of_mannufacture, (CategoryType)type);

                Console.WriteLine();
            }

        }
        public void Show_info_of_employee()
        {
            Console.WriteLine("List of employees");
            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine(employee[i].ToString());
            }
        }
        public void Show_info_of_products()
        {
            Console.WriteLine("list of Products");
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine(Products[i].ToString());
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"WorkersCount: {WorkersCount}";

        }
    }
}
