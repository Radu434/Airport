namespace AeroportV1
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.timerSlider = new System.Windows.Forms.Timer(this.components);
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.btnRegisterCancel = new System.Windows.Forms.Button();
            this.lblRegisterInfo = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblRegisterPrenume = new System.Windows.Forms.Label();
            this.txtRegisterPrenume = new System.Windows.Forms.TextBox();
            this.lblRegisterEmail = new System.Windows.Forms.Label();
            this.txtRegisterEmail = new System.Windows.Forms.TextBox();
            this.lblRegisterTel = new System.Windows.Forms.Label();
            this.txtRegisterTel = new System.Windows.Forms.TextBox();
            this.lblRegisterParola2 = new System.Windows.Forms.Label();
            this.txtRegisterParola2 = new System.Windows.Forms.TextBox();
            this.lblRegisterParola = new System.Windows.Forms.Label();
            this.txtRegisterParola = new System.Windows.Forms.TextBox();
            this.lblRegisterNume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegisterNume = new System.Windows.Forms.TextBox();
            this.pbSlider = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.progressBarLogin = new System.Windows.Forms.ProgressBar();
            this.lblRegister = new System.Windows.Forms.LinkLabel();
            this.pbLogo1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlTopBar.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlider)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.pnlTopBar.Controls.Add(this.btnMinimize);
            this.pnlTopBar.Controls.Add(this.lblNume);
            this.pnlTopBar.Controls.Add(this.btnExit);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1081, 25);
            this.pnlTopBar.TabIndex = 0;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            this.pnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseMove);
            this.pnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.btnMinimize.BackgroundImage = global::AeroportV1.Properties.Resources._;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(993, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 25);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = System.Drawing.Color.White;
            this.lblNume.Location = new System.Drawing.Point(495, 2);
            this.lblNume.Name = "lblNume";
            this.lblNume.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNume.Size = new System.Drawing.Size(111, 20);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Aeroportul Dej";
            this.lblNume.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.btnExit.BackgroundImage = global::AeroportV1.Properties.Resources.x;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1037, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timerSlider
            // 
            this.timerSlider.Enabled = true;
            this.timerSlider.Interval = 5000;
            this.timerSlider.Tick += new System.EventHandler(this.timerSlider_Tick);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::AeroportV1.Properties.Resources.clouds;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackground.Controls.Add(this.pnlRegister);
            this.pnlBackground.Controls.Add(this.pbSlider);
            this.pnlBackground.Controls.Add(this.pnlLogin);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 25);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1081, 555);
            this.pnlBackground.TabIndex = 2;
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(90)))));
            this.pnlRegister.Controls.Add(this.btnRegisterCancel);
            this.pnlRegister.Controls.Add(this.lblRegisterInfo);
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.lblRegisterPrenume);
            this.pnlRegister.Controls.Add(this.txtRegisterPrenume);
            this.pnlRegister.Controls.Add(this.lblRegisterEmail);
            this.pnlRegister.Controls.Add(this.txtRegisterEmail);
            this.pnlRegister.Controls.Add(this.lblRegisterTel);
            this.pnlRegister.Controls.Add(this.txtRegisterTel);
            this.pnlRegister.Controls.Add(this.lblRegisterParola2);
            this.pnlRegister.Controls.Add(this.txtRegisterParola2);
            this.pnlRegister.Controls.Add(this.lblRegisterParola);
            this.pnlRegister.Controls.Add(this.txtRegisterParola);
            this.pnlRegister.Controls.Add(this.lblRegisterNume);
            this.pnlRegister.Controls.Add(this.label1);
            this.pnlRegister.Controls.Add(this.txtRegisterNume);
            this.pnlRegister.Location = new System.Drawing.Point(213, 0);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(654, 555);
            this.pnlRegister.TabIndex = 3;
            this.pnlRegister.Visible = false;
            // 
            // btnRegisterCancel
            // 
            this.btnRegisterCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegisterCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegisterCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterCancel.ForeColor = System.Drawing.Color.White;
            this.btnRegisterCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterCancel.Location = new System.Drawing.Point(549, 504);
            this.btnRegisterCancel.Name = "btnRegisterCancel";
            this.btnRegisterCancel.Size = new System.Drawing.Size(105, 51);
            this.btnRegisterCancel.TabIndex = 15;
            this.btnRegisterCancel.Text = "Anuleaza";
            this.btnRegisterCancel.UseVisualStyleBackColor = false;
            this.btnRegisterCancel.Click += new System.EventHandler(this.btnRegisterCancel_Click);
            // 
            // lblRegisterInfo
            // 
            this.lblRegisterInfo.AutoSize = true;
            this.lblRegisterInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.lblRegisterInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRegisterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterInfo.ForeColor = System.Drawing.Color.White;
            this.lblRegisterInfo.Location = new System.Drawing.Point(61, 351);
            this.lblRegisterInfo.Name = "lblRegisterInfo";
            this.lblRegisterInfo.Size = new System.Drawing.Size(182, 24);
            this.lblRegisterInfo.TabIndex = 14;
            this.lblRegisterInfo.Text = " * - camp obligatoriu ";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(154)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(231, 387);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(193, 52);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Inregistrare";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblRegisterPrenume
            // 
            this.lblRegisterPrenume.AutoSize = true;
            this.lblRegisterPrenume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.lblRegisterPrenume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRegisterPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPrenume.ForeColor = System.Drawing.Color.White;
            this.lblRegisterPrenume.Location = new System.Drawing.Point(320, 158);
            this.lblRegisterPrenume.Name = "lblRegisterPrenume";
            this.lblRegisterPrenume.Size = new System.Drawing.Size(95, 24);
            this.lblRegisterPrenume.TabIndex = 12;
            this.lblRegisterPrenume.Text = "Prenume*";
            // 
            // txtRegisterPrenume
            // 
            this.txtRegisterPrenume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegisterPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPrenume.Location = new System.Drawing.Point(413, 158);
            this.txtRegisterPrenume.MaxLength = 30;
            this.txtRegisterPrenume.Name = "txtRegisterPrenume";
            this.txtRegisterPrenume.Size = new System.Drawing.Size(161, 26);
            this.txtRegisterPrenume.TabIndex = 11;
            this.txtRegisterPrenume.TextChanged += new System.EventHandler(this.txtRegisterPrenume_TextChanged);
            // 
            // lblRegisterEmail
            // 
            this.lblRegisterEmail.AutoSize = true;
            this.lblRegisterEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.lblRegisterEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterEmail.ForeColor = System.Drawing.Color.White;
            this.lblRegisterEmail.Location = new System.Drawing.Point(345, 310);
            this.lblRegisterEmail.Name = "lblRegisterEmail";
            this.lblRegisterEmail.Size = new System.Drawing.Size(64, 24);
            this.lblRegisterEmail.TabIndex = 10;
            this.lblRegisterEmail.Text = "Email*";
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterEmail.Location = new System.Drawing.Point(413, 310);
            this.txtRegisterEmail.MaxLength = 30;
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(161, 26);
            this.txtRegisterEmail.TabIndex = 9;
            this.txtRegisterEmail.TextChanged += new System.EventHandler(this.txtRegisterEmail_TextChanged);
            // 
            // lblRegisterTel
            // 
            this.lblRegisterTel.AutoSize = true;
            this.lblRegisterTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.lblRegisterTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRegisterTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterTel.ForeColor = System.Drawing.Color.White;
            this.lblRegisterTel.Location = new System.Drawing.Point(61, 312);
            this.lblRegisterTel.Name = "lblRegisterTel";
            this.lblRegisterTel.Size = new System.Drawing.Size(62, 24);
            this.lblRegisterTel.TabIndex = 8;
            this.lblRegisterTel.Text = "Nr.Tel";
            // 
            // txtRegisterTel
            // 
            this.txtRegisterTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegisterTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterTel.Location = new System.Drawing.Point(129, 310);
            this.txtRegisterTel.MaxLength = 13;
            this.txtRegisterTel.Name = "txtRegisterTel";
            this.txtRegisterTel.Size = new System.Drawing.Size(161, 26);
            this.txtRegisterTel.TabIndex = 7;
            // 
            // lblRegisterParola2
            // 
            this.lblRegisterParola2.AutoSize = true;
            this.lblRegisterParola2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.lblRegisterParola2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRegisterParola2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterParola2.ForeColor = System.Drawing.Color.White;
            this.lblRegisterParola2.Location = new System.Drawing.Point(345, 234);
            this.lblRegisterParola2.Name = "lblRegisterParola2";
            this.lblRegisterParola2.Size = new System.Drawing.Size(70, 24);
            this.lblRegisterParola2.TabIndex = 6;
            this.lblRegisterParola2.Text = "Parola*";
            // 
            // txtRegisterParola2
            // 
            this.txtRegisterParola2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegisterParola2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterParola2.Location = new System.Drawing.Point(413, 234);
            this.txtRegisterParola2.MaxLength = 20;
            this.txtRegisterParola2.Name = "txtRegisterParola2";
            this.txtRegisterParola2.PasswordChar = '*';
            this.txtRegisterParola2.Size = new System.Drawing.Size(161, 26);
            this.txtRegisterParola2.TabIndex = 5;
            this.txtRegisterParola2.TextChanged += new System.EventHandler(this.txtRegisterParola2_TextChanged);
            // 
            // lblRegisterParola
            // 
            this.lblRegisterParola.AutoSize = true;
            this.lblRegisterParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.lblRegisterParola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRegisterParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterParola.ForeColor = System.Drawing.Color.White;
            this.lblRegisterParola.Location = new System.Drawing.Point(61, 235);
            this.lblRegisterParola.Name = "lblRegisterParola";
            this.lblRegisterParola.Size = new System.Drawing.Size(70, 24);
            this.lblRegisterParola.TabIndex = 4;
            this.lblRegisterParola.Text = "Parola*";
            // 
            // txtRegisterParola
            // 
            this.txtRegisterParola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegisterParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterParola.Location = new System.Drawing.Point(129, 234);
            this.txtRegisterParola.MaxLength = 20;
            this.txtRegisterParola.Name = "txtRegisterParola";
            this.txtRegisterParola.PasswordChar = '*';
            this.txtRegisterParola.Size = new System.Drawing.Size(161, 26);
            this.txtRegisterParola.TabIndex = 3;
            this.txtRegisterParola.TextChanged += new System.EventHandler(this.txtRegisterParola_TextChanged);
            // 
            // lblRegisterNume
            // 
            this.lblRegisterNume.AutoSize = true;
            this.lblRegisterNume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.lblRegisterNume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRegisterNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterNume.ForeColor = System.Drawing.Color.White;
            this.lblRegisterNume.Location = new System.Drawing.Point(61, 158);
            this.lblRegisterNume.Name = "lblRegisterNume";
            this.lblRegisterNume.Size = new System.Drawing.Size(69, 24);
            this.lblRegisterNume.TabIndex = 2;
            this.lblRegisterNume.Text = "Nume*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creeaza-ti un cont";
            // 
            // txtRegisterNume
            // 
            this.txtRegisterNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegisterNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterNume.Location = new System.Drawing.Point(129, 158);
            this.txtRegisterNume.MaxLength = 30;
            this.txtRegisterNume.Name = "txtRegisterNume";
            this.txtRegisterNume.Size = new System.Drawing.Size(161, 26);
            this.txtRegisterNume.TabIndex = 0;
            this.txtRegisterNume.TextChanged += new System.EventHandler(this.txtRegisterNume_TextChanged);
            // 
            // pbSlider
            // 
            this.pbSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSlider.Location = new System.Drawing.Point(0, 0);
            this.pbSlider.Margin = new System.Windows.Forms.Padding(0);
            this.pbSlider.Name = "pbSlider";
            this.pbSlider.Size = new System.Drawing.Size(750, 555);
            this.pbSlider.TabIndex = 2;
            this.pbSlider.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(115)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.pnlLogin.Controls.Add(this.progressBarLogin);
            this.pnlLogin.Controls.Add(this.lblRegister);
            this.pnlLogin.Controls.Add(this.pbLogo1);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtParola);
            this.pnlLogin.Controls.Add(this.txtEmail);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlLogin.Location = new System.Drawing.Point(750, 0);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(331, 555);
            this.pnlLogin.TabIndex = 1;
            // 
            // progressBarLogin
            // 
            this.progressBarLogin.BackColor = System.Drawing.SystemColors.ControlText;
            this.progressBarLogin.ForeColor = System.Drawing.Color.Red;
            this.progressBarLogin.Location = new System.Drawing.Point(0, 545);
            this.progressBarLogin.Name = "progressBarLogin";
            this.progressBarLogin.Size = new System.Drawing.Size(331, 10);
            this.progressBarLogin.Step = 100;
            this.progressBarLogin.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarLogin.TabIndex = 6;
            // 
            // lblRegister
            // 
            this.lblRegister.ActiveLinkColor = System.Drawing.Color.Teal;
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);
            this.lblRegister.LinkColor = System.Drawing.Color.Black;
            this.lblRegister.Location = new System.Drawing.Point(69, 417);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(205, 20);
            this.lblRegister.TabIndex = 5;
            this.lblRegister.TabStop = true;
            this.lblRegister.Text = "Nu ai cont? Inregistreaza-te";
            this.lblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegister_LinkClicked);
            // 
            // pbLogo1
            // 
            this.pbLogo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbLogo1.BackgroundImage = global::AeroportV1.Properties.Resources.logo3;
            this.pbLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo1.Location = new System.Drawing.Point(21, 3);
            this.pbLogo1.Name = "pbLogo1";
            this.pbLogo1.Size = new System.Drawing.Size(287, 236);
            this.pbLogo1.TabIndex = 3;
            this.pbLogo1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(73, 346);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(193, 52);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtParola
            // 
            this.txtParola.BackColor = System.Drawing.Color.White;
            this.txtParola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola.Location = new System.Drawing.Point(28, 282);
            this.txtParola.MaxLength = 30;
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(280, 31);
            this.txtParola.TabIndex = 1;
            this.txtParola.Text = "Parola";
            this.txtParola.Click += new System.EventHandler(this.txtParola_Click);
            this.txtParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParola_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(28, 241);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 31);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "Email";
            this.txtEmail.Click += new System.EventHandler(this.txtNume_Click);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 580);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pnlTopBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlider)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblNume;
       
        private System.Windows.Forms.PictureBox pbLogo1;
        private System.Windows.Forms.Timer timerSlider;
        private System.Windows.Forms.PictureBox pbSlider;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Label lblRegisterPrenume;
        private System.Windows.Forms.TextBox txtRegisterPrenume;
        private System.Windows.Forms.Label lblRegisterEmail;
        private System.Windows.Forms.TextBox txtRegisterEmail;
        private System.Windows.Forms.Label lblRegisterTel;
        private System.Windows.Forms.TextBox txtRegisterTel;
        private System.Windows.Forms.Label lblRegisterParola2;
        private System.Windows.Forms.TextBox txtRegisterParola2;
        private System.Windows.Forms.Label lblRegisterParola;
        private System.Windows.Forms.TextBox txtRegisterParola;
        private System.Windows.Forms.Label lblRegisterNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegisterNume;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel lblRegister;
        private System.Windows.Forms.Label lblRegisterInfo;
        private System.Windows.Forms.Button btnRegisterCancel;
        private System.Windows.Forms.ProgressBar progressBarLogin;
    }
}

