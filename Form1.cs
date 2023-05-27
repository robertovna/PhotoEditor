using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor
{
    public partial class Form1 : Form
    {

        private OrderModel _model = new OrderModel();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var customers = _model.GetCustomers();

            ClientComboBox.Items.AddRange(customers.Select(x => x.Name).ToArray());
            ClientComboBox.Items.Add("All");

            var orders = _model.GetOrdersByCustomer();
            OrderListDataGrid.DataSource = orders; 
        }

        private void GrayBtn_Click(object sender, EventArgs e)
        {
            Gray newForm = new Gray();
            newForm.Show();
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            ColorForm newForm = new ColorForm();
            newForm.Show();
        }

        private void BlackWhiteBtn_Click(object sender, EventArgs e)
        {
            BlackWhite newForm = new BlackWhite();
            newForm.Show();
        }

        private void ClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customerName = ClientComboBox.SelectedItem.ToString();
            if (customerName == "All")
            {
                customerName = "";
            }
            var orders = _model.GetOrdersByCustomer(customerName);
            OrderListDataGrid.DataSource = orders;
        }
    }
}
