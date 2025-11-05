using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using formdemoapp.Models;

namespace formdemoapp
{
    public partial class frmPoduct : Form
    {
        public frmPoduct()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product() { 
                barcode = txtBarcode.Text,
                name = txtName.Text,
                description = txtDescription.Text,
                category = txtCategory.Text,
                origin = optAbroad.Checked ? "Abroad" : "Local",
                isActive = chkIsActive.Checked,
                cost = 100,
               // price = Convert.ToDecimal(txtPrice.Text)
            };

            p.showProduct();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
