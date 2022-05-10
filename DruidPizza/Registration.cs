using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DruidPizza
{
    public partial class frmRegistration : Form
    {
        //public string conString = "Data Source=DESKTOP-4R27UTQ;Initial Catalog=DruidClub;Integrated Security=True";

        public frmRegistration()
        {
            InitializeComponent();

            //SqlConnection con = new SqlConnection(conString);
            ////con.Open();
            //if (con.State == System.Data.ConnectionState.Open)
            //{
            //    string q = "insert into Orders(Price,CreatedDate,ModifiedDate,DailyBonus,Users)values('" + txtUsername.ToString() + "','" + txtPassword.Text.ToString() + "','" + txtConPassword.Text.ToString() + "')";
            //    SqlCommand cmd = new SqlCommand(q, con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Connection made Successfuly..!");

            //}
        }
        //OleDbConnection con = new OleDbConnection("ProviderMicrosoft.Jet.OLEDB.4.0;Data Source=dbo_RegistrationUsers.mdb");
        //OleDbCommand cmd = new OleDbCommand();
        //OleDbDataAdapter da = new OleDbDataAdapter();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
        public string conString = "Data Source=DESKTOP-4R27UTQ;Initial Catalog=DruidClub;Integrated Security=True";

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConPassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty","Registration Faild",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(txtPassword.Text == txtConPassword.Text)
            {
                var validpass = new Regex(@"^.*(?=.{6,})(?=.*\d)(?=.*[az])(?=.*[AZ])(?=.*[@#$%^ &+=]).*$");
                if (!validpass.IsMatch(txtPassword.Text))
                {
                    MessageBox.Show("Invalid Password");
                }
                else {
                    
                    string register = "INSERT INTO dbo.Registration_Users VALUES('" + txtUsername.ToString() + "','" + txtPassword.Text.ToString() + "','"+txtConPassword.Text.ToString()+"')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(register, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConPassword.Text = "";

                    MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConPassword.Text = "";
                txtPassword.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConPassword.Text = "";
            txtUsername.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
