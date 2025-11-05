using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formdemoapp.Models
{
    internal class Product
    {
        public string barcode { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string origin { get; set; }
        public bool isActive { get; set; }
        public decimal cost { get; set; }
        public decimal price { get; set; }

        public void showProduct() {

            string status = this.isActive ? "Active" : "Inactive";

            MessageBox.Show( $"Product Name : {this.name} \n" +
                             $"Barcode : {this.barcode} \n" +
                             $"Description : {this.description} \n" +
                             $"Category : {this.category} \n" +
                             $"Origin : {this.origin} \n" +
                             $"Status : {status} \n" +
                             $"Cost : {this.cost} \n"
                             );

        }
    }
}
