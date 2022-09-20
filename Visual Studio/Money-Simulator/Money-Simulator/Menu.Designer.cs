namespace Money_Simulator
{
    partial class Menu
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.CoinflipButton = new System.Windows.Forms.Label();
            this.SlotsButton = new System.Windows.Forms.Label();
            this.MinesButton = new System.Windows.Forms.Label();
            this.BlackjackButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.CloseButton.Image = global::Money_Simulator.Properties.Resources.close_FILL1_wght400_GRAD0_opsz48;
            this.CloseButton.Location = new System.Drawing.Point(257, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 35);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CoinflipButton
            // 
            this.CoinflipButton.AutoSize = true;
            this.CoinflipButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoinflipButton.ForeColor = System.Drawing.Color.White;
            this.CoinflipButton.Location = new System.Drawing.Point(26, 26);
            this.CoinflipButton.Name = "CoinflipButton";
            this.CoinflipButton.Size = new System.Drawing.Size(79, 24);
            this.CoinflipButton.TabIndex = 1;
            this.CoinflipButton.Text = "Coinflip";
            this.CoinflipButton.Click += new System.EventHandler(this.CoinflipButton_Click);
            // 
            // SlotsButton
            // 
            this.SlotsButton.AutoSize = true;
            this.SlotsButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlotsButton.ForeColor = System.Drawing.Color.White;
            this.SlotsButton.Location = new System.Drawing.Point(26, 60);
            this.SlotsButton.Name = "SlotsButton";
            this.SlotsButton.Size = new System.Drawing.Size(57, 24);
            this.SlotsButton.TabIndex = 2;
            this.SlotsButton.Text = "Slots";
            this.SlotsButton.Click += new System.EventHandler(this.SlotsButton_Click);
            // 
            // MinesButton
            // 
            this.MinesButton.AutoSize = true;
            this.MinesButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinesButton.ForeColor = System.Drawing.Color.White;
            this.MinesButton.Location = new System.Drawing.Point(26, 94);
            this.MinesButton.Name = "MinesButton";
            this.MinesButton.Size = new System.Drawing.Size(135, 24);
            this.MinesButton.TabIndex = 3;
            this.MinesButton.Text = "Mines (Soon)";
            this.MinesButton.Click += new System.EventHandler(this.MinesButton_Click);
            // 
            // BlackjackButton
            // 
            this.BlackjackButton.AutoSize = true;
            this.BlackjackButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackjackButton.ForeColor = System.Drawing.Color.White;
            this.BlackjackButton.Location = new System.Drawing.Point(26, 128);
            this.BlackjackButton.Name = "BlackjackButton";
            this.BlackjackButton.Size = new System.Drawing.Size(167, 24);
            this.BlackjackButton.TabIndex = 4;
            this.BlackjackButton.Text = "Blackjack (Soon)";
            this.BlackjackButton.Click += new System.EventHandler(this.BlackjackButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.BlackjackButton);
            this.Controls.Add(this.MinesButton);
            this.Controls.Add(this.SlotsButton);
            this.Controls.Add(this.CoinflipButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 50);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label CoinflipButton;
        private System.Windows.Forms.Label SlotsButton;
        private System.Windows.Forms.Label MinesButton;
        private System.Windows.Forms.Label BlackjackButton;
    }
}