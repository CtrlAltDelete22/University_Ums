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
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L47OFOR;Initial Catalog=login;Integrated Security=True"); 
        private void populate() 
        {
            con.Open();
            string query = "select * from UserInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder bu = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
            {
             if (UidTb.Text == "" || UnameTb.Text == "" || UpassTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserInfo values(" + UidTb.Text + ",'" + UnameTb.Text + "','" + UpassTb.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Succesfully Added");
                    con.Close();
                    populate();   
                }
            }
            
              
            
           
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UidTb.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            UnameTb.Text =  UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            UpassTb.Text =  UserDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if(UidTb.Text == "")
            {
                MessageBox.Show("please enter the userID");
            }
            else
            {
                con.Open();
                string query = "delete from UserInfo where Userid="+ UidTb.Text +";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("user Deleted Succesfully");
                con.Close();
                populate();
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (UidTb.Text == "" || UnameTb.Text == "" || UpassTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else 
            {
                con.Open();
                string query = "update UserInfo set UserName='"+ UnameTb.Text +"',UserPassword='"+ UpassTb.Text +"'where Userid="+ UidTb.Text +"";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User updated Successfully");
                con.Close();
                populate();
            }
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
