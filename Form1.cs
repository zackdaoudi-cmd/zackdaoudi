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
    public partial class Form1 : Form
    {
        public Form1(string username)
        {
            InitializeComponent();
            lblFullName.Text = "Welcome back "+username ;


        }

        public  string connectionString = ConfigurationManager.ConnectionStrings["sqlServerConnection"].ConnectionString;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnShowAll_Click(sender, e);
            this.dgvAllInfo.ReadOnly = true;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(connectionString))
                {
                    string showAllQuery = "SELECT * FROM information_adherent;";
                    SqlCommand cmd = new SqlCommand(showAllQuery,cnx);
                    cnx.Open();
    
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        this.dgvAllInfo.Rows.Clear();
                        while (rd.Read())
                        {
                            this.dgvAllInfo.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);
                        
                        }
                    }
                    else
                    {
                        MessageBox.Show("NO ONE FOUNDED", "WARRANTY");
                    }
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            if (this.txtBoxFullName.Text.Equals(string.Empty) ||
                 this.txtBoxAdress.Text.Equals(string.Empty) ||
                 this.txtBoxJob.Text.Equals(string.Empty) ||
                 this.txtBoxNumberPhone.Text.Equals(string.Empty) ||
                 this.dtmPickerDateOfBirth.Value.Equals(DateTime.Today)
            )
            {
                MessageBox.Show("chy case khawya a sate ");

            }
            else
            {
                using (SqlConnection cnx = new SqlConnection(connectionString))
                {
                    string searchQuery = "SELECT * FROM information_adherent WHERE fullName =@full;";
                    SqlCommand cmd = new SqlCommand(searchQuery, cnx);
                    cmd.Parameters.AddWithValue("@full", this.txtBoxFullName.Text);
                    cnx.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        MessageBox.Show("this fullName Already existe");
                        this.txtBoxFullName.Clear();
                        this.txtBoxAdress.Clear();
                        this.txtBoxJob.Clear();
                        this.txtBoxNumberPhone.Clear();
                        this.rdButtonM.Checked = false;
                        this.rdButtonF.Checked = false;
                        cnx.Close();
                    }
                    else
                    {
                        using (SqlConnection cnx2 = new SqlConnection(connectionString))
                        {
                            // bool check = this.rdButtonM.Checked;
                            string checkType;
                            if (this.rdButtonM.Checked)
                            {
                                checkType = "M";
                            }
                            else
                            {
                                checkType = "F";
                            }

                            string addQuery = "INSERT INTO  information_adherent VALUES ('" + this.txtBoxFullName.Text.Trim() + "','" + this.txtBoxAdress.Text.Trim() + "' ,'" + dtmPickerDateOfBirth.Value.ToShortDateString() + "','" + this.txtBoxJob.Text.Trim() + "','" + this.txtBoxNumberPhone.Text.Trim() + "','" + checkType + "');";
                            SqlCommand cmd2 = new SqlCommand(addQuery, cnx2);

                            ConnectionState state = new ConnectionState();
                            if (state == ConnectionState.Closed || state == ConnectionState.Open)
                            {
                                cnx.Close();
                            }
                            cnx2.Open();

                            int nmbreAdd = cmd2.ExecuteNonQuery();
                            MessageBox.Show(nmbreAdd + " Has Been Added Successfully");
                            btnShowAll_Click(sender, e);

                            this.txtBoxFullName.Clear();
                            this.txtBoxAdress.Clear();
                            this.txtBoxJob.Clear();
                            this.txtBoxNumberPhone.Clear();
                            this.rdButtonM.Checked = false;
                            this.rdButtonF.Checked = false;

                            cnx.Close();
                        }

                    }
                }


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            fullNameSearch fl = new fullNameSearch();
            fl.ShowDialog();

        }

        private void btnDeleteForm_Click(object sender, EventArgs e)
        {
            fullNameSearchForDelete f = new fullNameSearchForDelete();
            f.ShowDialog();

        }
    }
}
