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
    public partial class SignUp : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        
        public SignUp()
        {
            InitializeComponent();
        }
        private void SignUp_Load(object sender, EventArgs e)
        {
           
            
        }

        private void Txtpassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Txtpassword.isPassword = false;
                TxtConfirmPassword.isPassword = false;
            }

            else
            {
                Txtpassword.isPassword = true;
                TxtConfirmPassword.isPassword = true;
            }

        }

        private void Txtusename_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Txtusename_OnValueChanged(object sender, EventArgs e)
        {


        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            Txtusename.Text = "";
            Txtpassword.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            ln.Show();
            this.Hide();
        }

        ////private void existence() 
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L47OFOR;Initial Catalog=login;Integrated Security=True");
        //    con.Open();
        //    SqlDataAdapter sda = new SqlDataAdapter();
        //    SqlCommand cmd = new SqlCommand();

        //    if(reader.Read() == true) 
        //    {
        //        MessageBox.Show("username exist");

        //    }

        //    con.Close();
        //}

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L47OFOR;Initial Catalog=login;Integrated Security=True");
            if (Txtusename.Text == "" && Txtpassword.Text == "" && TxtConfirmPassword.Text == "") 
            {
                MessageBox.Show("please fill the form");
            }
            else if(Txtpassword.Text == TxtConfirmPassword.Text) 
            {

            
                    con.Open();

                    string query = "INSERT INTO signUp VALUES('" + Txtusename.Text + "','" + Txtpassword.Text + "')";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("your account successfully created");
                
                
            }
            else 
            
            {
                MessageBox.Show("password not match");
                Txtpassword.Text = "";
                TxtConfirmPassword.Text = "";
                Txtpassword.Focus();
            }
          
        }
    }
}

