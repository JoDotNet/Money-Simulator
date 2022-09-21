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
        private bool rigged = false;

        // Slots:
        private bool slotCooldown = false;

        // Coinflip
        private bool coinflipCooldown = false;
        private string coinflipName = "";


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

            /*
            while (true)
            {
                Console.WriteLine(this.Location);
                await Task.Delay(1000);
            }
            */
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

        // Expandable Menu Button
        private void ExpandMenuButton_Click(object sender, EventArgs e)
        {
            var menuForm = new Menu();
            menuForm.ShowDialog();
        }

        // Navigation

        public void EarnButton_Click(object sender, EventArgs e)
        {
            EarnPage.Visible = true;
            EarnPage.Enabled = true;

            SlotsPage.Visible = false;
            SlotsPage.Enabled = false;

            CoinflipPage.Visible = false;
            CoinflipPage.Enabled = false;
        }

        public void SlotsButton_Click(object sender, EventArgs e)
        {
            EarnPage.Visible = false;
            EarnPage.Enabled = false;

            SlotsPage.Visible = true;
            SlotsPage.Enabled = true;

            CoinflipPage.Visible = false;
            CoinflipPage.Enabled = false;
        }

        public void CoinflipButton_Click(object sender, EventArgs e)
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
            IncomePerClick.Text = String.Concat("Income Per Click: $", addInc.ToString("N0", CultureInfo.InvariantCulture));
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
                    var getSlots = slots.SlotGamble(rigged);

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

        private void CoinflipBetGiver(int result, double betAmount)
        {       
            if (result == 1)
            {
                var handler = new DataHandler();
                var addBal = handler.AddBalance(betAmount * 2);
            }
            else
            {
                var handler = new DataHandler();
                var addBal = handler.AddBalance(betAmount);
            }
        }

        private async void CoinflipAnimation()
        {
            CoinflipAnimationImage.Image = Money_Simulator.Properties.Resources.Heads;
            await Task.Delay(100);
            CoinflipAnimationImage.Image = Money_Simulator.Properties.Resources.Tails;
            await Task.Delay(100);
            CoinflipAnimationImage.Image = Money_Simulator.Properties.Resources.Heads;
            await Task.Delay(100);
            CoinflipAnimationImage.Image = Money_Simulator.Properties.Resources.Tails;
            await Task.Delay(100);
            CoinflipAnimationImage.Image = Money_Simulator.Properties.Resources.Heads;
            await Task.Delay(100);
            CoinflipAnimationImage.Image = Money_Simulator.Properties.Resources.Tails;
            await Task.Delay(100);
            CoinflipAnimationImage.Image = Money_Simulator.Properties.Resources.Heads;
            await Task.Delay(100);
            CoinflipAnimationImage.Image = Money_Simulator.Properties.Resources.Tails;
            await Task.Delay(100);
            CoinflipAnimationImage.Image = null;
        }

        // Coinflip
        private async void ConfirmCoinflipButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("first");
            if (AttemtedBetCoinflip.Text.Length > 0)
            {   
                

                Console.WriteLine("second");
                var handler = new DataHandler();
                var balance = handler.AddBalance(0);
                double attemtedBetAmount = double.Parse(AttemtedBetCoinflip.Text);

                if (coinflipCooldown == false && attemtedBetAmount <= balance)
                {
                    coinflipCooldown = true;
                    Console.WriteLine("Thirds");
                    //CoinflipAnimation();
                    
                    var balance2 = handler.AddBalance(-attemtedBetAmount);
                    UpdateMoney();
                    //CoinflipAnimation();

                    var coinflip = new Coinflip();
                    var coinflipResult = coinflip.CoinGamble(rigged, coinflipName);
                    Console.WriteLine(coinflipResult);

                    //await Task.Delay(1500);
                    if (coinflipName == "Heads")
                    {
                        // User won on Heads
                        if (coinflipResult == 1)
                        {
                            // Award user with Money
                            CoinflipAnimationImage.Image = Money_Simulator.Properties.Resources.Heads;
                            CoinflipWinResult.Text = "You won 2x you bet! (heads)";
                            CoinflipBetGiver(1, attemtedBetAmount);

                        }
                        else
                        {
                            CoinflipAnimationImage.Image = Money_Simulator.Properties.Resources.Tails;
                            CoinflipWinResult.Text = "You lost.";
                        }
                    }
                    else if (coinflipName == "Tails")
                    {
                        // User won on Tails
                        if (coinflipResult == 2)
                        {
                            CoinflipAnimationImage.Image = Money_Simulator.Properties.Resources.Tails;
                            // Award user with Money
                            CoinflipWinResult.Text = "You won 2x you bet! (tails)";
                            CoinflipBetGiver(1, attemtedBetAmount);

                        }
                        else
                        {
                            CoinflipAnimationImage.Image = Money_Simulator.Properties.Resources.Heads;
                            CoinflipWinResult.Text = "You lost.";
                        }
                    }
                    else
                    {
                        CoinflipAnimationImage.Image = null;
                        Console.WriteLine("Player has not selected Heads or Tails (error)");
                        CoinflipBetGiver(2, attemtedBetAmount);
                    }

                    //var handler = new DataHandler();
                    //var balance = handler.AddBalance(0);

                    //double attemtedBetAmount = 0;

                    await Task.Delay(3500);
                    CoinflipAnimationImage.Image = null;
                    //coinflipName = ""; -- makes it so player doesn't have to select every time.
                    coinflipCooldown = false;
                    CoinflipWinResult.Text = "";
                    UpdateMoney();
                }
            }


        }

        private void HeadsButton_Click(object sender, EventArgs e)
        {
            coinflipName = "Heads";
        }

        private void TailsButton_Click(object sender, EventArgs e)
        {
            coinflipName = "Tails";
        }

        private void StatsPanel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void RiggedButton_Click(object sender, EventArgs e)
        {
            if (rigged == false)
            {
                rigged = true;
            }
            else
            {
                rigged = false;
            }
        }
    }
}
