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
    public partial class fullNameSearchForDelete : Form
    {
        public fullNameSearchForDelete()
        {
            InitializeComponent();
        }

        public string connectionString = ConfigurationManager.ConnectionStrings["sqlServerConnection"].ConnectionString;

        
        



        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DELETE FROM information_adherent WHERE fullName='ZAKARIA';

            if (this.txtBoxSearchByFullNameForDelete.Text.Equals(string.Empty))
            {
                MessageBox.Show("You didn't write anythink");
            }
            else
            {
                using (SqlConnection cnx = new SqlConnection(connectionString))
                {
                    // string deleteQueryd = "DELETE FROM information_adherent WHERE fullName=" + this.txtBoxSearchByFullNameForDelete.Text+";";
                    string deleteQuery = "DELETE  FROM information_adherent WHERE fullName=@v1;";
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand(deleteQuery, cnx);
                    string test = this.txtBoxSearchByFullNameForDelete.Text;
                    cmd.Parameters.AddWithValue("@v1", test);
                    Console.WriteLine(test + "   from delete test ");
                    DialogResult rd = MessageBox.Show("Are you Sure about deleting this Memeber ?", "Delete Member",
                        MessageBoxButtons.YesNo);
                    if(rd == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        this.Close();


                    }
                    else
                    {
                        this.txtBoxSearchByFullNameForDelete.Clear();

                    }


                    cnx.Close();
                }
            }

        }

        private void fullNameSearchForDelete_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
