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
using System.Globalization;

using Money_Simulator;

namespace Money_Simulator
{
    public partial class MainWindow : Form
    {
        // Draggeble Window
        private bool mouseDown;
        private Point lastLocation;



        // Game Variables

        // Slots:
        private bool slotCooldown = false;

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

            EarnPage.Visible = true;
            EarnPage.Enabled = true;
            EarnPage.Location = new Point(12, 56);

            SlotsPage.Visible = false;
            SlotsPage.Enabled = false;
            SlotsPage.Location = new Point(12, 56);

            CoinflipPage.Visible = false;
            CoinflipPage.Enabled = false;
            CoinflipPage.Location = new Point(12, 56);
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



        // Navigation

        private void EarnButton_Click(object sender, EventArgs e)
        {
            EarnPage.Visible = true;
            EarnPage.Enabled = true;

            SlotsPage.Visible = false;
            SlotsPage.Enabled = false;

            CoinflipPage.Visible = false;
            CoinflipPage.Enabled = false;
        }

        private void SlotsButton_Click(object sender, EventArgs e)
        {
            EarnPage.Visible = false;
            EarnPage.Enabled = false;

            SlotsPage.Visible = true;
            SlotsPage.Enabled = true;

            CoinflipPage.Visible = false;
            CoinflipPage.Enabled = false;
        }

        private void CoinflipButton_Click(object sender, EventArgs e)
        {
            EarnPage.Visible = false;
            EarnPage.Enabled = false;

            SlotsPage.Visible = false;
            SlotsPage.Enabled = false;

            CoinflipPage.Visible = true;
            CoinflipPage.Enabled = true;
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
            var addInc = handler.AddIncome(0, 0);
            var addBal = handler.AddBalance(addInc);

            //MoneyDisplayLabel.Text = addBal.ToString();
            UpdateMoney();

        }
        // Updating The Money View
        public void UpdateMoney()
        {
            var handler = new DataHandler();
            var addBal = handler.AddBalance(0);
            var addInc = handler.AddIncome(0, 0);
            var getMul = handler.GetMultiplier(0);

            MoneyDisplayLabel.Text = addBal.ToString("N", CultureInfo.InvariantCulture); // add N0 for no decimal points
            IncomePerClick.Text = String.Concat("Income Per Click: $", addInc);
            MultiplierPerClick.Text = String.Concat("Multiplier: ", getMul);
            //MoneyDisplayLabel.Text = Convert.ToString(addBal);
        }


        private async void SlotClickAccept_Click(object sender, EventArgs e)
        {
            // Check if the player has enough money
            var handler = new DataHandler();
            var balance = handler.AddBalance(0);

            double attemtedBetAmount = 0;

            if (SlotBetAmount.TextLength > 0) attemtedBetAmount = double.Parse(SlotBetAmount.Text);
            
            bool allowedBet = false;

            if (SlotBetAmount.TextLength > 0) allowedBet = true; else allowedBet = false;

            if (balance >= attemtedBetAmount && allowedBet == true)
            {
                // Doesn't duplicate if game is already in place
                if (slotCooldown == false)
                {
                    // Setting Debounce to True
                    slotCooldown = true;

                    // Removing Money
                    var handler2 = new DataHandler();
                    var balance2 = handler2.AddBalance(-attemtedBetAmount);
                    UpdateMoney();


                    var slots = new Slots();
                    var getSlots = slots.SlotGamble();

                    //Console.WriteLine(getSlots);
                    var slotWinAmount = getSlots.Remove(getSlots.Length - 3);
                    var slotResult = getSlots.Remove(0, 1);

                    //Console.WriteLine(slotWinAmount);
                    //Console.WriteLine(slotResult);

                    SlotFirstNumber.Text = "0";
                    SlotSecondNumber.Text = "0";
                    SlotThirdNumber.Text = "0";

                    await Task.Delay(500);

                    SlotFirstNumber.Text = Convert.ToString(slotResult[0]);
                    await Task.Delay(500);
                    SlotSecondNumber.Text = Convert.ToString(slotResult[1]);
                    await Task.Delay(500);
                    SlotThirdNumber.Text = Convert.ToString(slotResult[2]);

                    await Task.Delay(100);
                    if (slotWinAmount == "0")
                    {
                        WonStateSlots.Text = "You lost.";
                    }
                    else if (slotResult == "777")
                    {
                        WonStateSlots.Text = "You must be using some cheat software\n 25x your bet!";
                        var addBalance = handler.AddBalance(attemtedBetAmount * 25);
                    }
                    else if (slotWinAmount == "2")
                    {
                        WonStateSlots.Text = "You won 3x your bet!";
                        var addBalance = handler.AddBalance(attemtedBetAmount * 3);
                    }
                    else if (slotWinAmount == "3")
                    {
                        WonStateSlots.Text = "You won 8x your bet!\n BIG WIN!";
                        var addBalance = handler.AddBalance(attemtedBetAmount * 8);
                    }

                    await Task.Delay(2500);

                    UpdateMoney();
                    SlotFirstNumber.Text = "0";
                    SlotSecondNumber.Text = "0";
                    SlotThirdNumber.Text = "0";
                    WonStateSlots.Text = "";


                    await Task.Delay(5);
                    slotCooldown = false;
                }
            
            }
            


        }

        private void SlotsPage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WonStateSlots_Click(object sender, EventArgs e)
        {

        }


        // Upgrade Income Per Click
        private void UpgradeButton1_Click(object sender, EventArgs e)
        {
            var handler = new DataHandler();
            var addBal = handler.AddBalance(0);

            // Check if the Player has enough money for the upgrade
            if (addBal >= 1000)
            {
                handler.AddBalance(-1000);
                handler.AddIncome(1, 0);
                UpdateMoney();
            }
        }

        private void UpgradeButton2_Click(object sender, EventArgs e)
        {
            var handler = new DataHandler();
            var addBal = handler.AddBalance(0);

            // Check if the Player has enough money for the upgrade
            if (addBal >= 10000)
            {
                handler.AddBalance(-10000);
                handler.AddIncome(10, 0);
                UpdateMoney();
            }
        }

        private void UpgradeButton3_Click(object sender, EventArgs e)
        {
            var handler = new DataHandler();
            var addBal = handler.AddBalance(0);

            // Check if the Player has enough money for the upgrade
            if (addBal >= 100000)
            {
                handler.AddBalance(-100000);
                handler.AddIncome(100, 0);
                UpdateMoney();
            }
        }

        private void UpgradeButton4_Click(object sender, EventArgs e)
        {
            var handler = new DataHandler();
            var addBal = handler.AddBalance(0);

            // Check if the Player has enough money for the upgrade
            if (addBal >= 1000000)
            {
                handler.AddBalance(-1000000);
                handler.AddIncome(1000, 0);
                UpdateMoney();
            }
        }

        private void MultiplierUpgradeButton_Click(object sender, EventArgs e)
        {
            var handler = new DataHandler();
            var addBal = handler.AddBalance(0);

            // Check if the Player has enough money for the upgrade
            if (addBal >= 10000000)
            {
                handler.AddBalance(-10000000);
                handler.AddIncome(0, .25);
                UpdateMoney();
            }
        }


    }
}
