namespace Money_Simulator
{
    partial class MainWindow
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
            this.TopBar = new System.Windows.Forms.Panel();
            this.CoinflipButton = new System.Windows.Forms.Label();
            this.moneyicondollar = new System.Windows.Forms.Label();
            this.MoneyDisplayLabel = new System.Windows.Forms.Label();
            this.SlotsButton = new System.Windows.Forms.Label();
            this.EarnButton = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EarnPage = new System.Windows.Forms.Panel();
            this.StatsPanel = new System.Windows.Forms.Panel();
            this.MultiplierUpgradeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MultiplierPerClick = new System.Windows.Forms.Label();
            this.UpgradeButton4 = new System.Windows.Forms.Button();
            this.Upgrade4Label = new System.Windows.Forms.Label();
            this.UpgradeButton3 = new System.Windows.Forms.Button();
            this.Upgrade3Label = new System.Windows.Forms.Label();
            this.UpgradeButton2 = new System.Windows.Forms.Button();
            this.Upgrade2Label = new System.Windows.Forms.Label();
            this.UpgradeButton1 = new System.Windows.Forms.Button();
            this.Upgrade1Label = new System.Windows.Forms.Label();
            this.IncomePerClick = new System.Windows.Forms.Label();
            this.MoneyButton = new System.Windows.Forms.Button();
            this.SlotsPage = new System.Windows.Forms.Panel();
            this.WonStateSlots = new System.Windows.Forms.Label();
            this.SlotBetAmount = new System.Windows.Forms.TextBox();
            this.SlotResultPanel = new System.Windows.Forms.Panel();
            this.SlotThirdNumber = new System.Windows.Forms.Label();
            this.SlotSecondNumber = new System.Windows.Forms.Label();
            this.SlotFirstNumber = new System.Windows.Forms.Label();
            this.SlotClickAccept = new System.Windows.Forms.Button();
            this.CoinflipPage = new System.Windows.Forms.Panel();
            this.HeadsButton = new System.Windows.Forms.Button();
            this.TailsButton = new System.Windows.Forms.Button();
            this.CoinflipWinResult = new System.Windows.Forms.Label();
            this.AttemtedBetCoinflip = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CoinflipAnimationImage = new System.Windows.Forms.Label();
            this.ConfirmCoinflipButton = new System.Windows.Forms.Button();
            this.ExpandMenuButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MimimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TopBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.EarnPage.SuspendLayout();
            this.StatsPanel.SuspendLayout();
            this.SlotsPage.SuspendLayout();
            this.SlotResultPanel.SuspendLayout();
            this.CoinflipPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.TopBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TopBar.Controls.Add(this.ExpandMenuButton);
            this.TopBar.Controls.Add(this.CoinflipButton);
            this.TopBar.Controls.Add(this.moneyicondollar);
            this.TopBar.Controls.Add(this.MoneyDisplayLabel);
            this.TopBar.Controls.Add(this.SlotsButton);
            this.TopBar.Controls.Add(this.EarnButton);
            this.TopBar.Controls.Add(this.panel1);
            this.TopBar.Controls.Add(this.MimimizeButton);
            this.TopBar.Controls.Add(this.CloseButton);
            this.TopBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(550, 50);
            this.TopBar.TabIndex = 0;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // CoinflipButton
            // 
            this.CoinflipButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CoinflipButton.AutoSize = true;
            this.CoinflipButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoinflipButton.ForeColor = System.Drawing.Color.White;
            this.CoinflipButton.Location = new System.Drawing.Point(168, 24);
            this.CoinflipButton.Name = "CoinflipButton";
            this.CoinflipButton.Size = new System.Drawing.Size(85, 25);
            this.CoinflipButton.TabIndex = 8;
            this.CoinflipButton.Text = "Coinflip";
            this.CoinflipButton.Click += new System.EventHandler(this.CoinflipButton_Click);
            // 
            // moneyicondollar
            // 
            this.moneyicondollar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moneyicondollar.AutoSize = true;
            this.moneyicondollar.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyicondollar.ForeColor = System.Drawing.Color.White;
            this.moneyicondollar.Location = new System.Drawing.Point(6, 19);
            this.moneyicondollar.Name = "moneyicondollar";
            this.moneyicondollar.Size = new System.Drawing.Size(24, 25);
            this.moneyicondollar.TabIndex = 7;
            this.moneyicondollar.Text = "$";
            // 
            // MoneyDisplayLabel
            // 
            this.MoneyDisplayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MoneyDisplayLabel.AutoSize = true;
            this.MoneyDisplayLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyDisplayLabel.ForeColor = System.Drawing.Color.White;
            this.MoneyDisplayLabel.Location = new System.Drawing.Point(26, 19);
            this.MoneyDisplayLabel.Name = "MoneyDisplayLabel";
            this.MoneyDisplayLabel.Size = new System.Drawing.Size(24, 25);
            this.MoneyDisplayLabel.TabIndex = 6;
            this.MoneyDisplayLabel.Text = "0";
            // 
            // SlotsButton
            // 
            this.SlotsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SlotsButton.AutoSize = true;
            this.SlotsButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlotsButton.ForeColor = System.Drawing.Color.White;
            this.SlotsButton.Location = new System.Drawing.Point(258, 24);
            this.SlotsButton.Name = "SlotsButton";
            this.SlotsButton.Size = new System.Drawing.Size(61, 25);
            this.SlotsButton.TabIndex = 5;
            this.SlotsButton.Text = "Slots";
            this.SlotsButton.Click += new System.EventHandler(this.SlotsButton_Click);
            // 
            // EarnButton
            // 
            this.EarnButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EarnButton.AutoSize = true;
            this.EarnButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EarnButton.ForeColor = System.Drawing.Color.White;
            this.EarnButton.Location = new System.Drawing.Point(325, 24);
            this.EarnButton.Name = "EarnButton";
            this.EarnButton.Size = new System.Drawing.Size(57, 25);
            this.EarnButton.TabIndex = 4;
            this.EarnButton.Text = "Earn";
            this.EarnButton.Click += new System.EventHandler(this.EarnButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 600);
            this.panel1.TabIndex = 3;
            // 
            // EarnPage
            // 
            this.EarnPage.Controls.Add(this.StatsPanel);
            this.EarnPage.Controls.Add(this.MoneyButton);
            this.EarnPage.Location = new System.Drawing.Point(1000, 56);
            this.EarnPage.Name = "EarnPage";
            this.EarnPage.Size = new System.Drawing.Size(526, 582);
            this.EarnPage.TabIndex = 1;
            this.EarnPage.Visible = false;
            // 
            // StatsPanel
            // 
            this.StatsPanel.Controls.Add(this.MultiplierUpgradeButton);
            this.StatsPanel.Controls.Add(this.label2);
            this.StatsPanel.Controls.Add(this.MultiplierPerClick);
            this.StatsPanel.Controls.Add(this.UpgradeButton4);
            this.StatsPanel.Controls.Add(this.Upgrade4Label);
            this.StatsPanel.Controls.Add(this.UpgradeButton3);
            this.StatsPanel.Controls.Add(this.Upgrade3Label);
            this.StatsPanel.Controls.Add(this.UpgradeButton2);
            this.StatsPanel.Controls.Add(this.Upgrade2Label);
            this.StatsPanel.Controls.Add(this.UpgradeButton1);
            this.StatsPanel.Controls.Add(this.Upgrade1Label);
            this.StatsPanel.Controls.Add(this.IncomePerClick);
            this.StatsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatsPanel.Location = new System.Drawing.Point(0, 0);
            this.StatsPanel.Name = "StatsPanel";
            this.StatsPanel.Size = new System.Drawing.Size(526, 465);
            this.StatsPanel.TabIndex = 1;
            this.StatsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.StatsPanel_Paint);
            // 
            // MultiplierUpgradeButton
            // 
            this.MultiplierUpgradeButton.FlatAppearance.BorderSize = 2;
            this.MultiplierUpgradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplierUpgradeButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplierUpgradeButton.ForeColor = System.Drawing.Color.White;
            this.MultiplierUpgradeButton.Location = new System.Drawing.Point(441, 410);
            this.MultiplierUpgradeButton.Name = "MultiplierUpgradeButton";
            this.MultiplierUpgradeButton.Size = new System.Drawing.Size(73, 37);
            this.MultiplierUpgradeButton.TabIndex = 11;
            this.MultiplierUpgradeButton.Text = "BUY";
            this.MultiplierUpgradeButton.UseVisualStyleBackColor = true;
            this.MultiplierUpgradeButton.Click += new System.EventHandler(this.MultiplierUpgradeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "0.25x Income Boost ($10 000 000)";
            // 
            // MultiplierPerClick
            // 
            this.MultiplierPerClick.AutoSize = true;
            this.MultiplierPerClick.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplierPerClick.ForeColor = System.Drawing.Color.White;
            this.MultiplierPerClick.Location = new System.Drawing.Point(0, 49);
            this.MultiplierPerClick.Name = "MultiplierPerClick";
            this.MultiplierPerClick.Size = new System.Drawing.Size(126, 24);
            this.MultiplierPerClick.TabIndex = 9;
            this.MultiplierPerClick.Text = "Multiplier: 1x";
            // 
            // UpgradeButton4
            // 
            this.UpgradeButton4.FlatAppearance.BorderSize = 2;
            this.UpgradeButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradeButton4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpgradeButton4.ForeColor = System.Drawing.Color.White;
            this.UpgradeButton4.Location = new System.Drawing.Point(440, 344);
            this.UpgradeButton4.Name = "UpgradeButton4";
            this.UpgradeButton4.Size = new System.Drawing.Size(73, 37);
            this.UpgradeButton4.TabIndex = 8;
            this.UpgradeButton4.Text = "BUY";
            this.UpgradeButton4.UseVisualStyleBackColor = true;
            this.UpgradeButton4.Click += new System.EventHandler(this.UpgradeButton4_Click);
            // 
            // Upgrade4Label
            // 
            this.Upgrade4Label.AutoSize = true;
            this.Upgrade4Label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upgrade4Label.ForeColor = System.Drawing.Color.White;
            this.Upgrade4Label.Location = new System.Drawing.Point(12, 348);
            this.Upgrade4Label.Name = "Upgrade4Label";
            this.Upgrade4Label.Size = new System.Drawing.Size(290, 24);
            this.Upgrade4Label.TabIndex = 7;
            this.Upgrade4Label.Text = "+$1 000 Income ($1 000 000)";
            // 
            // UpgradeButton3
            // 
            this.UpgradeButton3.FlatAppearance.BorderSize = 2;
            this.UpgradeButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradeButton3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpgradeButton3.ForeColor = System.Drawing.Color.White;
            this.UpgradeButton3.Location = new System.Drawing.Point(439, 295);
            this.UpgradeButton3.Name = "UpgradeButton3";
            this.UpgradeButton3.Size = new System.Drawing.Size(73, 37);
            this.UpgradeButton3.TabIndex = 6;
            this.UpgradeButton3.Text = "BUY";
            this.UpgradeButton3.UseVisualStyleBackColor = true;
            this.UpgradeButton3.Click += new System.EventHandler(this.UpgradeButton3_Click);
            // 
            // Upgrade3Label
            // 
            this.Upgrade3Label.AutoSize = true;
            this.Upgrade3Label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upgrade3Label.ForeColor = System.Drawing.Color.White;
            this.Upgrade3Label.Location = new System.Drawing.Point(11, 299);
            this.Upgrade3Label.Name = "Upgrade3Label";
            this.Upgrade3Label.Size = new System.Drawing.Size(254, 24);
            this.Upgrade3Label.TabIndex = 5;
            this.Upgrade3Label.Text = "+$100 Income ($100 000)\r\n";
            // 
            // UpgradeButton2
            // 
            this.UpgradeButton2.FlatAppearance.BorderSize = 2;
            this.UpgradeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradeButton2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpgradeButton2.ForeColor = System.Drawing.Color.White;
            this.UpgradeButton2.Location = new System.Drawing.Point(440, 245);
            this.UpgradeButton2.Name = "UpgradeButton2";
            this.UpgradeButton2.Size = new System.Drawing.Size(73, 37);
            this.UpgradeButton2.TabIndex = 4;
            this.UpgradeButton2.Text = "BUY";
            this.UpgradeButton2.UseVisualStyleBackColor = true;
            this.UpgradeButton2.Click += new System.EventHandler(this.UpgradeButton2_Click);
            // 
            // Upgrade2Label
            // 
            this.Upgrade2Label.AutoSize = true;
            this.Upgrade2Label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upgrade2Label.ForeColor = System.Drawing.Color.White;
            this.Upgrade2Label.Location = new System.Drawing.Point(12, 249);
            this.Upgrade2Label.Name = "Upgrade2Label";
            this.Upgrade2Label.Size = new System.Drawing.Size(230, 24);
            this.Upgrade2Label.TabIndex = 3;
            this.Upgrade2Label.Text = "+$10 Income ($10 000)";
            // 
            // UpgradeButton1
            // 
            this.UpgradeButton1.FlatAppearance.BorderSize = 2;
            this.UpgradeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradeButton1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpgradeButton1.ForeColor = System.Drawing.Color.White;
            this.UpgradeButton1.Location = new System.Drawing.Point(439, 196);
            this.UpgradeButton1.Name = "UpgradeButton1";
            this.UpgradeButton1.Size = new System.Drawing.Size(73, 37);
            this.UpgradeButton1.TabIndex = 2;
            this.UpgradeButton1.Text = "BUY";
            this.UpgradeButton1.UseVisualStyleBackColor = true;
            this.UpgradeButton1.Click += new System.EventHandler(this.UpgradeButton1_Click);
            // 
            // Upgrade1Label
            // 
            this.Upgrade1Label.AutoSize = true;
            this.Upgrade1Label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upgrade1Label.ForeColor = System.Drawing.Color.White;
            this.Upgrade1Label.Location = new System.Drawing.Point(11, 200);
            this.Upgrade1Label.Name = "Upgrade1Label";
            this.Upgrade1Label.Size = new System.Drawing.Size(206, 24);
            this.Upgrade1Label.TabIndex = 1;
            this.Upgrade1Label.Text = "+$1 Income ($1 000)\r\n";
            // 
            // IncomePerClick
            // 
            this.IncomePerClick.AutoSize = true;
            this.IncomePerClick.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomePerClick.ForeColor = System.Drawing.Color.White;
            this.IncomePerClick.Location = new System.Drawing.Point(0, 20);
            this.IncomePerClick.Name = "IncomePerClick";
            this.IncomePerClick.Size = new System.Drawing.Size(192, 24);
            this.IncomePerClick.TabIndex = 0;
            this.IncomePerClick.Text = "Income Per Click: $";
            // 
            // MoneyButton
            // 
            this.MoneyButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MoneyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.MoneyButton.FlatAppearance.BorderSize = 5;
            this.MoneyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoneyButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyButton.ForeColor = System.Drawing.Color.White;
            this.MoneyButton.Location = new System.Drawing.Point(0, 465);
            this.MoneyButton.Name = "MoneyButton";
            this.MoneyButton.Size = new System.Drawing.Size(526, 117);
            this.MoneyButton.TabIndex = 0;
            this.MoneyButton.Text = "Click Me";
            this.MoneyButton.UseVisualStyleBackColor = true;
            this.MoneyButton.Click += new System.EventHandler(this.MoneyButton_Click);
            // 
            // SlotsPage
            // 
            this.SlotsPage.Controls.Add(this.WonStateSlots);
            this.SlotsPage.Controls.Add(this.SlotBetAmount);
            this.SlotsPage.Controls.Add(this.SlotResultPanel);
            this.SlotsPage.Controls.Add(this.SlotClickAccept);
            this.SlotsPage.Location = new System.Drawing.Point(1000, 56);
            this.SlotsPage.Name = "SlotsPage";
            this.SlotsPage.Size = new System.Drawing.Size(526, 582);
            this.SlotsPage.TabIndex = 2;
            this.SlotsPage.Visible = false;
            this.SlotsPage.Paint += new System.Windows.Forms.PaintEventHandler(this.SlotsPage_Paint);
            // 
            // WonStateSlots
            // 
            this.WonStateSlots.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WonStateSlots.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WonStateSlots.ForeColor = System.Drawing.Color.White;
            this.WonStateSlots.Location = new System.Drawing.Point(37, 304);
            this.WonStateSlots.Name = "WonStateSlots";
            this.WonStateSlots.Size = new System.Drawing.Size(450, 77);
            this.WonStateSlots.TabIndex = 7;
            this.WonStateSlots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WonStateSlots.Click += new System.EventHandler(this.WonStateSlots_Click);
            // 
            // SlotBetAmount
            // 
            this.SlotBetAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SlotBetAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.SlotBetAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SlotBetAmount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlotBetAmount.ForeColor = System.Drawing.Color.White;
            this.SlotBetAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SlotBetAmount.Location = new System.Drawing.Point(115, 433);
            this.SlotBetAmount.Margin = new System.Windows.Forms.Padding(0);
            this.SlotBetAmount.Name = "SlotBetAmount";
            this.SlotBetAmount.Size = new System.Drawing.Size(300, 32);
            this.SlotBetAmount.TabIndex = 2;
            this.SlotBetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SlotResultPanel
            // 
            this.SlotResultPanel.Controls.Add(this.SlotThirdNumber);
            this.SlotResultPanel.Controls.Add(this.SlotSecondNumber);
            this.SlotResultPanel.Controls.Add(this.SlotFirstNumber);
            this.SlotResultPanel.Location = new System.Drawing.Point(0, 75);
            this.SlotResultPanel.Name = "SlotResultPanel";
            this.SlotResultPanel.Size = new System.Drawing.Size(526, 136);
            this.SlotResultPanel.TabIndex = 1;
            // 
            // SlotThirdNumber
            // 
            this.SlotThirdNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.SlotThirdNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SlotThirdNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlotThirdNumber.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlotThirdNumber.ForeColor = System.Drawing.Color.White;
            this.SlotThirdNumber.Location = new System.Drawing.Point(337, 0);
            this.SlotThirdNumber.Name = "SlotThirdNumber";
            this.SlotThirdNumber.Size = new System.Drawing.Size(150, 136);
            this.SlotThirdNumber.TabIndex = 2;
            this.SlotThirdNumber.Text = "0";
            this.SlotThirdNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SlotThirdNumber.UseMnemonic = false;
            // 
            // SlotSecondNumber
            // 
            this.SlotSecondNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.SlotSecondNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SlotSecondNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlotSecondNumber.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlotSecondNumber.ForeColor = System.Drawing.Color.White;
            this.SlotSecondNumber.Location = new System.Drawing.Point(187, 0);
            this.SlotSecondNumber.Name = "SlotSecondNumber";
            this.SlotSecondNumber.Size = new System.Drawing.Size(150, 136);
            this.SlotSecondNumber.TabIndex = 1;
            this.SlotSecondNumber.Text = "0";
            this.SlotSecondNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SlotSecondNumber.UseMnemonic = false;
            // 
            // SlotFirstNumber
            // 
            this.SlotFirstNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.SlotFirstNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SlotFirstNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlotFirstNumber.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlotFirstNumber.ForeColor = System.Drawing.Color.White;
            this.SlotFirstNumber.Location = new System.Drawing.Point(37, 0);
            this.SlotFirstNumber.Name = "SlotFirstNumber";
            this.SlotFirstNumber.Size = new System.Drawing.Size(150, 136);
            this.SlotFirstNumber.TabIndex = 0;
            this.SlotFirstNumber.Text = "0";
            this.SlotFirstNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SlotFirstNumber.UseMnemonic = false;
            // 
            // SlotClickAccept
            // 
            this.SlotClickAccept.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SlotClickAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.SlotClickAccept.FlatAppearance.BorderSize = 5;
            this.SlotClickAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlotClickAccept.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlotClickAccept.ForeColor = System.Drawing.Color.White;
            this.SlotClickAccept.Location = new System.Drawing.Point(0, 465);
            this.SlotClickAccept.Name = "SlotClickAccept";
            this.SlotClickAccept.Size = new System.Drawing.Size(526, 117);
            this.SlotClickAccept.TabIndex = 0;
            this.SlotClickAccept.Text = "CONFIRM";
            this.SlotClickAccept.UseVisualStyleBackColor = true;
            this.SlotClickAccept.Click += new System.EventHandler(this.SlotClickAccept_Click);
            // 
            // CoinflipPage
            // 
            this.CoinflipPage.Controls.Add(this.HeadsButton);
            this.CoinflipPage.Controls.Add(this.TailsButton);
            this.CoinflipPage.Controls.Add(this.CoinflipWinResult);
            this.CoinflipPage.Controls.Add(this.AttemtedBetCoinflip);
            this.CoinflipPage.Controls.Add(this.panel3);
            this.CoinflipPage.Controls.Add(this.ConfirmCoinflipButton);
            this.CoinflipPage.Location = new System.Drawing.Point(1000, 56);
            this.CoinflipPage.Name = "CoinflipPage";
            this.CoinflipPage.Size = new System.Drawing.Size(526, 582);
            this.CoinflipPage.TabIndex = 9;
            this.CoinflipPage.Visible = false;
            // 
            // HeadsButton
            // 
            this.HeadsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.HeadsButton.FlatAppearance.BorderSize = 2;
            this.HeadsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeadsButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadsButton.ForeColor = System.Drawing.Color.White;
            this.HeadsButton.Location = new System.Drawing.Point(0, 407);
            this.HeadsButton.Name = "HeadsButton";
            this.HeadsButton.Size = new System.Drawing.Size(87, 58);
            this.HeadsButton.TabIndex = 11;
            this.HeadsButton.Text = "Heads";
            this.HeadsButton.UseVisualStyleBackColor = true;
            this.HeadsButton.Click += new System.EventHandler(this.HeadsButton_Click);
            // 
            // TailsButton
            // 
            this.TailsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.TailsButton.FlatAppearance.BorderSize = 2;
            this.TailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TailsButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TailsButton.ForeColor = System.Drawing.Color.White;
            this.TailsButton.Location = new System.Drawing.Point(438, 407);
            this.TailsButton.Name = "TailsButton";
            this.TailsButton.Size = new System.Drawing.Size(87, 58);
            this.TailsButton.TabIndex = 10;
            this.TailsButton.Text = "Tails";
            this.TailsButton.UseVisualStyleBackColor = true;
            this.TailsButton.Click += new System.EventHandler(this.TailsButton_Click);
            // 
            // CoinflipWinResult
            // 
            this.CoinflipWinResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.CoinflipWinResult.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoinflipWinResult.ForeColor = System.Drawing.Color.White;
            this.CoinflipWinResult.Location = new System.Drawing.Point(0, 0);
            this.CoinflipWinResult.Name = "CoinflipWinResult";
            this.CoinflipWinResult.Size = new System.Drawing.Size(526, 72);
            this.CoinflipWinResult.TabIndex = 9;
            this.CoinflipWinResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AttemtedBetCoinflip
            // 
            this.AttemtedBetCoinflip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttemtedBetCoinflip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.AttemtedBetCoinflip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AttemtedBetCoinflip.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttemtedBetCoinflip.ForeColor = System.Drawing.Color.White;
            this.AttemtedBetCoinflip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AttemtedBetCoinflip.Location = new System.Drawing.Point(115, 433);
            this.AttemtedBetCoinflip.Margin = new System.Windows.Forms.Padding(0);
            this.AttemtedBetCoinflip.Name = "AttemtedBetCoinflip";
            this.AttemtedBetCoinflip.Size = new System.Drawing.Size(300, 32);
            this.AttemtedBetCoinflip.TabIndex = 2;
            this.AttemtedBetCoinflip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CoinflipAnimationImage);
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 297);
            this.panel3.TabIndex = 1;
            // 
            // CoinflipAnimationImage
            // 
            this.CoinflipAnimationImage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoinflipAnimationImage.ForeColor = System.Drawing.Color.White;
            this.CoinflipAnimationImage.Location = new System.Drawing.Point(115, -18);
            this.CoinflipAnimationImage.Name = "CoinflipAnimationImage";
            this.CoinflipAnimationImage.Size = new System.Drawing.Size(300, 297);
            this.CoinflipAnimationImage.TabIndex = 0;
            this.CoinflipAnimationImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmCoinflipButton
            // 
            this.ConfirmCoinflipButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConfirmCoinflipButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.ConfirmCoinflipButton.FlatAppearance.BorderSize = 5;
            this.ConfirmCoinflipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmCoinflipButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmCoinflipButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmCoinflipButton.Location = new System.Drawing.Point(0, 465);
            this.ConfirmCoinflipButton.Name = "ConfirmCoinflipButton";
            this.ConfirmCoinflipButton.Size = new System.Drawing.Size(526, 117);
            this.ConfirmCoinflipButton.TabIndex = 0;
            this.ConfirmCoinflipButton.Text = "CONFIRM";
            this.ConfirmCoinflipButton.UseVisualStyleBackColor = true;
            this.ConfirmCoinflipButton.Click += new System.EventHandler(this.ConfirmCoinflipButton_Click);
            // 
            // ExpandMenuButton
            // 
            this.ExpandMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.ExpandMenuButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExpandMenuButton.FlatAppearance.BorderSize = 0;
            this.ExpandMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpandMenuButton.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpandMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.ExpandMenuButton.Image = global::Money_Simulator.Properties.Resources.widgets_FILL0_wght400_GRAD0_opsz40;
            this.ExpandMenuButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExpandMenuButton.Location = new System.Drawing.Point(400, 0);
            this.ExpandMenuButton.Name = "ExpandMenuButton";
            this.ExpandMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExpandMenuButton.Size = new System.Drawing.Size(50, 50);
            this.ExpandMenuButton.TabIndex = 9;
            this.ExpandMenuButton.UseVisualStyleBackColor = false;
            this.ExpandMenuButton.Click += new System.EventHandler(this.ExpandMenuButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.button2.Image = global::Money_Simulator.Properties.Resources.minimize_FILL1_wght400_GRAD0_opsz48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(450, 0);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.button3.Image = global::Money_Simulator.Properties.Resources.close_FILL1_wght400_GRAD0_opsz48;
            this.button3.Location = new System.Drawing.Point(0, 550);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // MimimizeButton
            // 
            this.MimimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.MimimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MimimizeButton.FlatAppearance.BorderSize = 0;
            this.MimimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MimimizeButton.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MimimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.MimimizeButton.Image = global::Money_Simulator.Properties.Resources.minimize_FILL1_wght400_GRAD0_opsz48;
            this.MimimizeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MimimizeButton.Location = new System.Drawing.Point(450, 0);
            this.MimimizeButton.Name = "MimimizeButton";
            this.MimimizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MimimizeButton.Size = new System.Drawing.Size(50, 50);
            this.MimimizeButton.TabIndex = 1;
            this.MimimizeButton.UseVisualStyleBackColor = false;
            this.MimimizeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MimimizeButton_MouseClick);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.CloseButton.Image = global::Money_Simulator.Properties.Resources.close_FILL1_wght400_GRAD0_opsz48;
            this.CloseButton.Location = new System.Drawing.Point(500, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(50, 50);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(550, 650);
            this.Controls.Add(this.CoinflipPage);
            this.Controls.Add(this.SlotsPage);
            this.Controls.Add(this.EarnPage);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Simulator";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.EarnPage.ResumeLayout(false);
            this.StatsPanel.ResumeLayout(false);
            this.StatsPanel.PerformLayout();
            this.SlotsPage.ResumeLayout(false);
            this.SlotsPage.PerformLayout();
            this.SlotResultPanel.ResumeLayout(false);
            this.CoinflipPage.ResumeLayout(false);
            this.CoinflipPage.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MimimizeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label EarnButton;
        private System.Windows.Forms.Label SlotsButton;
        private System.Windows.Forms.Panel EarnPage;
        private System.Windows.Forms.Button MoneyButton;
        private System.Windows.Forms.Label MoneyDisplayLabel;
        private System.Windows.Forms.Panel SlotsPage;
        private System.Windows.Forms.Button SlotClickAccept;
        private System.Windows.Forms.Panel SlotResultPanel;
        private System.Windows.Forms.Label SlotFirstNumber;
        private System.Windows.Forms.Label SlotThirdNumber;
        private System.Windows.Forms.Label SlotSecondNumber;
        private System.Windows.Forms.TextBox SlotBetAmount;
        private System.Windows.Forms.Label WonStateSlots;
        private System.Windows.Forms.Label moneyicondollar;
        private System.Windows.Forms.Panel StatsPanel;
        private System.Windows.Forms.Label IncomePerClick;
        private System.Windows.Forms.Button UpgradeButton1;
        private System.Windows.Forms.Label Upgrade1Label;
        private System.Windows.Forms.Button UpgradeButton2;
        private System.Windows.Forms.Label Upgrade2Label;
        private System.Windows.Forms.Button UpgradeButton4;
        private System.Windows.Forms.Label Upgrade4Label;
        private System.Windows.Forms.Button UpgradeButton3;
        private System.Windows.Forms.Label Upgrade3Label;
        private System.Windows.Forms.Label MultiplierPerClick;
        private System.Windows.Forms.Button MultiplierUpgradeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CoinflipButton;
        private System.Windows.Forms.Panel CoinflipPage;
        private System.Windows.Forms.TextBox AttemtedBetCoinflip;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ConfirmCoinflipButton;
        private System.Windows.Forms.Label CoinflipAnimationImage;
        private System.Windows.Forms.Label CoinflipWinResult;
        private System.Windows.Forms.Button HeadsButton;
        private System.Windows.Forms.Button TailsButton;
        private System.Windows.Forms.Button ExpandMenuButton;
    }
}

