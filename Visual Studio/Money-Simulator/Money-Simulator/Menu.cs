using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_Simulator
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen pen = new Pen(Color.FromArgb(255, 91, 130, 145), 10);
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            e.Graphics.DrawRectangle(pen, rect);
        }

        // CloseButton
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void CoinflipButton_Click(object sender, EventArgs e)
        {

        }

        private void SlotsButton_Click(object sender, EventArgs e)
        {

        }

        private void MinesButton_Click(object sender, EventArgs e)
        {

        }

        private void BlackjackButton_Click(object sender, EventArgs e)
        {

        }


    }
}
