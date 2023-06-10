
namespace University_management_system
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtpassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Txtusename = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblClear = new System.Windows.Forms.Label();
            this.SignUpBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtConfirmPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 81);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::University_management_system.Properties.Resources.download;
            this.pictureBox3.Location = new System.Drawing.Point(12, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(149, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "User SignUp";
            // 
            // Txtpassword
            // 
            this.Txtpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Txtpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Txtpassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtpassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txtpassword.ForeColor = System.Drawing.Color.White;
            this.Txtpassword.HintForeColor = System.Drawing.Color.Empty;
            this.Txtpassword.HintText = "";
            this.Txtpassword.isPassword = true;
            this.Txtpassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.Txtpassword.LineIdleColor = System.Drawing.Color.Gray;
            this.Txtpassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Txtpassword.LineThickness = 3;
            this.Txtpassword.Location = new System.Drawing.Point(85, 277);
            this.Txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.Txtpassword.MaxLength = 32767;
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.Size = new System.Drawing.Size(258, 33);
            this.Txtpassword.TabIndex = 20;
            this.Txtpassword.Text = "Password";
            this.Txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txtpassword.OnValueChanged += new System.EventHandler(this.Txtpassword_OnValueChanged);
            // 
            // Txtusename
            // 
            this.Txtusename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Txtusename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Txtusename.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txtusename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtusename.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txtusename.ForeColor = System.Drawing.Color.White;
            this.Txtusename.HintForeColor = System.Drawing.Color.Empty;
            this.Txtusename.HintText = "";
            this.Txtusename.isPassword = false;
            this.Txtusename.LineFocusedColor = System.Drawing.Color.Blue;
            this.Txtusename.LineIdleColor = System.Drawing.Color.Gray;
            this.Txtusename.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Txtusename.LineThickness = 3;
            this.Txtusename.Location = new System.Drawing.Point(85, 220);
            this.Txtusename.Margin = new System.Windows.Forms.Padding(4);
            this.Txtusename.MaxLength = 32767;
            this.Txtusename.Name = "Txtusename";
            this.Txtusename.Size = new System.Drawing.Size(258, 33);
            this.Txtusename.TabIndex = 19;
            this.Txtusename.Text = "Username";
            this.Txtusename.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txtusename.OnValueChanged += new System.EventHandler(this.Txtusename_OnValueChanged);
            this.Txtusename.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txtusename_MouseClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.checkBox1.Location = new System.Drawing.Point(194, 446);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 27);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblClear.Location = new System.Drawing.Point(91, 439);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(68, 34);
            this.lblClear.TabIndex = 16;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignUpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUpBtn.BackgroundImage")));
            this.SignUpBtn.ButtonText = "Sign Up";
            this.SignUpBtn.ButtonTextMarginLeft = 0;
            this.SignUpBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.SignUpBtn.DisabledFillColor = System.Drawing.Color.White;
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
            this.SignUpBtn.Location = new System.Drawing.Point(85, 391);
            this.SignUpBtn.Name = "SignUpBtn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.SignUpBtn.onHoverState = stateProperties1;
            this.SignUpBtn.Size = new System.Drawing.Size(258, 45);
            this.SignUpBtn.TabIndex = 22;
            this.SignUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::University_management_system.Properties.Resources.icons8_customer_96px;
            this.pictureBox2.Location = new System.Drawing.Point(160, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::University_management_system.Properties.Resources._4707071;
            this.pictureBox1.Location = new System.Drawing.Point(421, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 494);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtConfirmPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtConfirmPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.TxtConfirmPassword.HintForeColor = System.Drawing.Color.Empty;
            this.TxtConfirmPassword.HintText = "";
            this.TxtConfirmPassword.isPassword = true;
            this.TxtConfirmPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtConfirmPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtConfirmPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtConfirmPassword.LineThickness = 3;
            this.TxtConfirmPassword.Location = new System.Drawing.Point(85, 339);
            this.TxtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtConfirmPassword.MaxLength = 32767;
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(258, 33);
            this.TxtConfirmPassword.TabIndex = 23;
            this.TxtConfirmPassword.Text = "Password";
            this.TxtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(788, 485);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.Txtusename);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SignUpBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txtpassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txtusename;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtConfirmPassword;
    }
}