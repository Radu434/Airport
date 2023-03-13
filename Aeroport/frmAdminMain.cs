using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AeroportV1
{
    public partial class frmAdminMain : Form
    {
        ToolTip toolTip = new ToolTip();
        bool mouseDown = false;
        static Point lastLocation;
        public int nrDest;
        int selectedDestId = 0;
        public int nrZboruri;
        int selectedZborId =0;
        public Destinatie[] destinatie = new Destinatie[500];
        public Zbor[] zbor = new Zbor[500];

        public Form refToFrmMain { get; set; }
        public frmAdminMain()
        {
            InitializeComponent();
            dtPickerAdaugareZbor.MinDate = DateTime.Now;
            dtPickerAdaugareZbor.Value = DateTime.Now;
            dtPickerZborModificaData.MinDate = DateTime.Now;
            dtPickerZborModificaData.Value = DateTime.Now;
     

        }
       public void CautareDestinatii()
        {
            for(int i=1;i<=nrDest;i++)
            {
                if(!comboBoxCautareOras.Items.Contains(destinatie[i].oras))
                {
                comboBoxCautareOras.Items.Add(destinatie[i].oras);

                }
                if (!comboBoxCautareTara.Items.Contains(destinatie[i].tara))
                {  
                    comboBoxCautareTara.Items.Add(destinatie[i].tara);
                }
                comboBoxCautareAeroport.Items.Add(destinatie[i].aeroport);
                cbZborAdaugareAeroport.Items.Add(destinatie[i].aeroport);
                cbZborModificareAeroport.Items.Add(destinatie[i].aeroport);

            }
           
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
            if(mouseDown==true)
            {
                frmAdminMain.ActiveForm.Location = new Point((frmAdminMain.ActiveForm.Location.X - lastLocation.X)+e.X, (frmAdminMain.ActiveForm.Location.Y - lastLocation.Y)+e.Y);
               
            }
            this.Update();
        }

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
          
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            this.refToFrmMain.Show();     
            this.Hide();
        }

        private void frmAdminMain_Paint(object sender, PaintEventArgs e)
        {
            Pen bluePen = new Pen(Color.DodgerBlue);
            bluePen.Width = 1.00F;
            e.Graphics.DrawRectangle(bluePen, new Rectangle(0, 0, ((frmAdminMain)sender).Width-1 , ((frmAdminMain)sender).Height -1));
           
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


      public  async void DownloadDestination()
        {
            nrDest = 0;
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=aeroport; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                MySqlCommand cmd = new MySqlCommand();//Se creaza comanda
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT MAX(idd) FROM destinatie";
                connection.Open();

                MySqlDataReader oReader = cmd.ExecuteReader();
                oReader.Read();
                nrDest = (Int32)oReader[0];

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Databese Error");
            }
            if (nrDest > 0)
            {
                
                for (int i = 1; i <= nrDest; i++)
                {
                    MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString = @"SERVER=localhost; DATABASE=aeroport; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                    MySqlCommand cmd = new MySqlCommand();//Se creaza comanda
                    cmd.Connection = connection;
                    cmd.CommandText = @"SELECT * FROM destinatie WHERE idd LIKE " + i.ToString();
                    connection.Open();

                    MySqlDataReader oReader = cmd.ExecuteReader();
                    while (oReader.Read())
                    {

                        DeclareDestination((Int32)oReader["idd"], oReader["oras"].ToString(), oReader["tara"].ToString(), oReader["aeroport"].ToString());
                    }
                    connection.Close();
                }
            }
        }
        public async void DownloadZbor()
        {
            nrZboruri = 0;
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=aeroport; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                MySqlCommand cmd = new MySqlCommand();//Se creaza comanda
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT MAX(idz) FROM zbor";
                connection.Open();

                MySqlDataReader oReader = cmd.ExecuteReader();
                oReader.Read();
                nrZboruri = (Int32)oReader[0];

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Databese Error");
            }
            if (nrDest > 0)
            {

                for (int i = 1; i <= nrZboruri; i++)
                {
                    MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString = @"SERVER=localhost; DATABASE=aeroport; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                    MySqlCommand cmd = new MySqlCommand();//Se creaza comanda
                    cmd.Connection = connection;
                    cmd.CommandText = @"SELECT * FROM zbor WHERE idz LIKE " + i.ToString();
                    connection.Open();

                    MySqlDataReader oReader = cmd.ExecuteReader();
                    while (oReader.Read())
                    {

                        DeclareZbor((Int32)oReader["idz"], (Int32)oReader["idd"], (Int32)oReader["pret"], oReader["companie"].ToString(), oReader["durata"].ToString(), (DateTime)oReader["data_decolare"]);
                    }
                    connection.Close();
                }
                
            }
        }
        public void DeclareDestination(int x, string o, string t, string a)
        {
            destinatie[x] = new Destinatie();
           destinatie[x].idd = x;
            destinatie[x].oras = o;
            destinatie[x].tara = t;
            destinatie[x].aeroport = a;
        }
        public void DeclareZbor(int idz, int idd, int pret, string companie, string durata, DateTime data )
        {
            zbor[idz] = new Zbor();
            zbor[idz].idz = idz;
            zbor[idz].idd = idd;
            zbor[idz].companie = companie;
            zbor[idz].data = data;
            zbor[idz].pret = pret;
            zbor[idz].durata = durata;
        }






        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDestinatieInserare_Click(object sender, EventArgs e)
        {
            if (txtBoxDestinatiiAdaugaAeroport.Text !=""&&txtBoxDestinatiiAdaugaOras.Text!=""&&txtBoxDestinatiiAdaugaTara.Text!="")
            {
                try
                {



                    MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString = @"SERVER=localhost; DATABASE=aeroport; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand();//Se creaza comanda
                    cmd.Connection = connection;
                    cmd.CommandText = @"INSERT INTO destinatie(oras, tara, aeroport)
                                           VALUES(@poras, @ptara, @paeroport);";

                    cmd.Parameters.AddWithValue("poras", txtBoxDestinatiiAdaugaOras.Text);
                    cmd.Parameters.AddWithValue("ptara", txtBoxDestinatiiAdaugaTara.Text);
                    cmd.Parameters.AddWithValue("paeroport", txtBoxDestinatiiAdaugaAeroport.Text);


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
                    DownloadDestination();
                    CautareDestinatii();
                    txtBoxDestinatiiAdaugaAeroport.Clear();
                    txtBoxDestinatiiAdaugaOras.Clear();
                    txtBoxDestinatiiAdaugaTara.Clear();
                }
                catch
                {
                    MessageBox.Show("Databese Error");
                }
            }
            else
            {
                MessageBox.Show("Date invalide");
            }
        }
        

        private void comboBoxOras_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCautareAeroport.Items.Clear();
            int aux = 0;
            for (int i = 1; i <= nrDest; i++)
            {

                if (destinatie[i].oras.ToString() == comboBoxCautareOras.SelectedItem.ToString() && !comboBoxCautareOras.Items.Contains(destinatie[i].aeroport))
                {
                    aux = i;
                    comboBoxCautareAeroport.Items.Add(destinatie[i].aeroport);
                    comboBoxCautareAeroport.SelectedItem = destinatie[i].aeroport;
                }

            }

            comboBoxCautareTara.SelectedItem = destinatie[aux].tara;
        }

        private void comboBoxOras_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
           


        }

        private void comboBoxCautareTara_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxCautareTara_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxCautareAeroport.Items.Clear();
            comboBoxCautareOras.Items.Clear();

            for (int i = 1; i <= nrDest; i++)
            {

                if (destinatie[i].tara.ToString() == comboBoxCautareTara.SelectedItem.ToString())
                {

                    if (!comboBoxCautareOras.Items.Contains(destinatie[i].aeroport))
                    {
                        comboBoxCautareAeroport.Items.Add(destinatie[i].aeroport);

                        comboBoxCautareAeroport.SelectedItem = destinatie[i].aeroport;

                    }
                    if (!comboBoxCautareOras.Items.Contains(destinatie[i].oras))
                    {

                        comboBoxCautareOras.Items.Add(destinatie[i].oras);
                        comboBoxCautareOras.SelectedItem = destinatie[i].oras;
                    }
                }

            }


        }

        private void btnCautaDestinatia_Click(object sender, EventArgs e)
        {
            if(comboBoxCautareAeroport.SelectedItem!=null&&comboBoxCautareOras.SelectedItem!=null)
            {

            for (int i = 1; i <= nrDest; i++)
            {
                if(destinatie[i].aeroport == comboBoxCautareAeroport.SelectedItem)
                {
                        //pnlDestinatiiCauta.Visible = false;
                        
                        selectedDestId = destinatie[i].idd;
                        pnlDestinatieModificare.Enabled = true;
                        pnlDestinatieModificare.Visible = true;
                        txtDestinatiiModificareTara.Text = destinatie[selectedDestId].tara;
                        txtDestinatiiModificareOras.Text = destinatie[selectedDestId].oras;
                        txtDestinatiiModificareAeroport.Text = destinatie[selectedDestId].aeroport;

                        break;
                }
            }
            }
            else
            {
                MessageBox.Show("Selecteaza o destinatie");
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
                introduce.CommandText = @"UPDATE destinatie SET " + tip + "=@Data WHERE idd = @Idd";
               // "UPDATE `destinatie` SET `oras` = 'Cluj-Napoca' WHERE `destinatie`.`idd` = 6; "
                introduce.Parameters.AddWithValue("@Data", data);
                introduce.Parameters.AddWithValue("@Idd", selectedDestId.ToString());

                connection.Open();
                introduce.ExecuteNonQuery();

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Database error!", "Baze de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDestinatieModifica_Click(object sender, EventArgs e)
        {
          
            ModifyData("oras", txtDestinatiiModificareOras.Text);
            ModifyData("tara", txtDestinatiiModificareTara.Text);
            ModifyData("aeroport", txtDestinatiiModificareAeroport.Text);
            comboBoxCautareTara.Items.Clear();
            comboBoxCautareOras.Items.Clear();
            comboBoxCautareAeroport.Items.Clear();
            DownloadDestination();
            CautareDestinatii();
            txtDestinatiiModificareAeroport.Text = destinatie[selectedDestId].aeroport;
            txtDestinatiiModificareOras.Text = destinatie[selectedDestId].oras;
            txtDestinatiiModificareTara.Text = destinatie[selectedDestId].tara;
            comboBoxCautareOras.SelectedItem = txtDestinatiiModificareOras.Text;
            
            comboBoxCautareTara.SelectedItem = txtDestinatiiModificareTara;
        }

        private void btnDestinatieStergere_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=aeroport; 
                                               UID=root; PASSWORD=; Allow User Variables=True";

                MySqlCommand delete = new MySqlCommand();
                delete.Connection = connection;
                delete.CommandText = @"DELETE FROM destinatie WHERE idd = @Idd";
                // "UPDATE `destinatie` SET `oras` = 'Cluj-Napoca' WHERE `destinatie`.`idd` = 6; "
                
                delete.Parameters.AddWithValue("@Idd", selectedDestId.ToString());

                connection.Open();
                delete.ExecuteNonQuery();
                delete.CommandText = "ALTER TABLE destinatie AUTO_INCREMENT = 1";
                delete.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Database error!", "Baze de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtDestinatiiModificareAeroport.Text ="";
            txtDestinatiiModificareOras.Text = "";
            txtDestinatiiModificareTara.Text = "";
            comboBoxCautareTara.Items.Clear();
            comboBoxCautareOras.Items.Clear();
            comboBoxCautareAeroport.Items.Clear();
            comboBoxCautareTara.Text="";
            comboBoxCautareOras.Text = "";
            comboBoxCautareAeroport.Text = "";
            DownloadDestination();
            CautareDestinatii();
            selectedDestId = 0;
            pnlDestinatieModificare.Visible = false;
            MessageBox.Show("Destinatie stearsa cu succes");
        }

        private void btnDestinatii_Click(object sender, EventArgs e)
        {
            pnlZboruri.Dock = DockStyle.None;
            pnlZboruri.Visible = false;
            pnlDestinatii.Visible = true;
            pnlDestinatii.Dock = DockStyle.Fill;
        }
        public void CautareZboruri()
        {
            for (int i = 1; i <= nrZboruri; i++)
            {
                if (!cbZborCautaCompanie.Items.Contains(zbor[i].companie))
                {
                    cbZborCautaCompanie.Items.Add(zbor[i].companie);
                }
            
            }
        }
        private void btnZborAdauga_Click(object sender, EventArgs e)
        {
            if (cbZborAdaugareAeroport.Text != ""&&txtZborAdaugaCompanie.Text != ""&&txtZborAdaugaDurata.Text != ""&&txtZborAdaugaPret.Text != "")
            {
                int iddLocal = 0;
                for (int q = 1; q <= nrDest; q++)
                {
                    if(destinatie[q].aeroport==cbZborAdaugareAeroport.SelectedItem)
                    {
                        iddLocal = q;
                    }
 
                }
                try
                {



                    MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString = @"SERVER=localhost; DATABASE=aeroport; 
                                               UID=root; PASSWORD=; Allow User Variables=True";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand();//Se creaza comanda
                    cmd.Connection = connection;
                    cmd.CommandText = @"INSERT INTO zbor(companie, idd, durata,data_decolare,pret)
                                           VALUES(@pcompanie, @pidd, @pdurata, @pdata_decolare, @ppret);";

                    cmd.Parameters.AddWithValue("pcompanie", txtZborAdaugaCompanie.Text);        
                    cmd.Parameters.AddWithValue("pdurata", txtZborAdaugaDurata.Text);
                    cmd.Parameters.AddWithValue("pdata_decolare", dtPickerAdaugareZbor.Value);
                    cmd.Parameters.AddWithValue("ppret", Int32.Parse( txtZborAdaugaPret.Text));
                    cmd.Parameters.AddWithValue("pidd", iddLocal); 
                    

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
                    DownloadZbor();
                    CautareZboruri();
                    CautareDestinatii();
                    
                    
                    txtZborAdaugaCompanie.Clear();
                    txtZborAdaugaDurata.Clear();
                    txtZborAdaugaPret.Clear();
                }
                catch
                {
                    MessageBox.Show("Databese Error");
                }
            }
            else
            {
                MessageBox.Show("Date invalide");
            }
        }

        private void btnZboruri_Click(object sender, EventArgs e)
        {
            pnlZboruri.Dock = DockStyle.Fill;
            pnlZboruri.Visible = true;
            pnlDestinatii.Visible = false;
            pnlDestinatii.Dock = DockStyle.None;
        }

        private void btnZborCauta_Click(object sender, EventArgs e)
        {
            dgvZbor.Rows.Clear();
            for(int i=1;i<=nrZboruri;i++)
            {
                int idd = zbor[i].idd;
               
                if(zbor[i].companie.ToString()==cbZborCautaCompanie.SelectedItem.ToString()&&destinatie[idd].aeroport.ToString()==cbZborCautaAeroport.SelectedItem.ToString())
                {
                    int iddd = zbor[i].idd;
                    string aer = destinatie[idd].aeroport.ToString();
                    dgvZbor.ColumnCount = 6;
                    dgvZbor.Columns[0].Name = "idz";
                    dgvZbor.Columns[1].Name = "Companie";
                    dgvZbor.Columns[2].Name = "Aeroport";
                    dgvZbor.Columns[3].Name = "Data_Decolare";
                    dgvZbor.Columns[4].Name = "Pret";
                    dgvZbor.Columns[5].Name = "Durata";
                    dgvZbor.Rows.Add(zbor[i].idz.ToString(), zbor[i].companie.ToString(), aer, zbor[i].data.ToString(), zbor[i].pret.ToString()+ "euro", zbor[i].durata.ToString()+" ore");
                    
                }
            }
        }

        private void cbZborCautaCompanie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbZborCautaAeroport.Items.Clear();
            int c = 1;
            for(int i=1;i<=nrZboruri;i++)
            {
                if(zbor[i].companie.ToString()==cbZborCautaCompanie.SelectedItem.ToString())
                {
                     c = zbor[i].idd; 
                    if(!cbZborCautaAeroport.Items.Contains(destinatie[c].aeroport))
                    {
                    cbZborCautaAeroport.Items.Add(destinatie[c].aeroport);

                    }
                }
            }
                    cbZborCautaAeroport.SelectedItem = destinatie[c].aeroport;
        }

        private void cbZborCautaAeroport_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

    

        private void btnZborIncepeModificare_Click_1(object sender, EventArgs e)
        {
            
            pnlZborModificare.Visible = true;
            
            selectedZborId =Int32.Parse( dgvZbor.SelectedRows[0].Cells[0].Value.ToString());
            txtZborModificaCompanie.Text = zbor[selectedZborId].companie;
            txtZborModificaDurata.Text = zbor[selectedZborId].durata;
            txtZborModificaPret.Text = zbor[selectedZborId].pret.ToString();
            dtPickerZborModificaData.Value = zbor[selectedZborId].data;

        }

        private void btnZborSterge_Click(object sender, EventArgs e)
        {
            selectedZborId = Int32.Parse(dgvZbor.SelectedRows[0].Cells[0].Value.ToString());
            try
            {

                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=aeroport; 
                                               UID=root; PASSWORD=; Allow User Variables=True";

                MySqlCommand delete = new MySqlCommand();
                delete.Connection = connection;
                delete.CommandText = @"DELETE FROM zbor WHERE idz = @Idz";
                // "UPDATE `destinatie` SET `oras` = 'Cluj-Napoca' WHERE `destinatie`.`idd` = 6; "

                delete.Parameters.AddWithValue("@Idz", selectedZborId);
                MessageBox.Show(selectedZborId.ToString());

                connection.Open();
                delete.ExecuteNonQuery();
                delete.CommandText = "ALTER TABLE zbor AUTO_INCREMENT = 1";
                delete.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Database error!", "Baze de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pnlZborModificare.Visible = false;
            DownloadDestination();
            CautareDestinatii();
            DownloadZbor();
            CautareZboruri();
            selectedZborId = 0;
            MessageBox.Show("Zbor sters cu succes");
        }

        private void btnZborModifica_Click(object sender, EventArgs e)
        {
            selectedZborId = Int32.Parse(dgvZbor.SelectedRows[0].Cells[0].Value.ToString());
            int iddAici = 0;
            for(int i=1;i<=nrDest;i++)
            {
                if(cbZborModificareAeroport.SelectedItem.ToString()==destinatie[i].aeroport.ToString())
                {
                    iddAici = i;
                }
            }
            MessageBox.Show(iddAici.ToString());
            try
            {

                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=aeroport; 
                                               UID=root; PASSWORD=; Allow User Variables=True";

                MySqlCommand introduce = new MySqlCommand();
                introduce.Connection = connection;
                introduce.CommandText = @"UPDATE zbor SET  companie=@Companie, idd=@Idd, data_decolare=@Data_decolare,pret=@Pret,durata=@Durata WHERE idz = @Idz";
                
                introduce.Parameters.AddWithValue("@Idz", selectedZborId.ToString());
                introduce.Parameters.AddWithValue("@Companie",txtZborModificaCompanie.Text);
                introduce.Parameters.AddWithValue("@Idd" , iddAici.ToString());
                introduce.Parameters.AddWithValue("@Data_decolare" ,dtPickerZborModificaData.Value);
                introduce.Parameters.AddWithValue("@Pret" , txtZborModificaPret.Text);
                introduce.Parameters.AddWithValue("@Durata" , txtZborModificaDurata.Text);

                
                connection.Open();
                introduce.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Zbor modificat cu succes");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Baze de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pnlZborModificare.Visible = false;
            DownloadDestination();
            CautareDestinatii();
            DownloadZbor();
            CautareZboruri();
            selectedZborId = 0;

        }

        private void pnlZboruri_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
