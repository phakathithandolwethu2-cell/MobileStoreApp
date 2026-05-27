using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MobileStockCapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOutput_TextChanged(object sender, EventArgs e)
        {
            
            lblOutput.ReadOnly = true;
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
     
        {
           

            string mobileCode = txtCode.Text;
            string make = txtMake.Text;
            int quantity;
            if (int.TryParse(txtQuantity.Text, out quantity) && !string.IsNullOrEmpty(make))
            {
                
                lblOutput.Text = "Record Added";
            }
            else
            {
                lblOutput.Text = "Please enter a valid quantity.";
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
            //
            string mobileCode = txtCode.Text;
            string make = txtMake.Text;
            if (!string.IsNullOrEmpty(mobileCode))
            {
                lblOutput.Text = "Record Deleted";
            }
            else
            {
                lblOutput.Text = "Record NOT Found";
            }

        }
        
        private void btnFind_Click(object sender, EventArgs e)
        {

            string mobileCode = txtCode.Text;
            string make = txtMake.Text;
            if (!string.IsNullOrEmpty(mobileCode))
            {
                lblOutput.Text = "Record Found";
            }
            else
            {
                lblOutput.Text = "Record NOT Found";
            }
            

        }
    }
}
