using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class UpdateForm : Form
    {
        public static string glob ;
        public string Rd0,Rd1, Rd2, Rd3, Rd4, Rd5;

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        public UpdateForm(string searchQueryGlobal , string rd0, string rd1, string rd2, string rd3, string rd4,string rd5)
        {
            InitializeComponent();
            Rd0 = rd0;
            Rd1 = rd1;
            Rd2 = rd2;
            Rd3 = rd3;
            Rd4 = rd4;
            Rd5 = rd5;
            // glob = searchQueryGlobal;
            Console.WriteLine(searchQueryGlobal  + "  from UPDATE");

            glob = searchQueryGlobal;
            Console.WriteLine(glob + "  from UPDATE glob var");


            this.txtBoxFullNameUpdate.Text = rd0;
            this.txtBoxAdressUpdate.Text = rd1;
            this.dtmPickerDateOfBirthUpdate.Value = DateTime.Parse(rd2);
            this.txtBoxJobUpdate.Text = rd3;
            this.txtBoxNumberPhoneUpdate.Text = rd4;
            if(rd5.Equals("M"))
            {
                this.rdButtonMUpdate.Checked = true;
            }
            else
            {
                this.rdButtonFUpdate.Checked = true;

            }

        }

        private string connectionString = ConfigurationManager.ConnectionStrings["sqlServerConnection"].ConnectionString;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //UPDATE FROM information_Adherent SET fullName= ,adress= ,birthDayDate=  ,jobTitle= , phoneNumber=  ,sexe = WHERE fullName=  
            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                string checkType;
                if (this.rdButtonMUpdate.Checked)
                {
                    checkType = "M";
                }
                else
                {
                    checkType = "F";
                }

                //string updateQueryTest = "UPDATE information_Adherent SET fullName="+ this.txtBoxFullNameUpdate.Text +
                //                         " ,adress="+ this.txtBoxAdressUpdate.Text + " ,birthDayDate="+ this.dtmPickerDateOfBirthUpdate.Value +
                //                         "  ,jobTitle="+ this.txtBoxJobUpdate.Text + " , phoneNumber="+ this.txtBoxNumberPhoneUpdate.Text+
                //                         ",sexe ="+ checkType + " WHERE fullName= "+ fullNameSearch.searchQueryGlobal + " ;";
                string updateQuery = 
                    "UPDATE information_Adherent SET fullName= @v1 ,adress=@v7 ,birthDayDate=@v2  ,jobTitle=@v3 , phoneNumber=@v4  ,sexe =@v5 WHERE fullName=@glob ;";

                if (cnx != null && cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cnx.Open();
                SqlCommand cmd =  new SqlCommand(updateQuery, cnx);
                cmd.Parameters.AddWithValue("@v1", this.txtBoxFullNameUpdate.Text);
                cmd.Parameters.AddWithValue("@v7", this.txtBoxAdressUpdate.Text);
                cmd.Parameters.AddWithValue("@v2", this.dtmPickerDateOfBirthUpdate.Value);
                cmd.Parameters.AddWithValue("@v3", this.txtBoxJobUpdate.Text);
                cmd.Parameters.AddWithValue("@v4", this.txtBoxNumberPhoneUpdate.Text);
                cmd.Parameters.AddWithValue("@v5", checkType);
                cmd.Parameters.AddWithValue("@glob", glob);
                //Console.WriteLine(fl.searchQueryGlobal + "   from UPDATE");
                cmd.ExecuteNonQuery();


                MessageBox.Show("member has update ");

                cnx.Close();


            }


        }

       
    }
}
