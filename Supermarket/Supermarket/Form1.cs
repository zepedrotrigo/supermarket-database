using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Supermarket
{
    public partial class Form1 : Form
    {
        private SqlConnection cn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();
            if (verifySGBDConnection())
            {
                Console.WriteLine("Connection");
            }
            else
            {
                DialogResult result;
                result = MessageBox.Show("Can't connect to database", "Error!", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    System.Environment.Exit(1);
                }

            }

            cn.Close();
        }
        private SqlConnection getSGBDConnection()
        {
            String dbServer = "tcp:mednat.ieeta.pt\\SQLSERVER,8101";
            String dbName = "p9g1";
            String userName = "p9g1";
            String userPass = "Pedro97484Trigo98597!";
            return new SqlConnection("Data Source = " + dbServer + " ;" + "Initial Catalog = " + dbName + "; uid = " + userName + ";" + "password = " + userPass);
        }

        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void form_login_Click(object sender, EventArgs e)
        {

        }
    }
}
