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
            checkedListBox1.Items.Add(String.Format(stdDetails, "Name", "NIF", "employeeID", "Phone", "Email", "Job", "Salary", "employeeSince"));
            Main.updateList(checkedListBox1,"getEmployees", 8);
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

        //int employeeID = Main.get_table_rows("supermarket.employee");
    }
}
