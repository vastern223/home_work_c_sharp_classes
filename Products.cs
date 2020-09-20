using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public struct Products
    {

        public string Name { get; set; }

        public decimal Prise { get; set; }

        public readonly DateTime Date_of_mannufacture;

        public CategoryType Category { get; set; }

        public Products(string Name, decimal Prise, DateTime Date_of_mannufacture , CategoryType Category)
        {
            this.Name = Name;
            this.Prise = Prise;
            this.Date_of_mannufacture = Date_of_mannufacture;
            this.Category = Category;
        }

        public enum CategoryType
        {
            MealkProductType = 1, MeatProductType  = 2 , NonProductType = 3
        }
      

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Prise: {Prise}\n" +
                   $"Date_of_mannufacture: {Date_of_mannufacture} \n"+
                   $"Category Type: {Category} \n";
        }

    }
    
}
