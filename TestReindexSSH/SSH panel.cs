// Renci is voor de .net functies
using Renci.SshNet;

using System;
using System.Drawing;
using System.Windows.Forms;

// voor de output reader
using System.IO;


namespace TestReindexSSH
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private static string host = "";
        private static string password = "";
        private static string username = "";
        private SshClient client;


        private Point lastLocation;

        private bool mouseDown;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pnlIndex.Hide();
            check_data();
        }

        private void setSsh()
        {
            host = txtBoxServerAddress.Text;
            username = txtBoxUsername.Text;
            password = txtBoxPass.Text;
            client = new SshClient(host, username, password);
        }
        // checkt
        private void btnLogin_Click(object sender, EventArgs e)
        {
            setSsh();
            try
            {
                client.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("De inloggegevens zijn mogelijk verkeerd, probeer het opnieuw" + ex.Message);
            }

            if (client.IsConnected)
            {
                lblConnection.Text = "Verbonden";
                lblConnection.ForeColor = Color.Green;
                pnlIndex.Show();
                txtBoxUsername.Enabled = false;
                txtBoxPass.Enabled = false;
                txtBoxServerAddress.Enabled = false;
                btnLogin.Enabled = false;
            }
            else
            {
                lblConnection.Text = "Niet verbonden";
                lblConnection.ForeColor = Color.Red;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            client.Dispose();
            lblConnection.Text = "Niet verbonden";
            lblConnection.ForeColor = Color.Red;

            txtBoxUsername.Enabled = true;
            txtBoxPass.Enabled = true;
            txtBoxServerAddress.Enabled = true;
            btnLogin.Enabled = true;
        }

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

        private void btnUitvoeren_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();

            btnCmd1.Enabled = false;
            btnLogin.Enabled = false;
            btnLogout.Enabled = false;
            btnReindexCatalogSearchFullText.Enabled = false;
            btnReindexCatalogUrl.Enabled = false;
            btnReindexCategory_Flat.Enabled = false;
            btnReindexCategory_product.Enabled = false;
            btnReindexProduct_Attribute.Enabled = false;
            btnReindexProduct_price.Enabled = false;
            btnReindexProduct_url.Enabled = false;
            btnReindexStock.Enabled = false;
            btnReindexProduct_Flat.Enabled = false;
        }

        public void ReindexCommand()
        {
            var cmd = client.CreateCommand(txtBoxInput.Text);
            var result = cmd.Execute();
            this.Invoke(new Action(() =>
            {
                rTxtBoxOutput.Text += result;

                var reader = new StreamReader(cmd.ExtendedOutputStream);
                rTxtBoxOutput.Text += "\n" + reader.ReadToEnd();
            }
             ));
        }

        public void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ReindexCommand();
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            btnCmd1.Enabled = true;
            btnLogin.Enabled = true;
            btnLogout.Enabled = true;
            btnReindexCatalogSearchFullText.Enabled = true;
            btnReindexCatalogUrl.Enabled = true;
            btnReindexCategory_Flat.Enabled = true;
            btnReindexCategory_product.Enabled = true;
            btnReindexProduct_Attribute.Enabled = true;
            btnReindexProduct_price.Enabled = true;
            btnReindexProduct_url.Enabled = true;
            btnReindexStock.Enabled = true;
            btnReindexProduct_Flat.Enabled = true;

            lblStatus.Text = "Process Compleet";
            lblStatus.ForeColor = Color.Green;
        }

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

        private void btnReindexShow_Click(object sender, EventArgs e)
        {
            pnlIndex.Show();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            try
            {
                client.Disconnect();
                client.Dispose();
            }
            catch { }
            opgeslagen_data();
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
    }
}