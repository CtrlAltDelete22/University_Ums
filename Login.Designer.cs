
namespace University_management_system
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Txtusename = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Txtpassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SignUpBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.LoginBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 62);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Login";
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblClear.Location = new System.Drawing.Point(64, 447);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(68, 34);
            this.lblClear.TabIndex = 1;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.BlueViolet;
            this.checkBox1.Location = new System.Drawing.Point(167, 450);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 27);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Txtusename
            // 
            this.Txtusename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Txtusename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Txtusename.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txtusename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtusename.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txtusename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txtusename.HintForeColor = System.Drawing.Color.Empty;
            this.Txtusename.HintText = "";
            this.Txtusename.isPassword = false;
            this.Txtusename.LineFocusedColor = System.Drawing.Color.Blue;
            this.Txtusename.LineIdleColor = System.Drawing.Color.Gray;
            this.Txtusename.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Txtusename.LineThickness = 3;
            this.Txtusename.Location = new System.Drawing.Point(58, 191);
            this.Txtusename.Margin = new System.Windows.Forms.Padding(4);
            this.Txtusename.MaxLength = 32767;
            this.Txtusename.Name = "Txtusename";
            this.Txtusename.Size = new System.Drawing.Size(258, 33);
            this.Txtusename.TabIndex = 8;
            this.Txtusename.Text = "Username";
            this.Txtusename.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txtpassword
            // 
            this.Txtpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Txtpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Txtpassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtpassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txtpassword.HintForeColor = System.Drawing.Color.Empty;
            this.Txtpassword.HintText = "";
            this.Txtpassword.isPassword = true;
            this.Txtpassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.Txtpassword.LineIdleColor = System.Drawing.Color.Gray;
            this.Txtpassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Txtpassword.LineThickness = 3;
            this.Txtpassword.Location = new System.Drawing.Point(58, 252);
            this.Txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.Txtpassword.MaxLength = 32767;
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.Size = new System.Drawing.Size(258, 33);
            this.Txtpassword.TabIndex = 9;
            this.Txtpassword.Text = "Password";
            this.Txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignUpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUpBtn.BackgroundImage")));
            this.SignUpBtn.ButtonText = "Sign Up";
            this.SignUpBtn.ButtonTextMarginLeft = 0;
            this.SignUpBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.SignUpBtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.SignUpBtn.DisabledForecolor = System.Drawing.Color.White;
            this.SignUpBtn.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.Black;
            this.SignUpBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SignUpBtn.IconPadding = 10;
            this.SignUpBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SignUpBtn.IdleBorderColor = System.Drawing.Color.Black;
            this.SignUpBtn.IdleBorderRadius = 30;
            this.SignUpBtn.IdleBorderThickness = 2;
            this.SignUpBtn.IdleFillColor = System.Drawing.Color.GhostWhite;
            this.SignUpBtn.IdleIconLeftImage = null;
            this.SignUpBtn.IdleIconRightImage = null;
            this.SignUpBtn.Location = new System.Drawing.Point(58, 378);
            this.SignUpBtn.Name = "SignUpBtn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.SignUpBtn.onHoverState = stateProperties1;
            this.SignUpBtn.Size = new System.Drawing.Size(258, 45);
            this.SignUpBtn.TabIndex = 11;
            this.SignUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.BackgroundImage")));
            this.LoginBtn.ButtonText = "Login";
            this.LoginBtn.ButtonTextMarginLeft = 0;
            this.LoginBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.LoginBtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.LoginBtn.DisabledForecolor = System.Drawing.Color.White;
            this.LoginBtn.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LoginBtn.IconPadding = 10;
            this.LoginBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LoginBtn.IdleBorderColor = System.Drawing.Color.Black;
            this.LoginBtn.IdleBorderRadius = 30;
            this.LoginBtn.IdleBorderThickness = 2;
            this.LoginBtn.IdleFillColor = System.Drawing.Color.BlueViolet;
            this.LoginBtn.IdleIconLeftImage = null;
            this.LoginBtn.IdleIconRightImage = null;
            this.LoginBtn.Location = new System.Drawing.Point(58, 318);
            this.LoginBtn.Name = "LoginBtn";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.LoginBtn.onHoverState = stateProperties2;
            this.LoginBtn.Size = new System.Drawing.Size(258, 45);
            this.LoginBtn.TabIndex = 10;
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::University_management_system.Properties.Resources.icons8_customer_96px;
            this.pictureBox2.Location = new System.Drawing.Point(130, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::University_management_system.Properties.Resources._4707071;
            this.pictureBox1.Location = new System.Drawing.Point(374, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 494);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(773, 493);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.Txtusename);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.CheckBox checkBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txtusename;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txtpassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LoginBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SignUpBtn;
    }
}