using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{

   
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            factory.Menu_for_creating_factory();
            factory.Show_info_of_employee();
            factory.Show_info_of_products();

            Console.WriteLine(" AvgSalary: "+ factory.AvgSalary );
            Console.WriteLine(" TotalSalery: " + factory.TotalSalery);
            Console.WriteLine(" factory.GDP:" + factory.GDP); 
            Console.WriteLine(" WorkersCount:" + factory.WorkersCount);
        }
    }
}
