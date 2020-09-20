using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    partial class Factory
    {
        public decimal AvgSalary 
        { 
            get
            {
                decimal count = 0;
                for (int i = 0; i < employee.Length; i++)
                {
                    count += employee[i].Salary;
                }
                return count / employee.Length;
            }

        
        }

        public decimal TotalSalery
        {
            get
            {
                decimal count = 0;
                for (int i = 0; i < employee.Length; i++)
                {
                    count += employee[i].Salary;
                }
                return count;

            }


        }

        public decimal GDP
        {
            get
            {
                decimal count1 = 0;
                for (int i = 0; i < Products.Length; i++)
                {
                    count1 += Products[i].Prise;
                }
                return count1/employee.Length;
            }


        }
        public int WorkersCount
        {
            get
            {
                return employee.Length;
            }
        }


    }
}
