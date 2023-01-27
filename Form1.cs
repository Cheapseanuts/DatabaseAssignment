using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBAssignment5.models.datalayer;

namespace DBAssignment5
{
    public partial class Form1 : Form
    {
        private MMABooksContext context = new();
        private Customer c;
        private Invoice i;

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayInvoice()
        {
            //complete form control = customer object
            txtInvoiceID.Text = i.InvoiceId.ToString();
            txtInvoiceDate.Text = i.InvoiceDate.ToString();
            txtName.Text = c.Name;
            txtProductTotal.Text = i.ProductTotal.ToString("c");
            txtShippingTotal.Text = i.Shipping.ToString("c");
            txtSalesTax.Text = i.SalesTax.ToString("c");
            txtInvoiceTotal.Text = i.InvoiceTotal.ToString("c");
        }

        private void Clear()
        {
            txtInvoiceID.Text = "";
            txtInvoiceDate.Text = "";
            txtName.Text = "";
            txtProductTotal.Text = "";
            txtShippingTotal.Text = "";
            txtSalesTax.Text = "";
            txtInvoiceTotal.Text = "";
            dgvInvoices.DataSource = null;
            dgvInvoices.Rows.Clear();
        }

        private bool IsValid()
        {
            int input = -1;
            if (int.TryParse(txtInvoiceID.Text, out input) && input >= 0)
            {
                return true;
            }
            return false;
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    int invID = Convert.ToInt32(txtInvoiceID.Text);
                    i = context.Invoices.Find(invID);
                    if (i != null)
                    {
                        int custID = i.CustomerId;
                        c = context.Customers.Find(custID);
                        if (c != null)
                        {
                            DisplayInvoice();
                            if (!context.Entry(i).Collection("InvoiceLineItems").IsLoaded)
                                context.Entry(i).Collection("InvoiceLineItems").Load();
                            dgvInvoices.DataSource = i.InvoiceLineItems.ToList();
                        }
                        else
                        {
                            MessageBox.Show("The customer associated with this invoice was not found. Please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invoice " + invID.ToString() + " not found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Invoice ID");
            }
            
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
