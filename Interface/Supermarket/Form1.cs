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
using System.Security.Cryptography;

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

            if (!verifySGBDConnection())
                return;

            var hashed_pw = SHA512(form_password.Text);

            SqlCommand cmd1 = new SqlCommand("login", cn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@username", form_user.Text.Trim());
            cmd1.Parameters.AddWithValue("@pass", hashed_pw);
            cmd1.Parameters.Add("@retval", SqlDbType.Bit).Direction = ParameterDirection.Output;

            try
            {
                cmd1.ExecuteNonQuery();
                bool retval = (bool)cmd1.Parameters["@retval"].Value;
                MessageBox.Show(retval.ToString());
                clear_form();

            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected Error: " + ex.Message);
            }
        }

        private void clear_form()
        {
            form_user.Text = form_password.Text = "";
        }

        private static string SHA512(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }
    }
}
