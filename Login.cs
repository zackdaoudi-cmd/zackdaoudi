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
using System.Configuration;

namespace CRUD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string connectionString =      ConfigurationManager.ConnectionStrings["sqlServerConnection"].ConnectionString;

        public string usernameGlob;
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            using(SqlConnection cnx = new SqlConnection(connectionString))
            {
                string loginQuery = "SELECT * FROM login_Adherent WHERE Username='" + this.txtBoxUserName.Text + "' and Password='" + this.txtBoxPassword.Text + "';";

                SqlDataAdapter cmd = new SqlDataAdapter(loginQuery, cnx);
           
                DataTable dataTable = new DataTable();
                Console.WriteLine("username : " + this.txtBoxUserName.Text + "\nPassword : " + this.txtBoxPassword.Text);

                usernameGlob = this.txtBoxUserName.Text;

                if (this.txtBoxUserName.Text.Equals(string.Empty) && this.txtBoxPassword.Text.Equals(string.Empty))
                {
                    MessageBox.Show("username or password case are empty");
                }
                else
                {
                    cmd.Fill(dataTable);
                 
                    if (dataTable.Rows.Count.ToString() == "1" ) 
                    {
                        this.Hide();
                        Form1 f = new Form1(usernameGlob);
                        f.ShowDialog();
                    }
                    else
                    {
                        this.labelInvalid.Text = "invalid Data ";
                        this.txtBoxUserName.Clear();
                        this.txtBoxPassword.Clear();
                        //  MessageBox.Show("userName or password are wrong");

                    }
                }
            }
            
        }
        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.txtBoxPassword.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                this.txtBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtBoxPassword.UseSystemPasswordChar = true;

            }
        }
    }
}
