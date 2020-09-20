using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
   public class Employee
   {
        public Employee()
        {
            Name = "no name";
            SurName ="no SurName";
            BirthDate = DateTime.Now;
            Salary = 0;

        }
        public Employee(string Name, string SurName, DateTime Date_of_mannufacture, decimal Salary)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.BirthDate = Date_of_mannufacture;
            this.Salary = Salary;
        }

        public string Name { get; set; }
        public string SurName { get; set; }
      
        public  DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"SurName: {SurName}\n" +
                   $"Salary: {Salary}\n" +
                   $"BirthDate: {BirthDate}\n";
        }
    }
}
