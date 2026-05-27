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
        /* difference between load testing and stress testing in non-functional test design.
         * load testing is a type of performance testing that evaluates how a system performs under expected or normal load conditions. It simulates real-world usage to determine if the system can handle the anticipated number of users, transactions, or data volume without significant performance degradation. The primary goal of load testing is to identify bottlenecks and ensure that the system can meet performance requirements under typical usage scenarios. while stress testing is a type of performance testing that evaluates how a system performs under extreme or beyond-normal load conditions. It intentionally pushes the system to its limits to identify its breaking point and how it handles high levels of stress. The primary goal of stress testing is to determine the system's robustness, stability, and ability to recover from failure when subjected to excessive load or resource constraints. In summary, load testing focuses on normal usage scenarios, while stress testing focuses on extreme conditions to assess system resilience.*/

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
