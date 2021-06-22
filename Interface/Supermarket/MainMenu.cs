using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class MainMenu : Form
    {
        EmployeesForm employeesForm;
        ClientsForm clientsForm;
        public MainMenu()
        {
            InitializeComponent();
            employeesForm = new EmployeesForm();
            clientsForm = new ClientsForm();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            changeTab(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeTab(5);
        }

        private void btn_employees_Click_1(object sender, EventArgs e)
        {
            changeTab(6);
        }
        public void changeTab(int i)
        {
            this.Hide();

            switch (i)
            {
                case 5:
                    clientsForm.Show();
                    break;
                case 6: 
                    employeesForm.Show();
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            textBox2.Text = "1";
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Product Bar Code";
            dataGridView1.Columns[1].Name = "Product Name";
            dataGridView1.Columns[2].Name = "Product Brand";
            dataGridView1.Columns[3].Name = "Product Price";
            dataGridView1.Columns[4].Name = "Amount";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(textBox2.Text);
            value++;
            textBox2.Text = value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(textBox2.Text);

            if (value > 1)
                value--;

            textBox2.Text = value.ToString();
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            int barcode = Int32.Parse(textBox1.Text);
            int amount = Int32.Parse(textBox2.Text);
            bool retval = true;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (barcode.ToString() == row.Cells[0].Value.ToString())
                {
                    row.Cells[4].Value = Int32.Parse(row.Cells[4].Value.ToString()) + amount;
                    retval = false;
                }
            }

            if (retval)
            {
                Main.addProductToShoppingList(dataGridView1, barcode, amount);
            }
        }
    }
}
