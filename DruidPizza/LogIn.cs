using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DruidPizza
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //OleDbConnection con = new OleDbConnection("ProviderMicrosoft.Jet.OLEDB.4.0;Data Source=dbo_RegistrationUsers.mdb");
        //OleDbCommand cmd = new OleDbCommand();
        //OleDbDataAdapter da = new OleDbDataAdapter();

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        public string conString = "Data Source=DESKTOP-4R27UTQ;Initial Catalog=DruidClub;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            //con.Open();
            //string login = "SELECT * FROM dbo_RegistrationUsers WHERE username= '" + txtUsername.Text + "' and password= '" + txtpassword.Text + "'";
            //cmd = new OleDbCommand(login, con);
            //OleDbDataReader dr = cmd.ExecuteReader();

            //if(dr.Read() == true)
            //{
            //    new dashboard().Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtUsername.Text = "";
            //    txtpassword.Text = "";
            //    txtUsername.Focus();

            //}

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                
                string q = "SELECT * FROM dbo.Registration_Users WHERE Username = '" + txtusername.Text+"' and Password = '"+txtpassword.Text+"'";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@username", txtusername.Text.ToString());
                cmd.Parameters.AddWithValue("@password", txtpassword.Text.ToString());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //if (reader["Password"].ToString().Equals(txtpassword.Text.ToString(), StringComparison.InvariantCulture))
                    //{

                    //}

                    new dashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    txtusername.Focus();
                }
                MessageBox.Show("Connection made Successfuly..!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtusername.Focus();

        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtpassword.PasswordChar = '\0';
                
            }
            else
            {
                txtpassword.PasswordChar = '*';
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new frmRegistration().Show();
            this.Hide();
        }
    }
}
