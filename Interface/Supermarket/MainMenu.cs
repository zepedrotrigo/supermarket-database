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

        }
    }
}
