
namespace University_management_system
{
    partial class UserInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfo));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.UidTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.UpassTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataSet11 = new University_management_system.DataSet1();
            this.UserDGV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AddButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Id:";
            // 
            // UidTb
            // 
            this.UidTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UidTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UidTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UidTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UidTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UidTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UidTb.HintForeColor = System.Drawing.Color.Empty;
            this.UidTb.HintText = "";
            this.UidTb.isPassword = false;
            this.UidTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.UidTb.LineIdleColor = System.Drawing.Color.Gray;
            this.UidTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UidTb.LineThickness = 3;
            this.UidTb.Location = new System.Drawing.Point(150, 77);
            this.UidTb.Margin = new System.Windows.Forms.Padding(4);
            this.UidTb.MaxLength = 32767;
            this.UidTb.Name = "UidTb";
            this.UidTb.Size = new System.Drawing.Size(230, 33);
            this.UidTb.TabIndex = 1;
            this.UidTb.Text = "ID";
            this.UidTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name:";
            // 
            // UnameTb
            // 
            this.UnameTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UnameTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UnameTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UnameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UnameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UnameTb.HintForeColor = System.Drawing.Color.Empty;
            this.UnameTb.HintText = "";
            this.UnameTb.isPassword = false;
            this.UnameTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.UnameTb.LineIdleColor = System.Drawing.Color.Gray;
            this.UnameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UnameTb.LineThickness = 3;
            this.UnameTb.Location = new System.Drawing.Point(150, 128);
            this.UnameTb.Margin = new System.Windows.Forms.Padding(4);
            this.UnameTb.MaxLength = 32767;
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.Size = new System.Drawing.Size(230, 33);
            this.UnameTb.TabIndex = 3;
            this.UnameTb.Text = "User Name";
            this.UnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Password:";
            // 
            // UpassTb
            // 
            this.UpassTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UpassTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UpassTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UpassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UpassTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UpassTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpassTb.HintForeColor = System.Drawing.Color.Empty;
            this.UpassTb.HintText = "";
            this.UpassTb.isPassword = false;
            this.UpassTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.UpassTb.LineIdleColor = System.Drawing.Color.Gray;
            this.UpassTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UpassTb.LineThickness = 3;
            this.UpassTb.Location = new System.Drawing.Point(150, 181);
            this.UpassTb.Margin = new System.Windows.Forms.Padding(4);
            this.UpassTb.MaxLength = 32767;
            this.UpassTb.Name = "UpassTb";
            this.UpassTb.Size = new System.Drawing.Size(230, 33);
            this.UpassTb.TabIndex = 5;
            this.UpassTb.Text = "User Password";
            this.UpassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "User List:";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UserDGV
            // 
            this.UserDGV.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.UserDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDGV.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.UserDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserDGV.ColumnHeadersHeight = 40;
            this.UserDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.UserDGV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.UserDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.UserDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.UserDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.UserDGV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.UserDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.UserDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.UserDGV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.UserDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UserDGV.CurrentTheme.Name = null;
            this.UserDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UserDGV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.UserDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.UserDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.UserDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserDGV.EnableHeadersVisualStyles = false;
            this.UserDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.UserDGV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.UserDGV.HeaderBgColor = System.Drawing.Color.Empty;
            this.UserDGV.HeaderForeColor = System.Drawing.Color.White;
            this.UserDGV.Location = new System.Drawing.Point(417, 91);
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.RowHeadersVisible = false;
            this.UserDGV.RowTemplate.Height = 40;
            this.UserDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDGV.Size = new System.Drawing.Size(477, 398);
            this.UserDGV.TabIndex = 12;
            this.UserDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.UserDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDGV_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::University_management_system.Properties.Resources.icons8_close_window_96px;
            this.pictureBox1.Location = new System.Drawing.Point(825, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuButton4
            // 
            this.bunifuButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton4.BackgroundImage")));
            this.bunifuButton4.ButtonText = "Home";
            this.bunifuButton4.ButtonTextMarginLeft = 0;
            this.bunifuButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton4.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton4.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IconPadding = 10;
            this.bunifuButton4.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton4.IdleBorderRadius = 1;
            this.bunifuButton4.IdleBorderThickness = 0;
            this.bunifuButton4.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton4.IdleIconLeftImage = null;
            this.bunifuButton4.IdleIconRightImage = null;
            this.bunifuButton4.Location = new System.Drawing.Point(38, 346);
            this.bunifuButton4.Name = "bunifuButton4";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton4.onHoverState = stateProperties1;
            this.bunifuButton4.Size = new System.Drawing.Size(137, 45);
            this.bunifuButton4.TabIndex = 11;
            this.bunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton4.Click += new System.EventHandler(this.bunifuButton4_Click);
            // 
            // bunifuButton3
            // 
            this.bunifuButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.BackgroundImage")));
            this.bunifuButton3.ButtonText = "Delete";
            this.bunifuButton3.ButtonTextMarginLeft = 0;
            this.bunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton3.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton3.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconPadding = 10;
            this.bunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton3.IdleBorderRadius = 1;
            this.bunifuButton3.IdleBorderThickness = 0;
            this.bunifuButton3.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton3.IdleIconLeftImage = null;
            this.bunifuButton3.IdleIconRightImage = null;
            this.bunifuButton3.Location = new System.Drawing.Point(243, 346);
            this.bunifuButton3.Name = "bunifuButton3";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton3.onHoverState = stateProperties2;
            this.bunifuButton3.Size = new System.Drawing.Size(137, 45);
            this.bunifuButton3.TabIndex = 9;
            this.bunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton3.Click += new System.EventHandler(this.bunifuButton3_Click);
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.ButtonText = "Update";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton2.IdleBorderRadius = 1;
            this.bunifuButton2.IdleBorderThickness = 0;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.Location = new System.Drawing.Point(243, 262);
            this.bunifuButton2.Name = "bunifuButton2";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.bunifuButton2.onHoverState = stateProperties3;
            this.bunifuButton2.Size = new System.Drawing.Size(137, 45);
            this.bunifuButton2.TabIndex = 8;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.ButtonText = "Add";
            this.AddButton.ButtonTextMarginLeft = 0;
            this.AddButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.AddButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.AddButton.DisabledForecolor = System.Drawing.Color.White;
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddButton.IconPadding = 10;
            this.AddButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.AddButton.IdleBorderRadius = 1;
            this.AddButton.IdleBorderThickness = 0;
            this.AddButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.AddButton.IdleIconLeftImage = null;
            this.AddButton.IdleIconRightImage = null;
            this.AddButton.Location = new System.Drawing.Point(38, 262);
            this.AddButton.Name = "AddButton";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.AddButton.onHoverState = stateProperties4;
            this.AddButton.Size = new System.Drawing.Size(137, 45);
            this.AddButton.TabIndex = 7;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddButton.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UserDGV);
            this.Controls.Add(this.bunifuButton4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuButton3);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.UpassTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UnameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UidTb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInfo";
            this.Load += new System.EventHandler(this.UserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UidTb;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UnameTb;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UpassTb;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton3;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton4;
        private DataSet1 dataSet11;
        private Bunifu.UI.WinForms.BunifuDataGridView UserDGV;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}