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

namespace University_management_system
{
    public partial class Login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Txtusename.Text = "";
            Txtpassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-L47OFOR;Initial Catalog=login;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter();
            con.Open();
            string query = "SELECT * FROM signUp WHERE username='" + Txtusename.Text + "' and password='" + Txtpassword.Text + "'";
            cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read() == true) 
            {
                menu MN = new menu();
                MN.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("invalid username or password");
            }
            

        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)

                Txtpassword.isPassword = false;
            else
                Txtpassword.isPassword = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
    }
}
