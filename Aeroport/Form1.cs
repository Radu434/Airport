using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace AeroportV1
{
    public partial class frmMain : Form
    {
        static bool mouseDown = false;
        static Point lastLocation;
        frmAdminMain frmAdm = new frmAdminMain();
        frmUserMain frmUser = new frmUserMain();
       
        static int imgSlide = 1;
        public string account = "";
       public int nrDestinatii=0;


        string imgName;
        bool regN = false, regPren = false, regParola = false, regE = false;


        

        public frmMain()
        {
            InitializeComponent();
            frmAdm.refToFrmMain = this;
            frmUser.refToFrmMain = this;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            timerSlider.Start();

        }
        

        private void UserLogin()
        {
                frmAdm.DownloadDestination();
                frmAdm.CautareDestinatii();
                frmAdm.DownloadZbor();
                frmAdm.CautareZboruri();
                frmUser.CautaZborUser();
            if (txtEmail.Text == "Admin")
            {
                progressBarLogin.Value = 0;
                timerSlider.Stop();
                frmAdm.Show();
                this.Hide();
            }
            else if (txtEmail.Text == "user")
            {
                progressBarLogin.Value = 0;
                timerSlider.Stop();
                frmUser.Show();
                this.Hide();
            }
            else if (txtEmail.Text != "")
            {
                progressBarLogin.PerformStep();

                try
                {
                    MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString = @"SERVER=localhost; DATABASE=aeroport; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = @"select * FROM clienti WHERE email LIKE @Email AND parola LIKE @Parola";
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Parola", txtParola.Text);
                    MySqlDataReader oReader = cmd.ExecuteReader();

                    bool validData = false;
                    //  oReader["parola"]
                    while (oReader.Read())
                    {

                        frmUser.utilizator.idc = (int)oReader["idc"];
                        frmUser.utilizator.parola = oReader["parola"].ToString();
                        frmUser.utilizator.email = oReader["email"].ToString();
                        frmUser.utilizator.nume = oReader["nume"].ToString();
                        frmUser.utilizator.prenume = oReader["prenume"].ToString();
                        frmUser.utilizator.telefon = oReader["telefon"].ToString();

                        frmUser.PassUserData();
                        frmUser.Show();
                        
                        this.Hide();
                        validData = true;


                    }
                    if (validData == false)
                    {
                        MessageBox.Show("Date invalide!");
                    }


                    connection.Close();

                    progressBarLogin.Value = 0;
                }
                catch
                {
                    MessageBox.Show("Database error");

                }

            }
        }

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location;


        }

        private void pnlTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                frmMain.ActiveForm.Location = new Point((frmMain.ActiveForm.Location.X - lastLocation.X) + e.X, (frmMain.ActiveForm.Location.Y - lastLocation.Y) + e.Y);
            }
            this.Update();
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            frmMain.ActiveForm.WindowState = FormWindowState.Minimized;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            timerSlider.Stop();
              UserLogin();
            
       
        }

        private void txtNume_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
            }
        }

        private void txtParola_Click(object sender, EventArgs e)
        {
            if (txtParola.Text == "Parola")
            {
                txtParola.Text = "";
                txtParola.PasswordChar = '*';
            }

        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Pen bluePen = new Pen(Color.DodgerBlue);
            bluePen.Width = 20F;
            e.Graphics.DrawRectangle(bluePen, new Rectangle(0, 0, ((frmMain)sender).Width - 1, ((frmMain)sender).Height - 1));
        }



         void timerSlider_Tick(object sender, EventArgs e)
        {
            if (imgSlide < 5)
            {

                imgSlide++;
            }
            else
            {
                imgSlide = 1;

            }

            imgName = "mainSlider" + imgSlide.ToString();
            pbSlider.BackgroundImage = AeroportV1.Properties.Resources.ResourceManager.GetObject(imgName) as Image;
        }
        private void registerPanelReset()
        {
            txtRegisterEmail.Clear();
            txtRegisterNume.Clear();
            txtRegisterPrenume.Clear();
            txtRegisterTel.Clear();
            txtRegisterParola.Clear();
            txtRegisterParola2.Clear();
            lblRegisterEmail.ForeColor = Color.White;
            lblRegisterNume.ForeColor = Color.White;
            lblRegisterParola.ForeColor = Color.White;
            lblRegisterParola2.ForeColor = Color.White;
            lblRegisterPrenume.ForeColor = Color.White;
        }


        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timerSlider.Stop();
            pnlRegister.Visible = true;
            pbSlider.Visible = false;
            pnlLogin.Visible = false;
        }

        private void txtRegisterParola_TextChanged(object sender, EventArgs e)
        {
            if (txtRegisterParola.TextLength < 8)
            {
                lblRegisterParola.ForeColor = Color.Red;


            }
            else
            {
                lblRegisterParola.ForeColor = Color.LightGreen;

            }
        }

        private void txtRegisterParola2_TextChanged(object sender, EventArgs e)
        {
            if (txtRegisterParola2.TextLength < 8 || txtRegisterParola2.Text != txtRegisterParola.Text)
            {
                lblRegisterParola2.ForeColor = Color.Red;
                regParola = false;
            }
            else
            {
                lblRegisterParola2.ForeColor = Color.LightGreen;
                regParola = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (regParola == true && regE == true && regN == true && regPren == true)
            {

                try
                {

                    //Se creaza conexiunea la baza de date
                    MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString = @"SERVER=localhost; DATABASE=aeroport; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                    connection.Open();  //Se deschide conexiunea

                  /*  MySqlCommand citeste = new MySqlCommand();
                    citeste.Connection = connection;
                    citeste.CommandText = @"SELECT * FROM clienti WHERE email LIKE @Email";
                    citeste.Parameters.AddWithValue("@Email", txtEmail.Text);

                    MySqlDataReader oReader = citeste.ExecuteReader();*/
                  




                        MySqlCommand cmd = new MySqlCommand();//Se creaza comanda
                        cmd.Connection = connection;
                        cmd.CommandText = @"INSERT INTO clienti(nume, prenume, parola, email, telefon)
                                           VALUES(@pnume, @pprenume, @pparola, @pemail, @ptelefon);";
                        //se stabilesc parametrii comenzii in ORDINEA in care au fost dati
                        cmd.Parameters.AddWithValue("pnume", txtRegisterNume.Text);
                        cmd.Parameters.AddWithValue("pprenume", txtRegisterPrenume.Text);
                        cmd.Parameters.AddWithValue("pparola", txtRegisterParola2.Text);
                        cmd.Parameters.AddWithValue("pemail", txtRegisterEmail.Text);
                        cmd.Parameters.AddWithValue("ptelefon", txtRegisterTel.Text);

                        //Se executa comanda si se verifica daca rezultatul este nenul
                        if (cmd.ExecuteNonQuery() != 0)

                        {
                            MessageBox.Show("Datele au fost adaugate!", "Baze de date",
                                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Datele nu au fost adaugate!", "Baze de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        connection.Close();
                  
                  

                }
                catch
                {
                    MessageBox.Show("Database error!", "Baze de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                pbSlider.Visible = true;
                pnlLogin.Visible = true;
                pnlRegister.Visible = false;
                txtEmail.Text = txtRegisterEmail.Text;
                txtParola.Text = txtRegisterParola.Text;
                txtParola.PasswordChar = '*';
                timerSlider.Start();
                registerPanelReset();
            }
            else
            {
                MessageBox.Show("Date Invalide");
            }
        

        }

        private void txtRegisterNume_TextChanged(object sender, EventArgs e)
        {
            if (txtRegisterNume.TextLength < 2)
            {
                lblRegisterNume.ForeColor = Color.Red;
                regN = false;
            }
            else
            {
                lblRegisterNume.ForeColor = Color.LightGreen;
                regN = true;
            }
        }

        private void btnRegisterCancel_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = false;
            pbSlider.Visible = true;
            pnlLogin.Visible = true;
            timerSlider.Start();
            registerPanelReset();
        }

        private void txtParola_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode==Keys.Enter)
            {
                UserLogin();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if(txtParola.Text=="Parola")
                 {
                txtParola.Clear();
                 }
                txtParola.Select();
                txtParola.PasswordChar = '*';
            }    
        }

        private void txtRegisterPrenume_TextChanged(object sender, EventArgs e)
        {
            if (txtRegisterPrenume.TextLength < 2)
            {
                lblRegisterPrenume.ForeColor = Color.Red;
                regPren = false;
            }
            else
            {
                lblRegisterPrenume.ForeColor = Color.LightGreen;
                regPren = true;
            }
        }
        bool isEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void txtRegisterEmail_TextChanged(object sender, EventArgs e)
        {

            if (txtRegisterEmail.TextLength < 8 || isEmail(txtRegisterEmail.Text) == false)
            {
                lblRegisterEmail.ForeColor = Color.Red;
                regE = false;
            }
            else
            {
                lblRegisterEmail.ForeColor = Color.LightGreen;
                regE = true;
            }
        }
    }
}
