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
    public partial class Main : Form
    {
        private static SqlConnection cn;


        public Main()
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
        private static SqlConnection getSGBDConnection()
        {
            String dbServer = "tcp:mednat.ieeta.pt\\SQLSERVER,8101";
            String dbName = "p9g1";
            String userName = "p9g1";
            String userPass = "Pedro97484Trigo98597!";
            return new SqlConnection("Data Source = " + dbServer + " ;" + "Initial Catalog = " + dbName + "; uid = " + userName + ";" + "password = " + userPass);
        }

        private static bool verifySGBDConnection()
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

                if (retval) {
                    MainMenu mainForm = new MainMenu();
                    this.Hide(); // mudar de screen
                    mainForm.Show();
                } else
                {
                    MessageBox.Show("Incorrect Credentials!");
                    clear_form();
                }
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

        public static int get_table_rows(string table)
        {
            int retval=-1;

            if (!verifySGBDConnection())
                return retval;

            SqlCommand cmd1 = new SqlCommand("getnumrows", cn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@table", table);
            cmd1.Parameters.Add("@retval", SqlDbType.Int).Direction = ParameterDirection.Output;

            try
            {
                cmd1.ExecuteNonQuery();
                retval = (int)cmd1.Parameters["@retval"].Value;
                MessageBox.Show(retval.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected Error: " + ex.Message);
            }

            return retval;
        }

        public static void updateList(CheckedListBox list1, string procedureName, int argNum)
        {
            string str="";

            if (!verifySGBDConnection())
                return;

            try
            {
                SqlCommand cmd1 = new SqlCommand(procedureName, cn);
                cmd1.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd1.ExecuteReader();

                while (dr.Read())
                {
                    for (int i = 0; i < argNum; i++)
                    {
                        str = str + dr[i].ToString();
                    }

                    list1.Items.Add(str);
                    str = "";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected Error: " + ex.Message);
            }
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
