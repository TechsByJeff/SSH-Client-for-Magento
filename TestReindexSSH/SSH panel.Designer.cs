namespace TestReindexSSH
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxServerAddress = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.cBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rTxtBoxOutput = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.lblCommandText = new System.Windows.Forms.Label();
            this.btnCmd1 = new System.Windows.Forms.Button();
            this.btnReindexProduct_Attribute = new System.Windows.Forms.Button();
            this.btnReindexProduct_price = new System.Windows.Forms.Button();
            this.btnReindexProduct_url = new System.Windows.Forms.Button();
            this.btnReindexProduct_Flat = new System.Windows.Forms.Button();
            this.btnReindexCategory_Flat = new System.Windows.Forms.Button();
            this.btnReindexCategory_product = new System.Windows.Forms.Button();
            this.btnReindexCatalogSearchFullText = new System.Windows.Forms.Button();
            this.btnReindexStock = new System.Windows.Forms.Button();
            this.btnReindexCatalogUrl = new System.Windows.Forms.Button();
            this.pnlIndex = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOverig = new System.Windows.Forms.Button();
            this.btnReindexShow = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.pnlIndex.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(343, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Host address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(343, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gebruikersnaam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(343, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wachtwoord";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(974, 100);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(163, 42);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxServerAddress
            // 
            this.txtBoxServerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxServerAddress.Location = new System.Drawing.Point(537, 55);
            this.txtBoxServerAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxServerAddress.Name = "txtBoxServerAddress";
            this.txtBoxServerAddress.Size = new System.Drawing.Size(598, 29);
            this.txtBoxServerAddress.TabIndex = 1;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxUsername.Location = new System.Drawing.Point(537, 103);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(424, 29);
            this.txtBoxUsername.TabIndex = 2;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPass.Location = new System.Drawing.Point(537, 155);
            this.txtBoxPass.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(424, 29);
            this.txtBoxPass.TabIndex = 3;
            // 
            // cBoxRememberMe
            // 
            this.cBoxRememberMe.AutoSize = true;
            this.cBoxRememberMe.ForeColor = System.Drawing.Color.White;
            this.cBoxRememberMe.Location = new System.Drawing.Point(348, 212);
            this.cBoxRememberMe.Margin = new System.Windows.Forms.Padding(6);
            this.cBoxRememberMe.Name = "cBoxRememberMe";
            this.cBoxRememberMe.Size = new System.Drawing.Size(246, 29);
            this.cBoxRememberMe.TabIndex = 6;
            this.cBoxRememberMe.Text = "Onthoud inloggegevens";
            this.cBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Location = new System.Drawing.Point(730, 212);
            this.lblConnection.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(0, 25);
            this.lblConnection.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(974, 150);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(163, 42);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1113, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 41);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // rTxtBoxOutput
            // 
            this.rTxtBoxOutput.Location = new System.Drawing.Point(348, 412);
            this.rTxtBoxOutput.Margin = new System.Windows.Forms.Padding(6);
            this.rTxtBoxOutput.Name = "rTxtBoxOutput";
            this.rTxtBoxOutput.Size = new System.Drawing.Size(785, 379);
            this.rTxtBoxOutput.TabIndex = 0;
            this.rTxtBoxOutput.TabStop = false;
            this.rTxtBoxOutput.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(999, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Uitvoeren";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnUitvoeren_Click);
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(348, 310);
            this.txtBoxInput.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(785, 29);
            this.txtBoxInput.TabIndex = 7;
            // 
            // lblCommandText
            // 
            this.lblCommandText.AutoSize = true;
            this.lblCommandText.ForeColor = System.Drawing.Color.White;
            this.lblCommandText.Location = new System.Drawing.Point(343, 281);
            this.lblCommandText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCommandText.Name = "lblCommandText";
            this.lblCommandText.Size = new System.Drawing.Size(243, 25);
            this.lblCommandText.TabIndex = 3;
            this.lblCommandText.Text = "Voer hier uw commando in";
            // 
            // btnCmd1
            // 
            this.btnCmd1.BackColor = System.Drawing.Color.White;
            this.btnCmd1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCmd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCmd1.Location = new System.Drawing.Point(0, 6);
            this.btnCmd1.Margin = new System.Windows.Forms.Padding(6);
            this.btnCmd1.Name = "btnCmd1";
            this.btnCmd1.Size = new System.Drawing.Size(783, 42);
            this.btnCmd1.TabIndex = 0;
            this.btnCmd1.TabStop = false;
            this.btnCmd1.Text = "reindex all";
            this.btnCmd1.UseVisualStyleBackColor = false;
            this.btnCmd1.Click += new System.EventHandler(this.btnReindexAll_Click);
            // 
            // btnReindexProduct_Attribute
            // 
            this.btnReindexProduct_Attribute.BackColor = System.Drawing.Color.White;
            this.btnReindexProduct_Attribute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexProduct_Attribute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexProduct_Attribute.Location = new System.Drawing.Point(2, 59);
            this.btnReindexProduct_Attribute.Margin = new System.Windows.Forms.Padding(6);
            this.btnReindexProduct_Attribute.Name = "btnReindexProduct_Attribute";
            this.btnReindexProduct_Attribute.Size = new System.Drawing.Size(187, 42);
            this.btnReindexProduct_Attribute.TabIndex = 0;
            this.btnReindexProduct_Attribute.TabStop = false;
            this.btnReindexProduct_Attribute.Text = "product_attribute";
            this.btnReindexProduct_Attribute.UseVisualStyleBackColor = false;
            this.btnReindexProduct_Attribute.Click += new System.EventHandler(this.btnProductAttribuut_Click);
            // 
            // btnReindexProduct_price
            // 
            this.btnReindexProduct_price.BackColor = System.Drawing.Color.White;
            this.btnReindexProduct_price.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexProduct_price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexProduct_price.Location = new System.Drawing.Point(202, 59);
            this.btnReindexProduct_price.Margin = new System.Windows.Forms.Padding(6);
            this.btnReindexProduct_price.Name = "btnReindexProduct_price";
            this.btnReindexProduct_price.Size = new System.Drawing.Size(187, 42);
            this.btnReindexProduct_price.TabIndex = 0;
            this.btnReindexProduct_price.TabStop = false;
            this.btnReindexProduct_price.Text = "product_price";
            this.btnReindexProduct_price.UseVisualStyleBackColor = false;
            this.btnReindexProduct_price.Click += new System.EventHandler(this.btnReindexProduct_price_Click);
            // 
            // btnReindexProduct_url
            // 
            this.btnReindexProduct_url.BackColor = System.Drawing.Color.White;
            this.btnReindexProduct_url.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexProduct_url.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexProduct_url.Location = new System.Drawing.Point(400, 59);
            this.btnReindexProduct_url.Margin = new System.Windows.Forms.Padding(6);
            this.btnReindexProduct_url.Name = "btnReindexProduct_url";
            this.btnReindexProduct_url.Size = new System.Drawing.Size(187, 42);
            this.btnReindexProduct_url.TabIndex = 0;
            this.btnReindexProduct_url.TabStop = false;
            this.btnReindexProduct_url.Text = "product_url";
            this.btnReindexProduct_url.UseVisualStyleBackColor = false;
            this.btnReindexProduct_url.Click += new System.EventHandler(this.btnReindexProduct_url_Click);
            // 
            // btnReindexProduct_Flat
            // 
            this.btnReindexProduct_Flat.BackColor = System.Drawing.Color.White;
            this.btnReindexProduct_Flat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexProduct_Flat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexProduct_Flat.Location = new System.Drawing.Point(598, 59);
            this.btnReindexProduct_Flat.Margin = new System.Windows.Forms.Padding(6);
            this.btnReindexProduct_Flat.Name = "btnReindexProduct_Flat";
            this.btnReindexProduct_Flat.Size = new System.Drawing.Size(187, 42);
            this.btnReindexProduct_Flat.TabIndex = 0;
            this.btnReindexProduct_Flat.TabStop = false;
            this.btnReindexProduct_Flat.Text = "product_flat";
            this.btnReindexProduct_Flat.UseVisualStyleBackColor = false;
            this.btnReindexProduct_Flat.Click += new System.EventHandler(this.btnReindexProduct_Flat_Click);
            // 
            // btnReindexCategory_Flat
            // 
            this.btnReindexCategory_Flat.BackColor = System.Drawing.Color.White;
            this.btnReindexCategory_Flat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexCategory_Flat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexCategory_Flat.Location = new System.Drawing.Point(2, 113);
            this.btnReindexCategory_Flat.Margin = new System.Windows.Forms.Padding(6);
            this.btnReindexCategory_Flat.Name = "btnReindexCategory_Flat";
            this.btnReindexCategory_Flat.Size = new System.Drawing.Size(187, 42);
            this.btnReindexCategory_Flat.TabIndex = 0;
            this.btnReindexCategory_Flat.TabStop = false;
            this.btnReindexCategory_Flat.Text = "category_flat";
            this.btnReindexCategory_Flat.UseVisualStyleBackColor = false;
            this.btnReindexCategory_Flat.Click += new System.EventHandler(this.btnReindexCategory_Flat_Click);
            // 
            // btnReindexCategory_product
            // 
            this.btnReindexCategory_product.BackColor = System.Drawing.Color.White;
            this.btnReindexCategory_product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexCategory_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexCategory_product.Location = new System.Drawing.Point(202, 113);
            this.btnReindexCategory_product.Margin = new System.Windows.Forms.Padding(6);
            this.btnReindexCategory_product.Name = "btnReindexCategory_product";
            this.btnReindexCategory_product.Size = new System.Drawing.Size(187, 42);
            this.btnReindexCategory_product.TabIndex = 0;
            this.btnReindexCategory_product.TabStop = false;
            this.btnReindexCategory_product.Text = "category_product";
            this.btnReindexCategory_product.UseVisualStyleBackColor = false;
            this.btnReindexCategory_product.Click += new System.EventHandler(this.btnReindexCategory_product_Click);
            // 
            // btnReindexCatalogSearchFullText
            // 
            this.btnReindexCatalogSearchFullText.BackColor = System.Drawing.Color.White;
            this.btnReindexCatalogSearchFullText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexCatalogSearchFullText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexCatalogSearchFullText.Location = new System.Drawing.Point(400, 113);
            this.btnReindexCatalogSearchFullText.Margin = new System.Windows.Forms.Padding(6);
            this.btnReindexCatalogSearchFullText.Name = "btnReindexCatalogSearchFullText";
            this.btnReindexCatalogSearchFullText.Size = new System.Drawing.Size(187, 42);
            this.btnReindexCatalogSearchFullText.TabIndex = 0;
            this.btnReindexCatalogSearchFullText.TabStop = false;
            this.btnReindexCatalogSearchFullText.Text = "fulltext";
            this.btnReindexCatalogSearchFullText.UseVisualStyleBackColor = false;
            this.btnReindexCatalogSearchFullText.Click += new System.EventHandler(this.btnReindexCatalogSearchFullText_Click);
            // 
            // btnReindexStock
            // 
            this.btnReindexStock.BackColor = System.Drawing.Color.White;
            this.btnReindexStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexStock.Location = new System.Drawing.Point(598, 113);
            this.btnReindexStock.Margin = new System.Windows.Forms.Padding(6);
            this.btnReindexStock.Name = "btnReindexStock";
            this.btnReindexStock.Size = new System.Drawing.Size(187, 42);
            this.btnReindexStock.TabIndex = 0;
            this.btnReindexStock.TabStop = false;
            this.btnReindexStock.Text = "stock";
            this.btnReindexStock.UseVisualStyleBackColor = false;
            this.btnReindexStock.Click += new System.EventHandler(this.btnReindexStock_Click);
            // 
            // btnReindexCatalogUrl
            // 
            this.btnReindexCatalogUrl.BackColor = System.Drawing.Color.White;
            this.btnReindexCatalogUrl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReindexCatalogUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexCatalogUrl.Location = new System.Drawing.Point(2, 166);
            this.btnReindexCatalogUrl.Margin = new System.Windows.Forms.Padding(6);
            this.btnReindexCatalogUrl.Name = "btnReindexCatalogUrl";
            this.btnReindexCatalogUrl.Size = new System.Drawing.Size(187, 42);
            this.btnReindexCatalogUrl.TabIndex = 0;
            this.btnReindexCatalogUrl.TabStop = false;
            this.btnReindexCatalogUrl.Text = "tagSummary";
            this.btnReindexCatalogUrl.UseVisualStyleBackColor = false;
            this.btnReindexCatalogUrl.Click += new System.EventHandler(this.btnReindexCatalogUrl_Click);
            // 
            // pnlIndex
            // 
            this.pnlIndex.Controls.Add(this.progressBar);
            this.pnlIndex.Controls.Add(this.btnCmd1);
            this.pnlIndex.Controls.Add(this.btnReindexCatalogUrl);
            this.pnlIndex.Controls.Add(this.btnReindexProduct_Attribute);
            this.pnlIndex.Controls.Add(this.btnReindexStock);
            this.pnlIndex.Controls.Add(this.btnReindexProduct_price);
            this.pnlIndex.Controls.Add(this.btnReindexCategory_product);
            this.pnlIndex.Controls.Add(this.btnReindexProduct_Flat);
            this.pnlIndex.Controls.Add(this.btnReindexCategory_Flat);
            this.pnlIndex.Controls.Add(this.btnReindexProduct_url);
            this.pnlIndex.Controls.Add(this.btnReindexCatalogSearchFullText);
            this.pnlIndex.Location = new System.Drawing.Point(348, 805);
            this.pnlIndex.Margin = new System.Windows.Forms.Padding(6);
            this.pnlIndex.Name = "pnlIndex";
            this.pnlIndex.Size = new System.Drawing.Size(788, 229);
            this.pnlIndex.TabIndex = 17;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(205, 166);
            this.progressBar.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(578, 42);
            this.progressBar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnOverig);
            this.panel2.Controls.Add(this.btnReindexShow);
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 1073);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Image = global::TestReindexSSH.Properties.Resources.Questcontrol_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnOverig
            // 
            this.btnOverig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverig.FlatAppearance.BorderSize = 0;
            this.btnOverig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnOverig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnOverig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverig.ForeColor = System.Drawing.Color.White;
            this.btnOverig.Location = new System.Drawing.Point(0, 246);
            this.btnOverig.Margin = new System.Windows.Forms.Padding(6);
            this.btnOverig.Name = "btnOverig";
            this.btnOverig.Size = new System.Drawing.Size(337, 81);
            this.btnOverig.TabIndex = 0;
            this.btnOverig.Text = "iets anders";
            this.btnOverig.UseVisualStyleBackColor = true;
            // 
            // btnReindexShow
            // 
            this.btnReindexShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReindexShow.FlatAppearance.BorderSize = 0;
            this.btnReindexShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnReindexShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnReindexShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReindexShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReindexShow.ForeColor = System.Drawing.Color.White;
            this.btnReindexShow.Location = new System.Drawing.Point(0, 153);
            this.btnReindexShow.Margin = new System.Windows.Forms.Padding(6);
            this.btnReindexShow.Name = "btnReindexShow";
            this.btnReindexShow.Size = new System.Drawing.Size(337, 81);
            this.btnReindexShow.TabIndex = 0;
            this.btnReindexShow.Text = "Herindexeren";
            this.btnReindexShow.UseVisualStyleBackColor = true;
            this.btnReindexShow.Click += new System.EventHandler(this.btnReindexShow_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1153, 1111);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlIndex);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rTxtBoxOutput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.cBoxRememberMe);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.txtBoxServerAddress);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblCommandText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlIndex.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxServerAddress;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.CheckBox cBoxRememberMe;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rTxtBoxOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Label lblCommandText;
        private System.Windows.Forms.Button btnCmd1;
        private System.Windows.Forms.Button btnReindexProduct_Attribute;
        private System.Windows.Forms.Button btnReindexProduct_price;
        private System.Windows.Forms.Button btnReindexProduct_url;
        private System.Windows.Forms.Button btnReindexProduct_Flat;
        private System.Windows.Forms.Button btnReindexCategory_Flat;
        private System.Windows.Forms.Button btnReindexCategory_product;
        private System.Windows.Forms.Button btnReindexCatalogSearchFullText;
        private System.Windows.Forms.Button btnReindexStock;
        private System.Windows.Forms.Button btnReindexCatalogUrl;
        private System.Windows.Forms.Panel pnlIndex;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReindexShow;
        private System.Windows.Forms.Button btnOverig;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

