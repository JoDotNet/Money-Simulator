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
            this.moneyicondollar = new System.Windows.Forms.Label();
            this.MoneyDisplayLabel = new System.Windows.Forms.Label();
            this.SlotsButton = new System.Windows.Forms.Label();
            this.EarnButton = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.MimimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.EarnPage = new System.Windows.Forms.Panel();
            this.MoneyButton = new System.Windows.Forms.Button();
            this.SlotsPage = new System.Windows.Forms.Panel();
            this.WonStateSlots = new System.Windows.Forms.Label();
            this.SlotBetAmount = new System.Windows.Forms.TextBox();
            this.SlotResultPanel = new System.Windows.Forms.Panel();
            this.SlotThirdNumber = new System.Windows.Forms.Label();
            this.SlotSecondNumber = new System.Windows.Forms.Label();
            this.SlotFirstNumber = new System.Windows.Forms.Label();
            this.SlotClickAccept = new System.Windows.Forms.Button();
            this.TopBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.EarnPage.SuspendLayout();
            this.SlotsPage.SuspendLayout();
            this.SlotResultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.TopBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TopBar.Controls.Add(this.moneyicondollar);
            this.TopBar.Controls.Add(this.MoneyDisplayLabel);
            this.TopBar.Controls.Add(this.SlotsButton);
            this.TopBar.Controls.Add(this.EarnButton);
            this.TopBar.Controls.Add(this.panel1);
            this.TopBar.Controls.Add(this.MenuButton);
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
            // moneyicondollar
            // 
            this.moneyicondollar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moneyicondollar.AutoSize = true;
            this.moneyicondollar.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyicondollar.ForeColor = System.Drawing.Color.White;
            this.moneyicondollar.Location = new System.Drawing.Point(60, 19);
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
            this.MoneyDisplayLabel.Location = new System.Drawing.Point(80, 19);
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
            this.SlotsButton.Location = new System.Drawing.Point(270, 25);
            this.SlotsButton.Name = "SlotsButton";
            this.SlotsButton.Size = new System.Drawing.Size(61, 25);
            this.SlotsButton.TabIndex = 5;
            this.SlotsButton.Text = "Slots";
            // 
            // EarnButton
            // 
            this.EarnButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EarnButton.AutoSize = true;
            this.EarnButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EarnButton.ForeColor = System.Drawing.Color.White;
            this.EarnButton.Location = new System.Drawing.Point(337, 25);
            this.EarnButton.Name = "EarnButton";
            this.EarnButton.Size = new System.Drawing.Size(57, 25);
            this.EarnButton.TabIndex = 4;
            this.EarnButton.Text = "Earn";
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
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.MenuButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.MenuButton.Image = global::Money_Simulator.Properties.Resources.menu_FILL0_wght400_GRAD0_opsz48;
            this.MenuButton.Location = new System.Drawing.Point(0, 0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(50, 50);
            this.MenuButton.TabIndex = 2;
            this.MenuButton.UseVisualStyleBackColor = false;
            // 
            // MimimizeButton
            // 
            this.MimimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
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
            // EarnPage
            // 
            this.EarnPage.Controls.Add(this.MoneyButton);
            this.EarnPage.Location = new System.Drawing.Point(1000, 1000);
            this.EarnPage.Name = "EarnPage";
            this.EarnPage.Size = new System.Drawing.Size(526, 582);
            this.EarnPage.TabIndex = 1;
            this.EarnPage.Visible = false;
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
            this.SlotsPage.Location = new System.Drawing.Point(12, 56);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(550, 650);
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
            this.SlotsPage.ResumeLayout(false);
            this.SlotsPage.PerformLayout();
            this.SlotResultPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MimimizeButton;
        private System.Windows.Forms.Button MenuButton;
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
    }
}

