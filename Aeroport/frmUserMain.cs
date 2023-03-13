using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AeroportV1
{
    public partial class frmUserMain : Form
    {
        public Utilizator utilizator = new Utilizator();
        ToolTip toolTip = new ToolTip();
        bool mouseDown = false;
        frmAdminMain frmAdm = new frmAdminMain();



        static Point lastLocation;
        public Form refToFrmMain { get; set; }
  
        public frmUserMain()
        {
            
            InitializeComponent();
     
        }
    
      
        public void PassUserData()
        {
            linkLblCont.Text = "Cont Conectat " + utilizator.email.ToString();
            
            
        }
        private void frmUserMain_Load(object sender, EventArgs e)
        {
            txtContNume.Text = utilizator.nume;
            txtContPrenume.Text = utilizator.prenume;
            txtContEmail.Text = utilizator.email;
            txtContTelefon.Text = utilizator.telefon;
            CautaZborUser();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            frmMain.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void pnlTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnlTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                frmAdminMain.ActiveForm.Location = new Point((frmAdminMain.ActiveForm.Location.X - lastLocation.X) + e.X, (frmAdminMain.ActiveForm.Location.Y - lastLocation.Y) + e.Y);

            }
            this.Update();
        }
        void UpdateLocalUserData()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=aeroport; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"select * FROM clienti WHERE idc LIKE @Idc";
                cmd.Parameters.AddWithValue("@Idc", utilizator.idc);
                MySqlDataReader oReader = cmd.ExecuteReader();

              
                while (oReader.Read())
                {

                    utilizator.parola = oReader["parola"].ToString();
                    utilizator.email = oReader["email"].ToString();
                    utilizator.nume = oReader["nume"].ToString();
                    utilizator.prenume = oReader["prenume"].ToString();
                    utilizator.telefon = oReader["telefon"].ToString();

                 PassUserData();
              

                

                }
             


                connection.Close();

                
            }
            catch
            {
                MessageBox.Show("Database error");

            }
        }

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

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

        private void ModifyData(string tip, string data)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=aeroport; 
                                               UID=root; PASSWORD=; Allow User Variables=True";

                MySqlCommand introduce = new MySqlCommand();
                introduce.Connection = connection;
                introduce.CommandText = @"UPDATE clienti SET "+tip+"=@Data WHERE idc = @Idc";
                introduce.Parameters.AddWithValue("@Data", data);
                introduce.Parameters.AddWithValue("@Idc", utilizator.idc);
      
                connection.Open();
                introduce.ExecuteNonQuery();

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Database error!", "Baze de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            this.refToFrmMain.Show();
            this.Hide();
        }
        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.btnLogout, "Log out");
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.btnMinimize, "Minimize");
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.btnExit, "Inchide");

        }

        private void pnlToolbar_MouseEnter(object sender, EventArgs e)
        {
            toolbarOpen();
        }
        void toolbarOpen()
        {
            pictureBox1.Visible = false;
            btnCont.Visible = true;
            btnIstoric.Visible = true;
            btnZboruri.Visible = true;
            pnlToolbar.Height = 104;
        }
        void toolbarClose()
        {
            pictureBox1.Visible = true;
            btnCont.Visible = false;
            btnIstoric.Visible = false;
            btnZboruri.Visible = false;
            pnlToolbar.Height = 43;
        }
       private bool mouseInControl(Control control)
        {
            return control.ClientRectangle.Contains(control.PointToClient(Cursor.Position));
        }
        private void pnlToolbar_MouseLeave(object sender, EventArgs e)
        {
          if(mouseInControl(pnlToolbar)==false)
            {
                toolbarClose();
            }

        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            pnlZboruri.Visible = false;
            pnlIdtoricCont.Visible = false;
            txtContNume.Text = utilizator.nume;
            txtContPrenume.Text = utilizator.prenume;
            txtContEmail.Text = utilizator.email;
            txtContTelefon.Text = utilizator.telefon;
            pnlCont.Visible = true;
            pnlCont.Dock = DockStyle.Fill;
            
        }

        private void btnContActualizareDate_Click(object sender, EventArgs e)
        {
            bool aux = false;
            if(txtContNume.Text.Length>=2)
            {
            ModifyData("nume", txtContNume.Text);
                aux = true;
            }
            if (txtContEmail.Text.Length >= 6&&isEmail(txtContEmail.Text)==true)
            {
                ModifyData("email", txtContEmail.Text);
                aux = true;
            }
            if (txtContPrenume.Text.Length >= 2)
            {
                ModifyData("prenume", txtContPrenume.Text);
                aux = true;
            }
            if(txtContTelefon.Text.Length>=10)
            {
                ModifyData("telefon", txtContTelefon.Text);
                    aux = true;
            }
            if(aux==true)
            {
                MessageBox.Show("Datele au fost modificate cu succes");
            }
            else
            {
                MessageBox.Show("Datele introduse sunt invalide");
            }
            UpdateLocalUserData();
            txtContEmail.Text = utilizator.email;
            txtContNume.Text = utilizator.nume;
            txtContPrenume.Text = utilizator.prenume;
            txtContTelefon.Text = utilizator.telefon;
          
        }

        private void btnContSchimbaParola_Click(object sender, EventArgs e)
        {
            if(txtContOldPass.Text==utilizator.parola&&txtContNewPass.Text.Length>=8)
            {
                ModifyData("parola", txtContNewPass.Text);
                UpdateLocalUserData();
                MessageBox.Show("Parola a fost modificata");
            }
            else
            {
                MessageBox.Show("Date invalide");
            }
        }
       public void CautaZborUser()
        {
           
            for (int i = 1; i <= frmAdm.nrZboruri; i++)
            {
                if (!cbZborCautaCompanie.Items.Contains(frmAdm.zbor[i].companie))
                {
                    cbZborCautaCompanie.Items.Add(frmAdm.zbor[i].companie);
                }

            }
        }
        private void btnZboruri_Click(object sender, EventArgs e)
        {
            pnlZboruri.Visible = true;
            pnlCont.Visible = false;
            pnlIdtoricCont.Visible = false;
            pnlZboruri.Dock = DockStyle.Fill;
            pnlCont.Visible = false;
            frmAdm.DownloadDestination();
            frmAdm.DownloadZbor();
            CautaZborUser();
        }

        private void linkLblCont_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void cbZborCautaCompanie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbZborCautaAeroport.Items.Clear();
            int c = 1;
            for (int i = 1; i <= frmAdm.nrZboruri; i++)
            {
                if (frmAdm.zbor[i].companie.ToString() == cbZborCautaCompanie.SelectedItem.ToString())
                {
                    c = frmAdm.zbor[i].idd;
                    if (!cbZborCautaAeroport.Items.Contains(frmAdm.destinatie[c].aeroport))
                    {
                        cbZborCautaAeroport.Items.Add(frmAdm.destinatie[c].aeroport);

                    }
                }
            }
            cbZborCautaAeroport.SelectedItem = frmAdm.destinatie[c].aeroport;
        }

        private void btnZborCauta_Click(object sender, EventArgs e)
        {
            dgvZbor.Rows.Clear();
            for (int i = 1; i <= frmAdm.nrZboruri; i++)
            {
                int idd = frmAdm.zbor[i].idd;

                if (frmAdm.zbor[i].companie.ToString() == cbZborCautaCompanie.SelectedItem.ToString() && frmAdm.destinatie[idd].aeroport.ToString() == cbZborCautaAeroport.SelectedItem.ToString())
                {
                    int iddd = frmAdm.zbor[i].idd;
                    string aer = frmAdm.destinatie[idd].aeroport.ToString();
                    dgvZbor.ColumnCount = 6;
                    dgvZbor.Columns[0].Name = "idz";
                    dgvZbor.Columns[1].Name = "Companie";
                    dgvZbor.Columns[2].Name = "Aeroport";
                    dgvZbor.Columns[3].Name = "Data_Decolare";
                    dgvZbor.Columns[4].Name = "Pret";
                    dgvZbor.Columns[5].Name = "Durata";
                    dgvZbor.Rows.Add(frmAdm.zbor[i].idz.ToString(), frmAdm.zbor[i].companie.ToString(), aer, frmAdm.zbor[i].data.ToString(), frmAdm.zbor[i].pret.ToString() + "euro", frmAdm.zbor[i].durata.ToString() + " ore");

                }
            }
        }
        private void DownloadBilete()
        {
            int idzL=0;
            int totalBani = 0;
            string aeroportL="", orasL = "", taraL = "", durataL = "", pretL = "", companieL = "";
            DateTime dataDecolare=DateTime.MinValue;
            dgvIstoricCont.ColumnCount = 8;
            dgvIstoricCont.Columns[0].Name = "idb";
            dgvIstoricCont.Columns[1].Name = "Aeroport";
            dgvIstoricCont.Columns[2].Name = "Companie";
            dgvIstoricCont.Columns[3].Name = "Oras";
            dgvIstoricCont.Columns[4].Name = "Tara";
            dgvIstoricCont.Columns[5].Name = "Durata";
            dgvIstoricCont.Columns[6].Name = "Data_Decolare";
            dgvIstoricCont.Columns[7].Name = "Pret";
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=aeroport; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"select * FROM bilet WHERE idc LIKE @Idc";
                cmd.Parameters.AddWithValue("@Idc", utilizator.idc);
                MySqlDataReader oReader = cmd.ExecuteReader();


                while (oReader.Read())
                {
                    idzL = (Int32)oReader["idz"];
                    
                    pretL = frmAdm.zbor[idzL].pret.ToString();
                    totalBani += frmAdm.zbor[idzL].pret;

                    durataL = frmAdm.zbor[idzL].durata.ToString();
                    companieL = frmAdm.zbor[idzL].companie.ToString();
                    dataDecolare = frmAdm.zbor[idzL].data;



                    for (int i=1;i<=frmAdm.nrDest;i++)
                    {
                       if(frmAdm.destinatie[i].idd==frmAdm.zbor[idzL].idd)
                        {
                            orasL = frmAdm.destinatie[i].oras;
                            aeroportL = frmAdm.destinatie[i].aeroport;
                            taraL = frmAdm.destinatie[i].tara;
                        }

                    }
                    dgvIstoricCont.Rows.Add(oReader["idb"].ToString(),aeroportL,companieL,orasL,taraL,durataL+" ore",dataDecolare.ToString(),pretL);
                }


                lblContTotalBani.Text = "Total suma cheltuita pe cont: " + totalBani.ToString()+" euro";
                connection.Close();


            }
            catch
            {
                MessageBox.Show("Database error");

            }
        }

        private void btnCumparaBilet_Click(object sender, EventArgs e)
        {
            int idz = Int32.Parse(dgvZbor.SelectedRows[0].Cells[0].Value.ToString());
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=aeroport; 
                                               UID=root; PASSWORD=; Allow User Variables=True";

                MySqlCommand introduce = new MySqlCommand();
                introduce.Connection = connection;
                introduce.CommandText = @"INSERT INTO bilet SET idc=@Idc, idz=@Idz ";
                introduce.Parameters.AddWithValue("@Idz", idz);
                introduce.Parameters.AddWithValue("@Idc", utilizator.idc);

                connection.Open();
                introduce.ExecuteNonQuery();

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Database error!", "Baze de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Bilet cumparat cu succes!");
        }

        private void btnIstoric_Click(object sender, EventArgs e)
        {
            dgvIstoricCont.Rows.Clear();
            pnlCont.Visible = false;
            pnlZboruri.Visible = false;
            frmAdm.DownloadDestination();
            frmAdm.DownloadZbor();
            DownloadBilete();
            pnlIdtoricCont.Visible = true;
            pnlIdtoricCont.Dock = DockStyle.Fill;
        }
    }
}
