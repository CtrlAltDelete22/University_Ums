using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_management_system
{
    public partial class menu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeform;
        public menu()
        {
            InitializeComponent();
            random = new Random();
        }
        
        private Color SelectThemeColor() 
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while(tempIndex == index) 
            {
                random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
            
        }
        Forms.Student fs = new Forms.Student();
        
        private void ActiveButton(object btnSender) 
        {
            if(btnSender != null) 
            {
                if(currentButton != (Button)btnSender) 
                {
                    disableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = this.button5.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    paneltitlebar.BackColor = color;
                    
                    lblTitle.Text = button1.Text;
                    panellogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    
                    ThemeColor.primaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;'
                    
                }
            }
        }
        private void disableButton() 
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button)) 
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = this.button5.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeform != null)
                activeform.Close();
            ActiveButton(btnSender);
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Student(),sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Faculty(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Courses(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.department(), sender);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.UserIo(), sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
