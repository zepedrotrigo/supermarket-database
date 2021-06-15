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
    public partial class EmployeesForm : Form
    {
        String stdDetails = "{0, -30}{1,-20}{2,-10}{3,-20}{4,-20}{5,-20}{6,-10}{7,-16}";
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(String.Format(stdDetails, "Name", "NIF", "ID", "Phone", "Email", "Job", "Salary", "employeeSince"));
            Main.updateList(checkedListBox1,"getEmployees", 8);
            combo_sort_by.Items.Add("");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_nif.Clear();
            txt_id.Clear();
            txt_phone.Clear();
            txt_email.Clear();
            txt_address.Clear();
            txt_job.Clear();
            txt_salary.Clear();
            txt_employee_since.Clear();
            combo_sort_by.Text = "Select Type";
        }

        //int employeeID = Main.get_table_rows("supermarket.employee");
    }
}
