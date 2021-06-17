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
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            Main.populateList(dataGridView1, "getEmployees");
        }

        private void button1_Click(object sender, EventArgs e)
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@name", txt_name.Text },
                { "@nif", txt_nif.Text },
                { "@employeeID", txt_id.Text },
                { "@phone", txt_phone.Text },
                { "@email", txt_email.Text },
                { "@jobTitle", txt_job.Text },
                { "@salary", txt_salary.Text },
                { "@employeeSince", txt_employee_since.Text },
            };

            List<string> parametersKeys = new List<string>(parameters.Keys);
            foreach (var key in parametersKeys) // replace empty inputs with null (required for the db stored procedure)
            {
                if (parameters[key] == "")
                    parameters[key] = null;
            }

            Main.PopulateTableWithParameters(dataGridView1, "dbo.filterEmployees", parameters);
        }
        //int employeeID = Main.get_table_rows("supermarket.employee");
    }
}
