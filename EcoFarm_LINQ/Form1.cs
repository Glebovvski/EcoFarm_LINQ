using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoFarm_LINQ
{
    public partial class Form1 : Form
    {
        int[] array1 = new int[] { 1, 2032, 2, 342, 34, 12, 65, 322, 34, 5, 343, 5657, 6765, 33, 66, 53268 };
        
        List<InvoiceProduct> products = new List<InvoiceProduct>()
        {
            new InvoiceProduct(1, "Cocumbers", TypeOfUnits.kg, 130, 10, 1),
            new InvoiceProduct(2, "Tomatoes", TypeOfUnits.kg, 100, 11, 1),
            new InvoiceProduct(3, "Apples", TypeOfUnits.kg, 150, 7, 1),
            new InvoiceProduct(4, "Cabbage", TypeOfUnits.kg, 80, 14, 2),
            new InvoiceProduct(5, "Lettuce", TypeOfUnits.kg, 30, 1000, 2),
            new InvoiceProduct(6, "Peaches", TypeOfUnits.kg, 110, 15, 2),
            new InvoiceProduct(7, "Broccoli", TypeOfUnits.kg, 100, 13, 3),
            new InvoiceProduct(8, "Carrot", TypeOfUnits.kg, 180, 13, 3),
            new InvoiceProduct(9, "Potato", TypeOfUnits.kg, 200, 6, 3),
            new InvoiceProduct(10, "Onion", TypeOfUnits.kg, 95, 12, 4),
            new InvoiceProduct(11, "Watermelon", TypeOfUnits.units, 230, 25, 4),
            new InvoiceProduct(12, "Pumpkins", TypeOfUnits.units, 200, 24, 4),
            new InvoiceProduct(13, "Cocumbers", TypeOfUnits.kg, 140, 9, 1),
            new InvoiceProduct(14, "Tomatoes", TypeOfUnits.kg, 170, 10, 5),
            new InvoiceProduct(15, "Apples", TypeOfUnits.kg, 90, 6, 5),
            new InvoiceProduct(17, "Jam", TypeOfUnits.units, 140, 20, 6)
        };

        public Form1()
        {
            InitializeComponent();
            ProductsCB.DataSource = products.Select(x => x.Name).Distinct().ToList();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ecoFarm_DBDataSet.Invoice.Where(x => x.Date >= dateTimePicker1.Value
                                                        && x.Date <= dateTimePicker2.Value)
                                                        .OrderBy(x => x.Date)
                                                        .Select(p => new
                                                        {
                                                            p.Date,
                                                            p.Invoice_number,
                                                            p.Invoice_type,
                                                            p.Reciever,
                                                            p.Supplier,
                                                            p.Supplier_code
                                                        })
                                                        .ToList();
        }

        private void invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ecoFarm_DBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ecoFarm_DBDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.ecoFarm_DBDataSet.Invoice);
            SupplierCB.DataSource = ecoFarm_DBDataSet.Invoice.Select(x => x.Supplier).Distinct().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from invoice in ecoFarm_DBDataSet.Invoice
                                       join product in products on invoice.Invoice_number equals product.ProductId
                                       where invoice.Supplier == SupplierCB.SelectedItem.ToString()
                                       select new
                                       {
                                           product.InvoiceNumber,
                                           product.ProductId,
                                           product.Name,
                                           product.Units,
                                           product.NumberOfUnits,
                                           product.UnitPrice,
                                           product.TotalPrice,
                                           invoice.Supplier,
                                           invoice.Date
                                       }).ToList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double min = products.Where(x => x.Name == ProductsCB.SelectedItem.ToString()).OrderBy(x => x.UnitPrice).Select(x => x.UnitPrice).First();
            double max = products.Where(x => x.Name == ProductsCB.SelectedItem.ToString()).OrderByDescending(x => x.UnitPrice).Select(x => x.UnitPrice).First();
            double average = products.Where(x => x.Name == ProductsCB.SelectedItem.ToString()).Select(x=>x.UnitPrice).Average();

            MinTB.Text = min.ToString();
            MaxTB.Text = max.ToString();
            AverageTB.Text = average.ToString();

            MinPriceSupplier.Text = "by " + (from invoice in ecoFarm_DBDataSet.Invoice
                                             join product in products
                                             on invoice.Invoice_number equals product.InvoiceNumber
                                             where product.UnitPrice == min &&
                                             product.Name == ProductsCB.SelectedItem.ToString()
                                             select invoice.Supplier).First().ToString();

            MaxPriceSupplier.Text= "by " + (from invoice in ecoFarm_DBDataSet.Invoice
                                            join product in products
                                            on invoice.Invoice_number equals product.InvoiceNumber
                                            where product.UnitPrice == max &&
                                            product.Name == ProductsCB.SelectedItem.ToString()
                                            select invoice.Supplier).First().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] array2 = products.Where(x => x.Units == TypeOfUnits.kg).Select(x => x.Name).ToArray();
            MessageBox.Show(array2.Distinct().OrderBy(x=>x).Aggregate((current, next) => current + ", " + next), "All available products");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime[] array = ecoFarm_DBDataSet.Invoice.Select(x => x.Date).Distinct().ToArray();
            var res= (from a in array where a.DayOfWeek == DayOfWeek.Saturday || a.DayOfWeek == DayOfWeek.Sunday select new { a.Date, a.DayOfWeek}).ToList();

            string s = string.Join("\n", res.Select(x => x.Date.ToShortDateString()));
            MessageBox.Show("Products can't be delivered on this dates: \n"+s, "Holidays");
        }
    }
}
