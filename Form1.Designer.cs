namespace Culminating
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnContract = new System.Windows.Forms.Button();
            this.btnBuySell = new System.Windows.Forms.Button();
            this.txtPurchaseBoyBand = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblBuySell = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.txtPurchaseQuantity = new System.Windows.Forms.TextBox();
            this.lblBoyBand = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtDisplayBoyBands = new System.Windows.Forms.TextBox();
            this.txtMoneyOffer = new System.Windows.Forms.TextBox();
            this.lblMoneyOffer = new System.Windows.Forms.Label();
            this.lblExpense = new System.Windows.Forms.Label();
            this.lblEntertainmentValue = new System.Windows.Forms.Label();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.txtEntertainmentValue = new System.Windows.Forms.TextBox();
            this.txtDisplayPopulation = new System.Windows.Forms.TextBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnEndWeek = new System.Windows.Forms.Button();
            this.pictureBoxBAP = new System.Windows.Forms.PictureBox();
            this.pnlBuySellBoyBand = new System.Windows.Forms.Panel();
            this.btnExitBuySell = new System.Windows.Forms.Button();
            this.lblBuySellPrompt = new System.Windows.Forms.Label();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.lblAddPrompt = new System.Windows.Forms.Label();
            this.btnAddNo = new System.Windows.Forms.Button();
            this.btnAddYes = new System.Windows.Forms.Button();
            this.pnlAddBoyBand = new System.Windows.Forms.Panel();
            this.btnExitAdd = new System.Windows.Forms.Button();
            this.lblContractPrompt = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxSuperJunior = new System.Windows.Forms.PictureBox();
            this.pictureBoxExo = new System.Windows.Forms.PictureBox();
            this.pictureBoxSHINee = new System.Windows.Forms.PictureBox();
            this.pictureBoxNuest = new System.Windows.Forms.PictureBox();
            this.lblRevenue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBAP)).BeginInit();
            this.pnlBuySellBoyBand.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.pnlAddBoyBand.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSuperJunior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSHINee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNuest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContract
            // 
            this.btnContract.Location = new System.Drawing.Point(84, 114);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(73, 24);
            this.btnContract.TabIndex = 0;
            this.btnContract.Text = "Contract";
            this.btnContract.UseVisualStyleBackColor = true;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // btnBuySell
            // 
            this.btnBuySell.Location = new System.Drawing.Point(69, 87);
            this.btnBuySell.Name = "btnBuySell";
            this.btnBuySell.Size = new System.Drawing.Size(73, 23);
            this.btnBuySell.TabIndex = 1;
            this.btnBuySell.Text = "Comeback";
            this.btnBuySell.UseVisualStyleBackColor = true;
            this.btnBuySell.Click += new System.EventHandler(this.btnComeback_Click);
            // 
            // txtPurchaseBoyBand
            // 
            this.txtPurchaseBoyBand.Location = new System.Drawing.Point(69, 35);
            this.txtPurchaseBoyBand.Name = "txtPurchaseBoyBand";
            this.txtPurchaseBoyBand.Size = new System.Drawing.Size(158, 20);
            this.txtPurchaseBoyBand.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(302, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(279, 39);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Stage Simulator";
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblIntro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIntro.Location = new System.Drawing.Point(177, 48);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(519, 13);
            this.lblIntro.TabIndex = 5;
            this.lblIntro.Text = "Welcome to the stage simulator! Your job is to buy the best Korean boy bands to p" +
                "ut on stage to earn money!";
            // 
            // lblBuySell
            // 
            this.lblBuySell.AutoSize = true;
            this.lblBuySell.Location = new System.Drawing.Point(10, 11);
            this.lblBuySell.Name = "lblBuySell";
            this.lblBuySell.Size = new System.Drawing.Size(107, 13);
            this.lblBuySell.TabIndex = 6;
            this.lblBuySell.Text = "Boy Band Comeback";
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(9, 12);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(121, 13);
            this.lblContract.TabIndex = 7;
            this.lblContract.Text = "Contract New Boy Band";
            // 
            // txtPurchaseQuantity
            // 
            this.txtPurchaseQuantity.Location = new System.Drawing.Point(69, 61);
            this.txtPurchaseQuantity.Name = "txtPurchaseQuantity";
            this.txtPurchaseQuantity.Size = new System.Drawing.Size(158, 20);
            this.txtPurchaseQuantity.TabIndex = 9;
            // 
            // lblBoyBand
            // 
            this.lblBoyBand.AutoSize = true;
            this.lblBoyBand.Location = new System.Drawing.Point(10, 37);
            this.lblBoyBand.Name = "lblBoyBand";
            this.lblBoyBand.Size = new System.Drawing.Size(53, 13);
            this.lblBoyBand.TabIndex = 11;
            this.lblBoyBand.Text = "Boy Band";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(10, 64);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtDisplayBoyBands
            // 
            this.txtDisplayBoyBands.BackColor = System.Drawing.Color.Firebrick;
            this.txtDisplayBoyBands.Location = new System.Drawing.Point(12, 81);
            this.txtDisplayBoyBands.Multiline = true;
            this.txtDisplayBoyBands.Name = "txtDisplayBoyBands";
            this.txtDisplayBoyBands.ReadOnly = true;
            this.txtDisplayBoyBands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplayBoyBands.Size = new System.Drawing.Size(143, 234);
            this.txtDisplayBoyBands.TabIndex = 13;
            this.txtDisplayBoyBands.Text = "Boy Bands";
            // 
            // txtMoneyOffer
            // 
            this.txtMoneyOffer.Location = new System.Drawing.Point(84, 36);
            this.txtMoneyOffer.Name = "txtMoneyOffer";
            this.txtMoneyOffer.Size = new System.Drawing.Size(142, 20);
            this.txtMoneyOffer.TabIndex = 20;
            // 
            // lblMoneyOffer
            // 
            this.lblMoneyOffer.Location = new System.Drawing.Point(8, 36);
            this.lblMoneyOffer.Name = "lblMoneyOffer";
            this.lblMoneyOffer.Size = new System.Drawing.Size(73, 17);
            this.lblMoneyOffer.TabIndex = 22;
            this.lblMoneyOffer.Text = "Money Offer";
            // 
            // lblExpense
            // 
            this.lblExpense.Location = new System.Drawing.Point(8, 62);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(53, 20);
            this.lblExpense.TabIndex = 23;
            this.lblExpense.Text = "Expense";
            // 
            // lblEntertainmentValue
            // 
            this.lblEntertainmentValue.Location = new System.Drawing.Point(8, 88);
            this.lblEntertainmentValue.Name = "lblEntertainmentValue";
            this.lblEntertainmentValue.Size = new System.Drawing.Size(73, 30);
            this.lblEntertainmentValue.TabIndex = 24;
            this.lblEntertainmentValue.Text = "Entertainment Value";
            // 
            // txtExpense
            // 
            this.txtExpense.Location = new System.Drawing.Point(84, 62);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.Size = new System.Drawing.Size(142, 20);
            this.txtExpense.TabIndex = 25;
            // 
            // txtEntertainmentValue
            // 
            this.txtEntertainmentValue.Location = new System.Drawing.Point(84, 88);
            this.txtEntertainmentValue.Name = "txtEntertainmentValue";
            this.txtEntertainmentValue.Size = new System.Drawing.Size(142, 20);
            this.txtEntertainmentValue.TabIndex = 26;
            // 
            // txtDisplayPopulation
            // 
            this.txtDisplayPopulation.BackColor = System.Drawing.Color.Firebrick;
            this.txtDisplayPopulation.Location = new System.Drawing.Point(12, 329);
            this.txtDisplayPopulation.Multiline = true;
            this.txtDisplayPopulation.Name = "txtDisplayPopulation";
            this.txtDisplayPopulation.ReadOnly = true;
            this.txtDisplayPopulation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplayPopulation.Size = new System.Drawing.Size(145, 53);
            this.txtDisplayPopulation.TabIndex = 27;
            // 
            // lblPrompt
            // 
            this.lblPrompt.Location = new System.Drawing.Point(-210, 139);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(192, 45);
            this.lblPrompt.TabIndex = 28;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMoney.Location = new System.Drawing.Point(9, 9);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(0, 13);
            this.lblMoney.TabIndex = 29;
            // 
            // btnEndWeek
            // 
            this.btnEndWeek.Location = new System.Drawing.Point(16, 175);
            this.btnEndWeek.Name = "btnEndWeek";
            this.btnEndWeek.Size = new System.Drawing.Size(117, 51);
            this.btnEndWeek.TabIndex = 30;
            this.btnEndWeek.Text = "End Week";
            this.btnEndWeek.UseVisualStyleBackColor = true;
            this.btnEndWeek.Click += new System.EventHandler(this.btnEndWeek_Click);
            // 
            // pictureBoxBAP
            // 
            this.pictureBoxBAP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBAP.Image")));
            this.pictureBoxBAP.Location = new System.Drawing.Point(12, 410);
            this.pictureBoxBAP.Name = "pictureBoxBAP";
            this.pictureBoxBAP.Size = new System.Drawing.Size(255, 156);
            this.pictureBoxBAP.TabIndex = 31;
            this.pictureBoxBAP.TabStop = false;
            // 
            // pnlBuySellBoyBand
            // 
            this.pnlBuySellBoyBand.BackColor = System.Drawing.Color.Firebrick;
            this.pnlBuySellBoyBand.Controls.Add(this.btnExitBuySell);
            this.pnlBuySellBoyBand.Controls.Add(this.lblBuySellPrompt);
            this.pnlBuySellBoyBand.Controls.Add(this.txtPurchaseBoyBand);
            this.pnlBuySellBoyBand.Controls.Add(this.btnBuySell);
            this.pnlBuySellBoyBand.Controls.Add(this.lblBuySell);
            this.pnlBuySellBoyBand.Controls.Add(this.txtPurchaseQuantity);
            this.pnlBuySellBoyBand.Controls.Add(this.lblBoyBand);
            this.pnlBuySellBoyBand.Controls.Add(this.lblQuantity);
            this.pnlBuySellBoyBand.Location = new System.Drawing.Point(169, 81);
            this.pnlBuySellBoyBand.Name = "pnlBuySellBoyBand";
            this.pnlBuySellBoyBand.Size = new System.Drawing.Size(246, 144);
            this.pnlBuySellBoyBand.TabIndex = 32;
            // 
            // btnExitBuySell
            // 
            this.btnExitBuySell.Location = new System.Drawing.Point(223, 3);
            this.btnExitBuySell.Name = "btnExitBuySell";
            this.btnExitBuySell.Size = new System.Drawing.Size(20, 23);
            this.btnExitBuySell.TabIndex = 14;
            this.btnExitBuySell.Text = "X";
            this.btnExitBuySell.UseVisualStyleBackColor = true;
            this.btnExitBuySell.Click += new System.EventHandler(this.btnExitBuySell_Click);
            // 
            // lblBuySellPrompt
            // 
            this.lblBuySellPrompt.AutoSize = true;
            this.lblBuySellPrompt.Location = new System.Drawing.Point(13, 122);
            this.lblBuySellPrompt.Name = "lblBuySellPrompt";
            this.lblBuySellPrompt.Size = new System.Drawing.Size(0, 13);
            this.lblBuySellPrompt.TabIndex = 13;
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Firebrick;
            this.pnlAdd.Controls.Add(this.lblAddPrompt);
            this.pnlAdd.Controls.Add(this.btnAddNo);
            this.pnlAdd.Controls.Add(this.btnAddYes);
            this.pnlAdd.Location = new System.Drawing.Point(169, 219);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(246, 71);
            this.pnlAdd.TabIndex = 41;
            // 
            // lblAddPrompt
            // 
            this.lblAddPrompt.AutoSize = true;
            this.lblAddPrompt.Location = new System.Drawing.Point(16, 12);
            this.lblAddPrompt.Name = "lblAddPrompt";
            this.lblAddPrompt.Size = new System.Drawing.Size(182, 13);
            this.lblAddPrompt.TabIndex = 31;
            this.lblAddPrompt.Text = "Would you like to add this boy band?";
            // 
            // btnAddNo
            // 
            this.btnAddNo.Location = new System.Drawing.Point(85, 37);
            this.btnAddNo.Name = "btnAddNo";
            this.btnAddNo.Size = new System.Drawing.Size(37, 23);
            this.btnAddNo.TabIndex = 29;
            this.btnAddNo.Text = "No";
            this.btnAddNo.UseVisualStyleBackColor = true;
            this.btnAddNo.Click += new System.EventHandler(this.btnAddNo_Click);
            // 
            // btnAddYes
            // 
            this.btnAddYes.Location = new System.Drawing.Point(19, 36);
            this.btnAddYes.Name = "btnAddYes";
            this.btnAddYes.Size = new System.Drawing.Size(37, 23);
            this.btnAddYes.TabIndex = 30;
            this.btnAddYes.Text = "Yes";
            this.btnAddYes.UseVisualStyleBackColor = true;
            this.btnAddYes.Click += new System.EventHandler(this.btnAddYes_Click);
            // 
            // pnlAddBoyBand
            // 
            this.pnlAddBoyBand.BackColor = System.Drawing.Color.Firebrick;
            this.pnlAddBoyBand.Controls.Add(this.btnExitAdd);
            this.pnlAddBoyBand.Controls.Add(this.lblContractPrompt);
            this.pnlAddBoyBand.Controls.Add(this.txtExpense);
            this.pnlAddBoyBand.Controls.Add(this.btnContract);
            this.pnlAddBoyBand.Controls.Add(this.lblContract);
            this.pnlAddBoyBand.Controls.Add(this.txtMoneyOffer);
            this.pnlAddBoyBand.Controls.Add(this.lblPrompt);
            this.pnlAddBoyBand.Controls.Add(this.lblMoneyOffer);
            this.pnlAddBoyBand.Controls.Add(this.lblExpense);
            this.pnlAddBoyBand.Controls.Add(this.txtEntertainmentValue);
            this.pnlAddBoyBand.Controls.Add(this.lblEntertainmentValue);
            this.pnlAddBoyBand.Location = new System.Drawing.Point(169, 222);
            this.pnlAddBoyBand.Name = "pnlAddBoyBand";
            this.pnlAddBoyBand.Size = new System.Drawing.Size(246, 152);
            this.pnlAddBoyBand.TabIndex = 34;
            // 
            // btnExitAdd
            // 
            this.btnExitAdd.Location = new System.Drawing.Point(223, 3);
            this.btnExitAdd.Name = "btnExitAdd";
            this.btnExitAdd.Size = new System.Drawing.Size(20, 23);
            this.btnExitAdd.TabIndex = 15;
            this.btnExitAdd.Text = "X";
            this.btnExitAdd.UseVisualStyleBackColor = true;
            this.btnExitAdd.Click += new System.EventHandler(this.btnExitAdd_Click);
            // 
            // lblContractPrompt
            // 
            this.lblContractPrompt.AutoSize = true;
            this.lblContractPrompt.Location = new System.Drawing.Point(9, 159);
            this.lblContractPrompt.Name = "lblContractPrompt";
            this.lblContractPrompt.Size = new System.Drawing.Size(0, 13);
            this.lblContractPrompt.TabIndex = 29;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(16, 61);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(117, 51);
            this.btnPurchase.TabIndex = 35;
            this.btnPurchase.Text = "Boy Band Comeback Stage";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(16, 118);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(117, 51);
            this.btnSell.TabIndex = 36;
            this.btnSell.Text = "Boy Band Goodbye Stage";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 232);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 50);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(28, 5);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(102, 45);
            this.lblMenu.TabIndex = 39;
            this.lblMenu.Text = "Menu";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Controls.Add(this.lblMenu);
            this.panel4.Controls.Add(this.btnPurchase);
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnEndWeek);
            this.panel4.Controls.Add(this.btnSell);
            this.panel4.Location = new System.Drawing.Point(430, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 301);
            this.panel4.TabIndex = 40;
            // 
            // pictureBoxSuperJunior
            // 
            this.pictureBoxSuperJunior.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSuperJunior.Image")));
            this.pictureBoxSuperJunior.Location = new System.Drawing.Point(546, 411);
            this.pictureBoxSuperJunior.Name = "pictureBoxSuperJunior";
            this.pictureBoxSuperJunior.Size = new System.Drawing.Size(344, 155);
            this.pictureBoxSuperJunior.TabIndex = 41;
            this.pictureBoxSuperJunior.TabStop = false;
            // 
            // pictureBoxExo
            // 
            this.pictureBoxExo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExo.Image")));
            this.pictureBoxExo.Location = new System.Drawing.Point(604, 222);
            this.pictureBoxExo.Name = "pictureBoxExo";
            this.pictureBoxExo.Size = new System.Drawing.Size(286, 176);
            this.pictureBoxExo.TabIndex = 42;
            this.pictureBoxExo.TabStop = false;
            // 
            // pictureBoxSHINee
            // 
            this.pictureBoxSHINee.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSHINee.Image")));
            this.pictureBoxSHINee.Location = new System.Drawing.Point(284, 405);
            this.pictureBoxSHINee.Name = "pictureBoxSHINee";
            this.pictureBoxSHINee.Size = new System.Drawing.Size(245, 161);
            this.pictureBoxSHINee.TabIndex = 43;
            this.pictureBoxSHINee.TabStop = false;
            // 
            // pictureBoxNuest
            // 
            this.pictureBoxNuest.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNuest.Image")));
            this.pictureBoxNuest.Location = new System.Drawing.Point(641, 65);
            this.pictureBoxNuest.Name = "pictureBoxNuest";
            this.pictureBoxNuest.Size = new System.Drawing.Size(249, 146);
            this.pictureBoxNuest.TabIndex = 44;
            this.pictureBoxNuest.TabStop = false;
            // 
            // lblRevenue
            // 
            this.lblRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lblRevenue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRevenue.Location = new System.Drawing.Point(9, 30);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(146, 48);
            this.lblRevenue.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(903, 596);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.pictureBoxNuest);
            this.Controls.Add(this.pnlAddBoyBand);
            this.Controls.Add(this.pictureBoxSHINee);
            this.Controls.Add(this.pictureBoxExo);
            this.Controls.Add(this.pictureBoxSuperJunior);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlBuySellBoyBand);
            this.Controls.Add(this.pictureBoxBAP);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.txtDisplayPopulation);
            this.Controls.Add(this.txtDisplayBoyBands);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBAP)).EndInit();
            this.pnlBuySellBoyBand.ResumeLayout(false);
            this.pnlBuySellBoyBand.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlAddBoyBand.ResumeLayout(false);
            this.pnlAddBoyBand.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSuperJunior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSHINee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Button btnBuySell;
        private System.Windows.Forms.TextBox txtPurchaseBoyBand;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblBuySell;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.TextBox txtPurchaseQuantity;
        private System.Windows.Forms.Label lblBoyBand;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtDisplayBoyBands;
        private System.Windows.Forms.TextBox txtMoneyOffer;
        private System.Windows.Forms.Label lblMoneyOffer;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Label lblEntertainmentValue;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.TextBox txtEntertainmentValue;
        private System.Windows.Forms.TextBox txtDisplayPopulation;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnEndWeek;
        private System.Windows.Forms.PictureBox pictureBoxBAP;
        private System.Windows.Forms.Panel pnlBuySellBoyBand;
        private System.Windows.Forms.Panel pnlAddBoyBand;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblBuySellPrompt;
        private System.Windows.Forms.Button btnAddYes;
        private System.Windows.Forms.Button btnAddNo;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label lblAddPrompt;
        private System.Windows.Forms.PictureBox pictureBoxSuperJunior;
        private System.Windows.Forms.PictureBox pictureBoxExo;
        private System.Windows.Forms.PictureBox pictureBoxSHINee;
        private System.Windows.Forms.PictureBox pictureBoxNuest;
        private System.Windows.Forms.Label lblContractPrompt;
        private System.Windows.Forms.Button btnExitBuySell;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Button btnExitAdd;
    }
}

