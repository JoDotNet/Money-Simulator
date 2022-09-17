using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Money_Simulator;

namespace Money_Simulator
{
    public partial class MainWindow : Form
    {
        // Draggeble Window
        private bool mouseDown;
        private Point lastLocation;

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }



        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Console.WriteLine("MainWindow has started.");
            //DataHandler dataHandler = new DataHandler();
            //dataHandler.LoadSave();
            //dataHandler.Trying();
            // Console.WriteLine("Data has loaded.");

            UpdateMoney();

            EarnPage.Visible = false;
            EarnPage.Enabled = false;
            EarnPage.Location = new Point(12, 56);

            SlotsPage.Visible = true;
            SlotsPage.Enabled = true;
            SlotsPage.Location = new Point(12, 56);
        }

        // TopBar

        // CloseButton
        private void CloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        // MimimizeButton
        private void MimimizeButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // Add Money Per Click

        //DataHandler datahandler = new DataHandler();
        private void MoneyButton_Click(object sender, EventArgs e)
        {
            //MoneyFunctions.UpdateMoney(MoneyDisplayLabel);
            //datahandler.Write(Convert.ToInt32(MoneyDisplayLabel.Text));
            //datahandler.AddBalance(1);

            //DataHandler dataHandler = new DataHandler();
            //dataHandler.TryFromLocal();

            var handler = new DataHandler();
            var addBal = handler.AddBalance(2);

            MoneyDisplayLabel.Text = addBal.ToString();

        }
        // Updating The Money View
        public void UpdateMoney()
        {
            var handler = new DataHandler();
            var addBal = handler.AddBalance(0);
            MoneyDisplayLabel.Text = Convert.ToString(addBal);
        }


        private void SlotClickAccept_Click(object sender, EventArgs e)
        {
            var slots = new Slots();
            var getSlots = slots.SlotGamble();

            //Console.WriteLine(getSlots);
            var slotWinAmount = getSlots.Remove(getSlots.Length - 3);
            var slotResult = getSlots.Remove(0, 1);

            //Console.WriteLine(slotWinAmount);
            //Console.WriteLine(slotResult);

            SlotFirstNumber.Text = Convert.ToString(slotResult[0]);
            SlotSecondNumber.Text = Convert.ToString(slotResult[1]);
            SlotThirdNumber.Text = Convert.ToString(slotResult[2]);


        }

        private void SlotsPage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WonStateSlots_Click(object sender, EventArgs e)
        {

        }
    }
}
