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
        public MainMenu()
        {
            InitializeComponent();
            employeesForm = new EmployeesForm();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            changeTab(1);
        }
        /*
        private void btn_sales_Click(object sender, EventArgs e)
        {
            changeTab(2);
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            changeTab(3);
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            changeTab(4);
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            changeTab(5);
        }
        */
        private void btn_employees_Click_1(object sender, EventArgs e)
        {
            changeTab(6);
        }
        /*
        private void btn_sales_Click(object sender, EventArgs e)
        {
            changeTab(7);
        }
        */
        public void changeTab(int i)
        {
            switch (i)
            {
                case 6: 
                    this.Hide();
                    employeesForm.Show();
                    break;
                    //case 3:
            }
        }
    }
}
