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
    public partial class fullNameSearch : Form
    {
        public fullNameSearch()
        {
            InitializeComponent();
        }
        public string connectionString = ConfigurationManager.ConnectionStrings["sqlServerConnection"].ConnectionString;

        // Global Varriable 
        public static string rd0, rd1, rd2, rd3, rd4, rd5;

        //Global var for fullName search : 
        public static string searchQueryGlobal =" " ;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        
            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                if (this.txtBoxSearchByFullName.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("you didn't Write Any full name !!");
                }
                else
                {

                   string searchQuery = "SELECT * FROM information_Adherent WHERE fullName LIKE @fullName;";

                    cnx.Open();

                    SqlCommand cmd = new SqlCommand(searchQuery, cnx);
                    
                    cmd.Parameters.AddWithValue("@fullName", this.txtBoxSearchByFullName.Text.Trim());

                   // searchQueryGlobal = this.txtBoxSearchByFullName.Text.Trim();
                    

               //Console.WriteLine("test");

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.HasRows)
                    {
                        rd.Read();
                        DialogResult d = MessageBox.Show("Full Name : " +  rd[0] + "\nAdress :" + rd[1] + "\nBirthDay Date :" + rd[2] +
                                                         "\nJob Title :" + rd[3] + "\nNumber Phone :" + rd[4] + "\nSexe :" + rd[5], "You want Update this Memeber".ToLower(), MessageBoxButtons.YesNo);

                       
                        rd0 = rd[0].ToString();
                        searchQueryGlobal = rd0;
                        Console.WriteLine(searchQueryGlobal+ "from fullName RD");
                        rd1 = rd[1].ToString();
                        rd2 = rd[2].ToString();
                        rd3 = rd[3].ToString();
                        rd4 = rd[4].ToString();
                        rd5 = rd[5].ToString();

                        // Console.Write(rd0);

                        UpdateForm updateForm = new UpdateForm(searchQueryGlobal, rd0, rd1, rd2, rd3, rd4, rd5);

                        if (d == DialogResult.Yes)
                        {
                            updateForm.ShowDialog();
                        }
                        else
                        {
                            this.txtBoxSearchByFullName.Clear();
                            this.txtBoxSearchByFullName.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("the Full Name doesn't match with our data ");
                        this.txtBoxSearchByFullName.Clear();

                    }
                }
            }

        }



        
   

        private void dgvAllInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

      

        
    }
    
}
