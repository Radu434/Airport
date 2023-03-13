namespace AeroportV1
{
    partial class frmUserMain
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.linkLblCont = new System.Windows.Forms.LinkLabel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIstoric = new System.Windows.Forms.Button();
            this.btnZboruri = new System.Windows.Forms.Button();
            this.btnCont = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlIdtoricCont = new System.Windows.Forms.Panel();
            this.lblContTotalBani = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvIstoricCont = new System.Windows.Forms.DataGridView();
            this.pnlZboruri = new System.Windows.Forms.Panel();
            this.btnCumparaBilet = new System.Windows.Forms.Button();
            this.dgvZbor = new System.Windows.Forms.DataGridView();
            this.pnlCautaZbor = new System.Windows.Forms.Panel();
            this.cbZborCautaCompanie = new System.Windows.Forms.ComboBox();
            this.cbZborCautaAeroport = new System.Windows.Forms.ComboBox();
            this.btnZborCauta = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.pnlCont = new System.Windows.Forms.Panel();
            this.btnContSchimbaParola = new System.Windows.Forms.Button();
            this.btnContActualizareDate = new System.Windows.Forms.Button();
            this.txtContNewPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContOldPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContPrenume = new System.Windows.Forms.TextBox();
            this.txtContTelefon = new System.Windows.Forms.TextBox();
            this.txtContEmail = new System.Windows.Forms.TextBox();
            this.txtContNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContNume = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlTopBar.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlIdtoricCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstoricCont)).BeginInit();
            this.pnlZboruri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZbor)).BeginInit();
            this.pnlCautaZbor.SuspendLayout();
            this.pnlCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.pnlTopBar.Controls.Add(this.linkLblCont);
            this.pnlTopBar.Controls.Add(this.btnLogout);
            this.pnlTopBar.Controls.Add(this.btnMinimize);
            this.pnlTopBar.Controls.Add(this.lblNume);
            this.pnlTopBar.Controls.Add(this.btnExit);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1376, 25);
            this.pnlTopBar.TabIndex = 2;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            this.pnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseMove);
            this.pnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseUp);
            // 
            // linkLblCont
            // 
            this.linkLblCont.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLblCont.AutoSize = true;
            this.linkLblCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblCont.LinkColor = System.Drawing.Color.White;
            this.linkLblCont.Location = new System.Drawing.Point(12, 5);
            this.linkLblCont.Name = "linkLblCont";
            this.linkLblCont.Size = new System.Drawing.Size(69, 16);
            this.linkLblCont.TabIndex = 4;
            this.linkLblCont.TabStop = true;
            this.linkLblCont.Text = "linkLabel1";
            this.linkLblCont.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblCont_LinkClicked);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.btnLogout.BackgroundImage = global::AeroportV1.Properties.Resources.logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1244, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(44, 25);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseHover += new System.EventHandler(this.btnLogout_MouseHover);
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
            this.btnMinimize.Location = new System.Drawing.Point(1288, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 25);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseHover += new System.EventHandler(this.btnMinimize_MouseHover);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = System.Drawing.Color.White;
            this.lblNume.Location = new System.Drawing.Point(626, 1);
            this.lblNume.Name = "lblNume";
            this.lblNume.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNume.Size = new System.Drawing.Size(115, 20);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = " Aeroportul Dej";
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
            this.btnExit.Location = new System.Drawing.Point(1332, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(60)))), ((int)(((byte)(134)))));
            this.pnlToolbar.Controls.Add(this.pictureBox2);
            this.pnlToolbar.Controls.Add(this.pictureBox1);
            this.pnlToolbar.Controls.Add(this.btnIstoric);
            this.pnlToolbar.Controls.Add(this.btnZboruri);
            this.pnlToolbar.Controls.Add(this.btnCont);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 25);
            this.pnlToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1376, 43);
            this.pnlToolbar.TabIndex = 3;
            this.pnlToolbar.MouseEnter += new System.EventHandler(this.pnlToolbar_MouseEnter);
            this.pnlToolbar.MouseLeave += new System.EventHandler(this.pnlToolbar_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AeroportV1.Properties.Resources.menu;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(626, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnIstoric
            // 
            this.btnIstoric.FlatAppearance.BorderSize = 0;
            this.btnIstoric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIstoric.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIstoric.ForeColor = System.Drawing.Color.White;
            this.btnIstoric.Location = new System.Drawing.Point(1071, 15);
            this.btnIstoric.Margin = new System.Windows.Forms.Padding(0);
            this.btnIstoric.Name = "btnIstoric";
            this.btnIstoric.Size = new System.Drawing.Size(191, 77);
            this.btnIstoric.TabIndex = 4;
            this.btnIstoric.Text = "Istoric Cont";
            this.btnIstoric.UseVisualStyleBackColor = true;
            this.btnIstoric.Visible = false;
            this.btnIstoric.Click += new System.EventHandler(this.btnIstoric_Click);
            // 
            // btnZboruri
            // 
            this.btnZboruri.FlatAppearance.BorderSize = 0;
            this.btnZboruri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZboruri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZboruri.ForeColor = System.Drawing.Color.White;
            this.btnZboruri.Location = new System.Drawing.Point(301, 15);
            this.btnZboruri.Margin = new System.Windows.Forms.Padding(0);
            this.btnZboruri.Name = "btnZboruri";
            this.btnZboruri.Size = new System.Drawing.Size(122, 77);
            this.btnZboruri.TabIndex = 2;
            this.btnZboruri.Text = "Zboruri";
            this.btnZboruri.UseVisualStyleBackColor = true;
            this.btnZboruri.Visible = false;
            this.btnZboruri.Click += new System.EventHandler(this.btnZboruri_Click);
            // 
            // btnCont
            // 
            this.btnCont.FlatAppearance.BorderSize = 0;
            this.btnCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCont.ForeColor = System.Drawing.Color.White;
            this.btnCont.Location = new System.Drawing.Point(686, 15);
            this.btnCont.Margin = new System.Windows.Forms.Padding(0);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(122, 77);
            this.btnCont.TabIndex = 1;
            this.btnCont.Text = "Cont";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Visible = false;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = global::AeroportV1.Properties.Resources.logo1;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMain.Controls.Add(this.pnlIdtoricCont);
            this.pnlMain.Controls.Add(this.pnlZboruri);
            this.pnlMain.Controls.Add(this.pnlCont);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 68);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1376, 782);
            this.pnlMain.TabIndex = 4;
            // 
            // pnlIdtoricCont
            // 
            this.pnlIdtoricCont.BackColor = System.Drawing.Color.White;
            this.pnlIdtoricCont.BackgroundImage = global::AeroportV1.Properties.Resources.clouds;
            this.pnlIdtoricCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlIdtoricCont.Controls.Add(this.lblContTotalBani);
            this.pnlIdtoricCont.Controls.Add(this.label6);
            this.pnlIdtoricCont.Controls.Add(this.dgvIstoricCont);
            this.pnlIdtoricCont.Location = new System.Drawing.Point(908, 468);
            this.pnlIdtoricCont.Name = "pnlIdtoricCont";
            this.pnlIdtoricCont.Size = new System.Drawing.Size(424, 220);
            this.pnlIdtoricCont.TabIndex = 2;
            this.pnlIdtoricCont.Visible = false;
            // 
            // lblContTotalBani
            // 
            this.lblContTotalBani.AutoSize = true;
            this.lblContTotalBani.BackColor = System.Drawing.Color.Transparent;
            this.lblContTotalBani.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContTotalBani.Location = new System.Drawing.Point(64, 325);
            this.lblContTotalBani.Name = "lblContTotalBani";
            this.lblContTotalBani.Size = new System.Drawing.Size(189, 29);
            this.lblContTotalBani.TabIndex = 15;
            this.lblContTotalBani.Text = "Total bani platiti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(372, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "Zboruri inregistrate pe cont:";
            // 
            // dgvIstoricCont
            // 
            this.dgvIstoricCont.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(134)))));
            this.dgvIstoricCont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIstoricCont.GridColor = System.Drawing.Color.White;
            this.dgvIstoricCont.Location = new System.Drawing.Point(56, 87);
            this.dgvIstoricCont.Name = "dgvIstoricCont";
            this.dgvIstoricCont.ReadOnly = true;
            this.dgvIstoricCont.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIstoricCont.Size = new System.Drawing.Size(1020, 210);
            this.dgvIstoricCont.TabIndex = 13;
            // 
            // pnlZboruri
            // 
            this.pnlZboruri.BackColor = System.Drawing.Color.White;
            this.pnlZboruri.BackgroundImage = global::AeroportV1.Properties.Resources.clouds;
            this.pnlZboruri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlZboruri.Controls.Add(this.btnCumparaBilet);
            this.pnlZboruri.Controls.Add(this.dgvZbor);
            this.pnlZboruri.Controls.Add(this.pnlCautaZbor);
            this.pnlZboruri.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlZboruri.Location = new System.Drawing.Point(0, 484);
            this.pnlZboruri.Name = "pnlZboruri";
            this.pnlZboruri.Size = new System.Drawing.Size(249, 248);
            this.pnlZboruri.TabIndex = 1;
            this.pnlZboruri.Visible = false;
            // 
            // btnCumparaBilet
            // 
            this.btnCumparaBilet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.btnCumparaBilet.FlatAppearance.BorderSize = 0;
            this.btnCumparaBilet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCumparaBilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCumparaBilet.ForeColor = System.Drawing.Color.White;
            this.btnCumparaBilet.Location = new System.Drawing.Point(912, 185);
            this.btnCumparaBilet.Margin = new System.Windows.Forms.Padding(0);
            this.btnCumparaBilet.Name = "btnCumparaBilet";
            this.btnCumparaBilet.Size = new System.Drawing.Size(153, 43);
            this.btnCumparaBilet.TabIndex = 15;
            this.btnCumparaBilet.Text = "Cumpara Bilet";
            this.btnCumparaBilet.UseVisualStyleBackColor = false;
            this.btnCumparaBilet.Click += new System.EventHandler(this.btnCumparaBilet_Click);
            // 
            // dgvZbor
            // 
            this.dgvZbor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(134)))));
            this.dgvZbor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZbor.GridColor = System.Drawing.Color.White;
            this.dgvZbor.Location = new System.Drawing.Point(685, 14);
            this.dgvZbor.Name = "dgvZbor";
            this.dgvZbor.ReadOnly = true;
            this.dgvZbor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZbor.Size = new System.Drawing.Size(593, 150);
            this.dgvZbor.TabIndex = 13;
            // 
            // pnlCautaZbor
            // 
            this.pnlCautaZbor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(174)))));
            this.pnlCautaZbor.Controls.Add(this.cbZborCautaCompanie);
            this.pnlCautaZbor.Controls.Add(this.cbZborCautaAeroport);
            this.pnlCautaZbor.Controls.Add(this.btnZborCauta);
            this.pnlCautaZbor.Controls.Add(this.label20);
            this.pnlCautaZbor.Controls.Add(this.label21);
            this.pnlCautaZbor.Location = new System.Drawing.Point(24, 14);
            this.pnlCautaZbor.Name = "pnlCautaZbor";
            this.pnlCautaZbor.Size = new System.Drawing.Size(569, 268);
            this.pnlCautaZbor.TabIndex = 11;
            // 
            // cbZborCautaCompanie
            // 
            this.cbZborCautaCompanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbZborCautaCompanie.FormattingEnabled = true;
            this.cbZborCautaCompanie.Location = new System.Drawing.Point(189, 33);
            this.cbZborCautaCompanie.Name = "cbZborCautaCompanie";
            this.cbZborCautaCompanie.Size = new System.Drawing.Size(299, 28);
            this.cbZborCautaCompanie.TabIndex = 20;
            this.cbZborCautaCompanie.SelectedIndexChanged += new System.EventHandler(this.cbZborCautaCompanie_SelectedIndexChanged);
            // 
            // cbZborCautaAeroport
            // 
            this.cbZborCautaAeroport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbZborCautaAeroport.FormattingEnabled = true;
            this.cbZborCautaAeroport.Location = new System.Drawing.Point(189, 86);
            this.cbZborCautaAeroport.Name = "cbZborCautaAeroport";
            this.cbZborCautaAeroport.Size = new System.Drawing.Size(299, 28);
            this.cbZborCautaAeroport.TabIndex = 19;
            // 
            // btnZborCauta
            // 
            this.btnZborCauta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.btnZborCauta.FlatAppearance.BorderSize = 0;
            this.btnZborCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZborCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZborCauta.ForeColor = System.Drawing.Color.White;
            this.btnZborCauta.Location = new System.Drawing.Point(236, 171);
            this.btnZborCauta.Margin = new System.Windows.Forms.Padding(0);
            this.btnZborCauta.Name = "btnZborCauta";
            this.btnZborCauta.Size = new System.Drawing.Size(153, 43);
            this.btnZborCauta.TabIndex = 14;
            this.btnZborCauta.Text = "Cauta zbor";
            this.btnZborCauta.UseVisualStyleBackColor = false;
            this.btnZborCauta.Click += new System.EventHandler(this.btnZborCauta_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(8, 92);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(175, 24);
            this.label20.TabIndex = 16;
            this.label20.Text = "Aeroport-Destinatie:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(81, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 24);
            this.label21.TabIndex = 18;
            this.label21.Text = "Companie:";
            // 
            // pnlCont
            // 
            this.pnlCont.BackColor = System.Drawing.Color.White;
            this.pnlCont.BackgroundImage = global::AeroportV1.Properties.Resources.clouds;
            this.pnlCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCont.Controls.Add(this.btnContSchimbaParola);
            this.pnlCont.Controls.Add(this.btnContActualizareDate);
            this.pnlCont.Controls.Add(this.txtContNewPass);
            this.pnlCont.Controls.Add(this.label5);
            this.pnlCont.Controls.Add(this.txtContOldPass);
            this.pnlCont.Controls.Add(this.label4);
            this.pnlCont.Controls.Add(this.txtContPrenume);
            this.pnlCont.Controls.Add(this.txtContTelefon);
            this.pnlCont.Controls.Add(this.txtContEmail);
            this.pnlCont.Controls.Add(this.txtContNume);
            this.pnlCont.Controls.Add(this.label3);
            this.pnlCont.Controls.Add(this.label2);
            this.pnlCont.Controls.Add(this.label1);
            this.pnlCont.Controls.Add(this.lblContNume);
            this.pnlCont.Location = new System.Drawing.Point(56, 31);
            this.pnlCont.Name = "pnlCont";
            this.pnlCont.Size = new System.Drawing.Size(1232, 397);
            this.pnlCont.TabIndex = 0;
            this.pnlCont.Visible = false;
            // 
            // btnContSchimbaParola
            // 
            this.btnContSchimbaParola.BackColor = System.Drawing.Color.Transparent;
            this.btnContSchimbaParola.BackgroundImage = global::AeroportV1.Properties.Resources.buton;
            this.btnContSchimbaParola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContSchimbaParola.FlatAppearance.BorderSize = 0;
            this.btnContSchimbaParola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContSchimbaParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContSchimbaParola.ForeColor = System.Drawing.Color.White;
            this.btnContSchimbaParola.Location = new System.Drawing.Point(995, 248);
            this.btnContSchimbaParola.Name = "btnContSchimbaParola";
            this.btnContSchimbaParola.Size = new System.Drawing.Size(205, 61);
            this.btnContSchimbaParola.TabIndex = 13;
            this.btnContSchimbaParola.Text = "Schimba Parola";
            this.btnContSchimbaParola.UseVisualStyleBackColor = false;
            this.btnContSchimbaParola.Click += new System.EventHandler(this.btnContSchimbaParola_Click);
            // 
            // btnContActualizareDate
            // 
            this.btnContActualizareDate.BackColor = System.Drawing.Color.Transparent;
            this.btnContActualizareDate.BackgroundImage = global::AeroportV1.Properties.Resources.buton;
            this.btnContActualizareDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContActualizareDate.FlatAppearance.BorderSize = 0;
            this.btnContActualizareDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContActualizareDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContActualizareDate.ForeColor = System.Drawing.Color.White;
            this.btnContActualizareDate.Location = new System.Drawing.Point(315, 233);
            this.btnContActualizareDate.Name = "btnContActualizareDate";
            this.btnContActualizareDate.Size = new System.Drawing.Size(205, 61);
            this.btnContActualizareDate.TabIndex = 12;
            this.btnContActualizareDate.Text = "Actualizare Date";
            this.btnContActualizareDate.UseVisualStyleBackColor = false;
            this.btnContActualizareDate.Click += new System.EventHandler(this.btnContActualizareDate_Click);
            // 
            // txtContNewPass
            // 
            this.txtContNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContNewPass.Location = new System.Drawing.Point(995, 192);
            this.txtContNewPass.Name = "txtContNewPass";
            this.txtContNewPass.Size = new System.Drawing.Size(205, 29);
            this.txtContNewPass.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(836, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parola noua";
            // 
            // txtContOldPass
            // 
            this.txtContOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContOldPass.Location = new System.Drawing.Point(995, 108);
            this.txtContOldPass.Name = "txtContOldPass";
            this.txtContOldPass.Size = new System.Drawing.Size(205, 29);
            this.txtContOldPass.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(836, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parola veche";
            // 
            // txtContPrenume
            // 
            this.txtContPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContPrenume.Location = new System.Drawing.Point(496, 114);
            this.txtContPrenume.Name = "txtContPrenume";
            this.txtContPrenume.Size = new System.Drawing.Size(205, 29);
            this.txtContPrenume.TabIndex = 7;
            // 
            // txtContTelefon
            // 
            this.txtContTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContTelefon.Location = new System.Drawing.Point(496, 198);
            this.txtContTelefon.Name = "txtContTelefon";
            this.txtContTelefon.Size = new System.Drawing.Size(205, 29);
            this.txtContTelefon.TabIndex = 6;
            // 
            // txtContEmail
            // 
            this.txtContEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContEmail.Location = new System.Drawing.Point(127, 199);
            this.txtContEmail.Name = "txtContEmail";
            this.txtContEmail.Size = new System.Drawing.Size(205, 29);
            this.txtContEmail.TabIndex = 5;
            // 
            // txtContNume
            // 
            this.txtContNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContNume.Location = new System.Drawing.Point(127, 116);
            this.txtContNume.Name = "txtContNume";
            this.txtContNume.Size = new System.Drawing.Size(205, 29);
            this.txtContNume.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prenume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefon";
            // 
            // lblContNume
            // 
            this.lblContNume.AutoSize = true;
            this.lblContNume.BackColor = System.Drawing.Color.Transparent;
            this.lblContNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContNume.Location = new System.Drawing.Point(47, 114);
            this.lblContNume.Name = "lblContNume";
            this.lblContNume.Size = new System.Drawing.Size(78, 29);
            this.lblContNume.TabIndex = 0;
            this.lblContNume.Text = "Nume";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AeroportV1.Properties.Resources.logo1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 43);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // frmUserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 850);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlTopBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                           ";
            this.Load += new System.EventHandler(this.frmUserMain_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlIdtoricCont.ResumeLayout(false);
            this.pnlIdtoricCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstoricCont)).EndInit();
            this.pnlZboruri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZbor)).EndInit();
            this.pnlCautaZbor.ResumeLayout(false);
            this.pnlCautaZbor.PerformLayout();
            this.pnlCont.ResumeLayout(false);
            this.pnlCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnIstoric;
        private System.Windows.Forms.Button btnZboruri;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.LinkLabel linkLblCont;
        private System.Windows.Forms.Panel pnlCont;
        private System.Windows.Forms.TextBox txtContNewPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContOldPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContPrenume;
        private System.Windows.Forms.TextBox txtContTelefon;
        private System.Windows.Forms.TextBox txtContEmail;
        private System.Windows.Forms.TextBox txtContNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContNume;
        private System.Windows.Forms.Button btnContActualizareDate;
        private System.Windows.Forms.Button btnContSchimbaParola;
        private System.Windows.Forms.Panel pnlZboruri;
        private System.Windows.Forms.Panel pnlCautaZbor;
        private System.Windows.Forms.ComboBox cbZborCautaCompanie;
        private System.Windows.Forms.ComboBox cbZborCautaAeroport;
        private System.Windows.Forms.Button btnZborCauta;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvZbor;
        private System.Windows.Forms.Button btnCumparaBilet;
        private System.Windows.Forms.Panel pnlIdtoricCont;
        private System.Windows.Forms.DataGridView dgvIstoricCont;
        private System.Windows.Forms.Label lblContTotalBani;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}