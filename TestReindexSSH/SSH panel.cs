// Renci is voor de .net functies
using Renci.SshNet;
using System;
using System.Drawing;
using System.Text;

// voor de output reader
using System.IO;
using System.Windows.Forms;

namespace TestReindexSSH
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string host ;
        string password ;
        string username ;
        int port = 22;

        private Point lastLocation;

        private bool mouseDown;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            check_data();
        }

       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            host = txtBoxServerAddress.Text;
            username = txtBoxUsername.Text;
            password = txtBoxPass.Text;

            SSH.connect(host, port, username, password);

            if (SSH.client.IsConnected)
            {
                lblConnection.Text = "Status : Verbonden";
                lblConnection.ForeColor = Color.Green;
                pnlIndex.Show();
                txtBoxUsername.Enabled = false;
                txtBoxPass.Enabled = false;
                txtBoxServerAddress.Enabled = false;
                btnLogin.Enabled = false;
                btnReindexShow.Enabled = true;
                btnOverig.Enabled = true;
            }
            else
            {
                lblConnection.Text = "Status : Niet verbonden";
                lblConnection.ForeColor = Color.Red;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SSH.disconnect();

            lblConnection.Text = "Status : Niet verbonden";
            lblConnection.ForeColor = Color.Red;

            txtBoxUsername.Enabled = true;
            txtBoxPass.Enabled = true;
            txtBoxServerAddress.Enabled = true;
            btnLogin.Enabled = true;
            pnlIndex.Visible = false;
        }

        /* kijkt of de gebruikersgegevens zijn opgeslagen
         als het true is, haalt hij de vorige gegevens op en zet hij ze in de textboxes.
         Zoniet, dan leegt hij die en zet hij de checkbox op false
          */
        private void check_data()
        {
            if (Properties.Creditals.Default.rememberme == true)
            {
                txtBoxServerAddress.Text = Properties.Creditals.Default.host;
                txtBoxUsername.Text = Properties.Creditals.Default.gebruikersnaam;
                txtBoxPass.Text = Properties.Creditals.Default.wachtwoord;
                cBoxRememberMe.Checked = true;
            }
            if (Properties.Creditals.Default.rememberme == false)
            {
                Properties.Creditals.Default.host = "";
                Properties.Creditals.Default.gebruikersnaam = "";
                Properties.Creditals.Default.wachtwoord = "";
                cBoxRememberMe.Checked = false;
            }
        }
        // Als de checkbox word aangevinked slaat hij de data op.
        private void opgeslagen_data()
        {
            if (cBoxRememberMe.Checked)
            {
                Properties.Creditals.Default.host = txtBoxServerAddress.Text;
                Properties.Creditals.Default.gebruikersnaam = txtBoxUsername.Text;
                Properties.Creditals.Default.wachtwoord = txtBoxPass.Text;
            }
            Properties.Creditals.Default.rememberme = cBoxRememberMe.Checked;
            Properties.Creditals.Default.Save();
        }

        // leegt txtOutput en voert het commando aan en zet de backgroundworker aan.
        private void btnUitvoeren_Click(object sender, EventArgs e)
        {
            DisableButtons();
            rTxtBoxOutput.Text = "";
            backgroundWorker.RunWorkerAsync();

            lblStatus.Text = "Process is bezig... een moment geduld aub";
            lblStatus.ForeColor = Color.Orange;
        }

        // stuurt de commando 
        public void ExecuteCommand()
        {
            var cmd = SSH.client.CreateCommand(txtBoxInput.Text);
            var result = cmd.Execute();
            backgroundWorker.ReportProgress(0, result);
            
                    using (var reader = new StreamReader(cmd.ExtendedOutputStream))
                    // rTxtBoxOutput.Text += "\n" + reader.ReadToEnd();
                    backgroundWorker.ReportProgress(0, reader.ReadToEnd());
    }

        public void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ExecuteCommand();
           
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            rTxtBoxOutput.Text += e.UserState;
        }

        // Zet alle knoppen aan
        private void EnableButtons()
        {
            foreach (Control item in pnlIndex.Controls)
            {
                item.Enabled = true;
            }
        }

        // Zet alle knoppen uit
        private void DisableButtons()
        {
            foreach (Control item in pnlIndex.Controls)
            {
                item.Enabled = false;
            }
        }



        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            EnableButtons();

            lblStatus.Text = "Process Compleet";
            lblStatus.ForeColor = Color.Green;
        }

        #region commmands

        private void btnProductAttribuut_Click(object sender, EventArgs e)
        {
             txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex cataloginventory_stock";
        }

        private void btnReindexAll_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "php -f questcontrol.net/shell/indexer.php reindexall";
        }

        private void btnReindexCatalogSearchFullText_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex catalogsearch_fulltext";
        }

        private void btnReindexCatalogUrl_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex catalog_url";
        }

        private void btnReindexCategory_Flat_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex catalog_category_flat";
        }

        private void btnReindexCategory_product_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex catalog_category_product";
        }

        private void btnReindexProduct_Flat_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex catalog_product_flat";
        }

        private void btnReindexProduct_price_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex catalog_product_price";
        }

        private void btnReindexProduct_url_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex catalog_url";
        }

        private void btnReindexStock_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "php questcontrol.net/shell/indexer.php -- -reindex cataloginventory_stock";
        }

        #endregion commands

        private void btnReindexShow_Click(object sender, EventArgs e)
        {
            //komt later
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            try
            {
                SSH.disconnect();
            }
            catch { }
            opgeslagen_data();
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        
        private void lblMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /*       private void countdown()
              {
                  int timer = 0;
                  timer++;
                  lblTimerTick.Text = timer.ToString() + "seconden bezig";
              }                                                                   */

        private void btnOverig_Click(object sender, EventArgs e)
        {
            // rTxtBoxOutput.Refresh(); werkt ook niet
        }

       
    }
}