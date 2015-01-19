/*Angela Xu
 * June 5 2013
 * This program is a stage simulator where the user can release boybands and to make money
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Culminating
{
    public partial class Form1 : Form
    {
        //stores the starting size of the arrays
        const int SIZE = 5;
        //array stores name of boy bands
        string[] boyBands = new string[SIZE];
        //stores names for each boy band
        const string BOY_BAND_0 = "Nu'est";
        const string BOY_BAND_1 = "B.A.P";
        const string BOY_BAND_2 = "SHINee";
        const string BOY_BAND_3 = "Super Junior";
        const string BOY_BAND_4 = "Exo";

        //array stores cost of boy bands
        int[] cost = new int[SIZE];
        //stores costs for each boy band
        const int COST_0 = 100;
        const int COST_1 = 200; 
        const int COST_2 = 300;
        const int COST_3 = 400;
        const int COST_4 = 500;

        //array stores keep up cost of boybands
        int[] keepUpCost = new int[SIZE];
        //stores keep up cost for each boy band
        const int KEEP_UP_COST_0 = 10;
        const int KEEP_UP_COST_1 = 20;
        const int KEEP_UP_COST_2 = 30;
        const int KEEP_UP_COST_3 = 40;
        const int KEEP_UP_COST_4 = 50;

        int[] quantity = new int[SIZE];

        //stores starting quantity for each boy band
        const int STARTING_QUANTITY = 0;
        //array stores entertainment value of boybands
        int[] entertainmentValue = new int[SIZE];
        //stores entertainment value for each boy band
        const int ENTERTAINMENT_VALUE_0 = 10;
        const int ENTERTAINMENT_VALUE_1 = 20;
        const int ENTERTAINMENT_VALUE_2 = 30;
        const int ENTERTAINMENT_VALUE_3 = 40;
        const int ENTERTAINMENT_VALUE_4 = 50;

        //stores the user's money
        double money = 1000;

        public Form1()
        {
            InitializeComponent();
            boyBands[0] = BOY_BAND_0;
            boyBands[1] = BOY_BAND_1;
            boyBands[2] = BOY_BAND_2;
            boyBands[3] = BOY_BAND_3;
            boyBands[4] = BOY_BAND_4;

            cost[0] = COST_0;
            cost[1] = COST_1;
            cost[2] = COST_2;
            cost[3] = COST_3;
            cost[4] = COST_4;

            keepUpCost[0] = KEEP_UP_COST_0;
            keepUpCost[1] = KEEP_UP_COST_1;
            keepUpCost[2] = KEEP_UP_COST_2;
            keepUpCost[3] = KEEP_UP_COST_3;
            keepUpCost[4] = KEEP_UP_COST_4;

            quantity[0] = STARTING_QUANTITY;
            quantity[1] = STARTING_QUANTITY;
            quantity[2] = STARTING_QUANTITY;
            quantity[3] = STARTING_QUANTITY;
            quantity[4] = STARTING_QUANTITY;

            entertainmentValue[0] = ENTERTAINMENT_VALUE_0;
            entertainmentValue[1] = ENTERTAINMENT_VALUE_1;
            entertainmentValue[2] = ENTERTAINMENT_VALUE_2;
            entertainmentValue[3] = ENTERTAINMENT_VALUE_3;
            entertainmentValue[4] = ENTERTAINMENT_VALUE_4;

            pnlBuySellBoyBand.Hide();
            pnlAddBoyBand.Hide();
            pnlAdd.Hide(); 

            Display();
        }

        //This subprogram displays the information for each boy band in the display textbox
        void Display()
        {
            txtDisplayBoyBands.Text = "Boybands";

            //counts through the array to print out all the boy bands
            for (int counter = 0; counter < boyBands.Length; counter++)
            {
                txtDisplayBoyBands.Text = txtDisplayBoyBands.Text + "\r\n";
                txtDisplayBoyBands.Text = txtDisplayBoyBands.Text + "\r\n" + boyBands[counter];
                txtDisplayBoyBands.Text = txtDisplayBoyBands.Text + "\r\nQuantity - " + quantity[counter];
                txtDisplayBoyBands.Text = txtDisplayBoyBands.Text + "\r\nContract Offer - " + cost[counter];
                txtDisplayBoyBands.Text = txtDisplayBoyBands.Text + "\r\nLiving Expenses - " + keepUpCost[counter];
                txtDisplayBoyBands.Text = txtDisplayBoyBands.Text + "\r\nEntertaiment Value - " + entertainmentValue[counter];
            }

            lblMoney.Text = "Money: $" + money;

            CountLargestPopulation();
            CountAllBoyBands();
        }

        //This subprogram counts through the arrays to find the largest population
        void CountLargestPopulation()
        {
            //Stores the index for boy band with the largest population
            int largestPopulationIndex = 0;
            txtDisplayPopulation.Text = "Largest population of boy band: ";

            //counts through the array to find the boy band with the largest population
            for (int counter = 1; counter < boyBands.Length; counter++)
            {
                //if the boy band has a greater quantity than the boy band at the largest population index then that index will replace that value
                if (quantity[largestPopulationIndex] < quantity[counter])
                {
                    largestPopulationIndex = counter;
                }
            }

            //counts through the array to find the boy bands the same population as the largestn
            for (int count = 0; count < boyBands.Length; count++)
            {
                //if another boy band has a population equal to the boy band with the greatest population they will be printed out as well
                if (quantity[largestPopulationIndex] == quantity[count])
                {
                    txtDisplayPopulation.Text = txtDisplayPopulation.Text + "\r\n" + boyBands[count];
                }
            }
        }

        //This subprogram adds up the quantity of the boy bands to find the total population
        void CountAllBoyBands()
        {
            //Stores the sum of all the boy bands
            int sum = 0;

            //counts through the array to add the quantity of all the boy bands
            for (int index = 0; index < quantity.Length; index++)
            {
                //adds the quantity of each boy band to the sum of all boy bands
                sum = sum + quantity[index];
            }

            txtDisplayPopulation.Text = txtDisplayPopulation.Text + "\r\n" + "Sum of the number of boybands is " + sum;
        }

        //Purchases the animal the user input when they press the button
        private void btnComeback_Click(object sender, EventArgs e)
        {
            //Stores if the boy band the user inputs already exists
            bool exist = false;
            //Stores the quantity of the boy band the user is purchasing
            int purchaseQuantity;
            int.TryParse (txtPurchaseQuantity.Text, out purchaseQuantity);
            //counts through the array to find the boy band the user purchased

            //counts through the array to find the boy band the user is purchasing or selling
            for (int index = 0; index < boyBands.Length; index++)
            {
                //if the boy band the user purchases already exists then it will add that boy band
                if (txtPurchaseBoyBand.Text == boyBands[index])
                {
                    //If the user is adding a boy band that is valid it will add the boy band
                    if (btnBuySell.Text == "Comeback" && purchaseQuantity > 0 && money >= cost[index] * purchaseQuantity)
                    {
                        //adds the quantity of the boy bands the user purchases
                        quantity[index] = quantity[index] + purchaseQuantity;
                        //subtracts the cost of the boy bands the user purchases from the user's money
                        money = money - cost[index] * purchaseQuantity;
                        lblBuySellPrompt.Text = "Your boy band has been purchased";
                        txtPurchaseBoyBand.Text = "";
                        txtPurchaseQuantity.Text = "";
                    }

                    //If the user is selling a boy band that is valid it will sell the boy band
                    else if (btnBuySell.Text == "Goodbye" && purchaseQuantity <= quantity[index] && purchaseQuantity > 0)
                    {
                        //subtracts the selling quantity from the quantity they own for that animal
                        quantity[index] = quantity[index] - purchaseQuantity;
                        //adds the of each cost of the boy bands the user sells back to the user's money
                        money = money + cost[index] * purchaseQuantity;
                        lblBuySellPrompt.Text = "Your boy band has been sold";
                        txtPurchaseBoyBand.Text = "";
                        txtPurchaseQuantity.Text = "";
                    }

                    //Else the user is told their transaction is invalid
                    else
                    {
                        lblBuySellPrompt.Text = "This transaction is invalid";
                    }

                    exist = true;
                }
            }

            //If the boy band the user added does not exist it will ask them to add a new boy band or tell them it's invalid
            if (exist == false)
            {
                //If the user is trying to sell a non existing boy band or the quantity is not valid they are told it's invalid
                if (btnBuySell.Text == "Goodbye")
                {
                    lblBuySellPrompt.Text = "This transaction is invalid";
                }

                //Else the user is told the boy band doesn't exist and they are asked if they want to add it
                else
                {
                    lblBuySellPrompt.Text = "This boy band does not exist";
                    pnlAdd.Show();
                }   
            }

            Display();
        }

        //Adds the new animal inputted by the user when the button is pressed
        private void btnContract_Click(object sender, EventArgs e)
        {
            //Stores the keep up cost of the boy band the user is adding
            int livingExpense;
            int.TryParse(txtExpense.Text, out livingExpense);
            //Stores the cost of the boy band the user is adding
            int moneyOffer;
            int.TryParse(txtMoneyOffer.Text, out moneyOffer);
            //Stores the entertaiment value of the boy band the user is adding
            int addEntertainmentValue;
            int.TryParse(txtEntertainmentValue.Text, out addEntertainmentValue);
            //Stores the quantity of the boy band the user is purchasing
            int purchaseQuantity;
            int.TryParse(txtPurchaseQuantity.Text, out purchaseQuantity);

            //If the value are negative, 0 or the user does not have enough money it will not allow the user to add the boy band
            if (livingExpense > 0 && moneyOffer > 0 && addEntertainmentValue > 0 && purchaseQuantity*moneyOffer <= money)
            {
                string[] tempBoyBands = boyBands;
                int[] tempQuantity = quantity;
                int[] tempCost = cost;
                int[] tempKeepUpCost = keepUpCost;
                int[] tempEntertainmentValue = entertainmentValue;
                boyBands = new string[boyBands.Length + 1];
                cost = new int[cost.Length + 1];
                keepUpCost = new int[keepUpCost.Length + 1];
                quantity = new int[quantity.Length + 1];
                entertainmentValue = new int[entertainmentValue.Length + 1];

                //counts through the array to move the arrays to temporily arrays
                for (int counter = 0; counter < tempBoyBands.Length; counter++)
                {
                    boyBands[counter] = tempBoyBands[counter];
                    cost[counter] = tempCost[counter];
                    keepUpCost[counter] = tempKeepUpCost[counter];
                    quantity[counter] = tempQuantity[counter];
                    entertainmentValue[counter] = tempEntertainmentValue[counter];
                }

                boyBands[boyBands.Length - 1] = txtPurchaseBoyBand.Text;
                int.TryParse(txtPurchaseQuantity.Text, out quantity[quantity.Length - 1]);
                int.TryParse(txtMoneyOffer.Text, out cost[cost.Length - 1]);
                int.TryParse(txtExpense.Text, out keepUpCost[keepUpCost.Length - 1]);
                int.TryParse(txtEntertainmentValue.Text, out entertainmentValue[entertainmentValue.Length - 1]);
                Display();
                lblBuySellPrompt.Text = "Your boy band has been added";
                pnlAddBoyBand.Hide();
                txtExpense.Text = "";
                txtEntertainmentValue.Text = "";
                txtMoneyOffer.Text = "";
            }

            //else the user is told their transaction is invalid
            else
            {
                lblBuySellPrompt.Text = "Your values are invalid!";
            }
        }

        //Calculates the revenue and keep up cost for the user's boy bands and adds them to the user's money
        private void btnEndWeek_Click(object sender, EventArgs e)
        {
            //Stores the revenue made by the boy bands
            int revenue = 0;
            //Stores the total keep up cost of the boy bands
            int totalKeepUpCost = 0;
            //Stores the profit of the boy bands
            int profit = 0;

            //counts through the array to calculate the keep up cost and revenue
            for (int index = 0; index < keepUpCost.Length; index++)
            {
                //adds up the keep up cost for each boy band to find the total
                totalKeepUpCost = totalKeepUpCost + keepUpCost[index] * quantity[index];

                //if the user has 1 or more of the boy band the entertainment value for the first boy band will be added to the user's money
                if (quantity[index] >= 1)
                {
                    //adds the entertainment value for the first boy band of the type to the user's revenue
                    revenue = revenue + entertainmentValue[index] * 10;
                }

                //if the user has 2 or more of the boy band the entertainment value for the second boy band will be added to the user's money
                if (quantity[index] >= 2)
                {
                    //adds the entertainment value for the second boy band of the type to the user's revenue
                    revenue = revenue + entertainmentValue[index] * 5;
                }

                //if the user has 3 or more of the boy band the entertainment value for the third boy band will be added to the user's revenue
                if (quantity[index] >= 3)
                {
                    //adds the entertainment value for the third boy band of the type to the user's revenue
                    revenue = revenue + entertainmentValue[index];
                }

                //if the user has 4 or more of the boy band the entertainment value for the fourth or more boy band will be added to the user's revenue
                if (quantity[index] >= 4)
                {
                    //adds the entertainment value for the fourth and more boy band of the type to the user's revenue
                    revenue = revenue + quantity[index] - 3;
                }
            }

            //adds the revenue and subtracts the total keep up cost to find the profit
            profit = revenue - totalKeepUpCost;
            //adds the profit made to the user's money
            money = money + profit;
            lblRevenue.Text = "Revenue: $" + revenue + "\r\nExpense: $" + totalKeepUpCost + "\r\nProfit: $" + profit;

            Display();
        }

        //Displays the buy/sell boy band panel with buy boy band labels
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            pnlBuySellBoyBand.Show();
            btnBuySell.Text = "Comeback";
            lblBuySell.Text = "Boy Band Comeback Stage";
        }

        //Displays the buy/sell boy band panel with sell boyband labels
        private void btnSell_Click(object sender, EventArgs e)
        {
            pnlBuySellBoyBand.Show();
            btnBuySell.Text = "Goodbye";
            lblBuySell.Text = "Boy Band Goodbye Stage";
        }

        //Exists the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Hides the add new boy band panel and clears the textboxes in the panel and the prompt label
        private void btnExitAdd_Click(object sender, EventArgs e)
        {
            pnlAddBoyBand.Hide();
            txtExpense.Text = "";
            txtEntertainmentValue.Text = "";
            txtMoneyOffer.Text = "";
            lblBuySellPrompt.Text = "";
        }

        //Hides the buy/sell boy band panel and clears the textboxes in the panel and the prompt labe
        private void btnExitBuySell_Click(object sender, EventArgs e)
        {
            pnlBuySellBoyBand.Hide();
            txtPurchaseBoyBand.Text = "";
            txtPurchaseQuantity.Text = "";
            lblBuySellPrompt.Text = "";
        }

        //Closes the add panel and clears the textboxes and label in the buy/sell panel
        private void btnAddNo_Click(object sender, EventArgs e)
        {
            pnlAdd.Hide();
            lblBuySellPrompt.Text = "";
            txtPurchaseBoyBand.Text = "";
            txtPurchaseQuantity.Text = "";
        }

        //Displays the add new boy band panel, hides the add panel and clears the prompt label
        private void btnAddYes_Click(object sender, EventArgs e)
        {
            pnlAddBoyBand.Show();
            pnlAdd.Hide();
            lblBuySellPrompt.Text = "";
        }
    } 
}

       

   


   

    
