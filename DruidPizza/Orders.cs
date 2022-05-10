using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DruidPizza
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        public string conString = "Data Source=DESKTOP-4R27UTQ;Initial Catalog=DruidClub;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if(con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Orders(Price,CreatedDate,ModifiedDate,DailyBonus,Users)values('" + txtPrice.Text.ToString() + "','" + txtCreatedDate.Text.ToString() + "','" + txtModifiedDate.Text.ToString() + "','" + txtDailyBonus.Text.ToString() + "','" + txtUsers.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection made Successfuly..!");
            
            }

        }
    }
}
