using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFarm_LINQ
{
    public class InvoiceProduct
    {
        public InvoiceProduct()
        {

        }

        public InvoiceProduct(int ProductId, string Name, TypeOfUnits Units, double NumberOfUnits, double UnitPrice, int InvoiceNumber)
        {
            this.ProductId = ProductId;
            this.Name = Name;
            this.Units = Units;
            this.NumberOfUnits = NumberOfUnits;
            this.UnitPrice = UnitPrice;
            this.InvoiceNumber = InvoiceNumber;
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public TypeOfUnits Units { get; set; }
        public double NumberOfUnits { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get
            { return NumberOfUnits * UnitPrice; }
            set {
                TotalPrice = value;
            }
        }
        public int InvoiceNumber { get; set; }
    }
    public enum TypeOfUnits
    {
        kg=0,
        units
    }
}
