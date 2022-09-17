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
            //MoneyDisplayLabel.Text = Convert.ToString(Balance);
        }


        private void SlotClickAccept_Click(object sender, EventArgs e)
        {

            int twoEqual = 3;
            //int threeEqual = 8;

            int random1 = 0;
            int random2 = 0;
            int random3 = 0;

            if (SlotBetAmount.Text.Length >= 1)
            {
                int attemptedBetAmount = Convert.ToInt32(SlotBetAmount.Text);

                Console.WriteLine(attemptedBetAmount);
                var handler = new DataHandler();
                var addBal = handler.AddBalance(0);

                if (attemptedBetAmount <= addBal)
                {
                    // Player has enough Money
                    handler.AddBalance(-attemptedBetAmount);

                    Random rnd = new Random();

                    random1 = rnd.Next(1,7);
                    SlotFirstNumber.Text = random1.ToString();
                    Thread.Sleep(500);

                    random2 = rnd.Next(1,7);
                    SlotSecondNumber.Text = random2.ToString();
                    Thread.Sleep(500);

                    random3 = rnd.Next(1,7);
                    SlotThirdNumber.Text = random3.ToString();
                    Thread.Sleep(500);

                    //Console.WriteLine(random1);
                    //Console.WriteLine(random2);
                    //Console.WriteLine(random3);





                    List<int> list = new List<int>();
                    list.Add(random1);
                    list.Add(random2);
                    list.Add(random3);


                    // Checking how many of each
                    int n1 = 0;
                    int n2 = 0;
                    int n3 = 0;
                    int n4 = 0;
                    int n5 = 0;
                    int n6 = 0;
                    int n7 = 0;

                    foreach (var item in list)
                    {
                        if (item == 1)
                        {
                            n1++;
                        }
                        else if (item == 2)
                        {
                            n2++;
                        }
                        else if (item == 3)
                        {
                            n3++;
                        }
                        else if (item == 4)
                        {
                            n4++;
                        }
                        else if (item == 5)
                        {
                            n5++;
                        }
                        else if (item == 6)
                        {
                            n6++;
                        }
                        else if (item == 7)
                        {
                            n7++;
                        }
                    }

                    List<int> list2 = new List<int>();
                    list2.Add(n1);
                    list2.Add(n2);
                    list2.Add(n3);
                    list2.Add(n4);
                    list2.Add(n5);
                    list2.Add(n6);
                    list2.Add(n7);


                    foreach (var item in list2)
                    {
                        if (item >= 2)
                        {
                            Console.WriteLine("3x");
                            var addWin = handler.AddBalance(attemptedBetAmount * twoEqual);
                            MoneyDisplayLabel.Text = addWin.ToString();
                        }
                        else
                        {
                            Console.WriteLine("0x");
                            var addWin = handler.AddBalance(0);
                            MoneyDisplayLabel.Text = addWin.ToString();
                        }
                    }
                }
                else
                {
                    // Player does not have the sufficient funds
                }
            }

        }
    }
}
