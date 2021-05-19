using System;
using System.Windows.Forms;

namespace Probabilistic_Simulations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();

        // ------------------ Question 1 ------------------
        int[] placementsCounter = new int[8];
        float currentPlacement;

        void BtnPlinko_Click(object sender, EventArgs e)
        {
            //Clears the variables for next click
            for (int i = 0; i < placementsCounter.Length; i++)
            {
                placementsCounter[i] = 0;
            }
            currentPlacement = 0;

            SimulatePlinko();
            DisplayPlinko();
        }
        void SimulatePlinko()
        {
            int amountTests = (int)numGames.Value;

            // How many times are we going to do the test
            for (int ball = 0; ball < amountTests; ball++)
            {
                currentPlacement = 4f; // set it back to the middle

                // Do a simulation
                for (int level = 1; level <= placementsCounter.Length; level++)
                {
                    int tempRand = rand.Next(2);

                    if (tempRand == 1)
                        currentPlacement += 0.5f;
                    else
                        currentPlacement -= 0.5f;
                }

                // Prevents index exception
                if (currentPlacement >= 8 || currentPlacement < 0)
                {
                    continue;
                }

                int temp = (int)currentPlacement;
                placementsCounter[temp] = placementsCounter[temp] + 1;

            }
        }
        void DisplayPlinko()
        {
            TxtDisplay.Text = "";
            TxtDisplay.Text += "Pockets:\tFrequency:" + Environment.NewLine;

            for (int i = 1; i < placementsCounter.Length; i++)
            {
                TxtDisplay.Text += i + "\t" + placementsCounter[i] + Environment.NewLine;
            }

        }

        // ------------------ Question 2 ------------------
        float playerBuyIn = 25f;
        int playerShots = 3;
        float prizeCost = 100f;
        float plateCost = 0.4f;
        float ownerTotal;
        int playerPrizeCounter = 0;

        void BtnShootingGallery_Click(object sender, EventArgs e)
        {
            int[] results = SimulateShootingGallery();
            DisplayShootingGallery(results);
        }
        public int[] SimulateShootingGallery()
        {
            int amountTurns = (int)numPeopleShooting.Value;
            int tempRand;
            int[] shotHitCounter = new int[amountTurns];

            // How many times people are going to try take shots
            for (int turn = 0; turn < amountTurns; turn++)
            {
                ownerTotal += playerBuyIn; // A customer paid
                playerPrizeCounter = 0; // Set the customers counter for shots to 0

                for (int level = 1; level <= playerShots; level++) // Do a single round of 3 turns for the current shooter
                {
                    tempRand = rand.Next(2); // Has a 50/50 chance of either hitting the plate or not

                    if (tempRand == 1)
                    {
                        ownerTotal -= plateCost; // subtract the cost of buying a new plate from the owners total amount
                        playerPrizeCounter++; // Increase the customer counter by one.
                    }
                }

                shotHitCounter[turn] = shotHitCounter[turn] + playerPrizeCounter; // Place the total amount of successful shots made for that customer

                if (playerPrizeCounter >= 3) // if someone got all 3 shots
                {
                    ownerTotal -= prizeCost; // minus from the owners total the cost of the prize
                }
            }

            return shotHitCounter;
        }
        void DisplayShootingGallery(int[] _results)
        {
            TxtDisplay.Text = "";
            TxtDisplay.Text += "Number of People:\tNumber of shots:" + Environment.NewLine;
            float amount = (float)numPeopleShooting.Value;

            for (int i = 1; i < _results.Length; i++)
            {
                TxtDisplay.Text += i + "\t\t" + _results[i] + Environment.NewLine;
            }

            TxtDisplay.Text += "Owner Total: " + ownerTotal.ToString("c");
            TxtDisplay.Text += Environment.NewLine + "Average amount made per person: " + (ownerTotal / amount).ToString("c");
        }

        // ------------------ Question 3 ------------------
        int studentAmountOfDays;
        int totalAmountOfDays;
        int probOfFailingClassTest = 15;
        int probOfFailingDrivingTest = 25;

        private void BtnDrivingSchool_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "";
            SimulateDrivingTests();
        }
        void SimulateDrivingTests()
        {
            int amount = (int)numDrivingTests.Value;

            for (int student = 1; student < amount + 1; student++)
            {
                studentAmountOfDays = 0;

                TxtDisplay.Text += "Student " + student + ": "; 
                ClassTest();
                YardAndRoadTest();

            }

            TxtDisplay.Text += "Total days: " + totalAmountOfDays;
            if (amount <= 0)
                amount = 1;

            MessageBox.Show("The average amount of days it takes to pass both tests is " + totalAmountOfDays / amount);
        }
        void ClassTest()
        {
            while (true)
            {
                studentAmountOfDays += 4;
                totalAmountOfDays += 4;

                int num = rand.Next(0, 101);
                if (num > probOfFailingClassTest)
                    break;

                TxtDisplay.Text += "Failed class test - ";
            }
            TxtDisplay.Text += "Passed class test - ";
        }
        void YardAndRoadTest()
        {
            while (true)
            {
                studentAmountOfDays += 10;
                totalAmountOfDays += 10;

                int num = rand.Next(0, 101);
                if (num > probOfFailingDrivingTest)
                    break;

                TxtDisplay.Text += "Failed driving test - ";
            }
            TxtDisplay.Text += "Passed driving test. " + Environment.NewLine + "Total days for student: " + studentAmountOfDays + Environment.NewLine;
        }

        // ------------------ Question 4 ------------------
        decimal playerRouletteTotal;
        float rouletteBuyIn = 7.5f;
        int ballPlacement;
        int[] rouletteValueFlag = new int[36];

        private void BtnRouletteWheel_Click(object sender, EventArgs e) => SimulateRouletteGame();
        void SimulateRouletteGame()
        {
            int amount = (int)numWheelSpins.Value; // uses a numeric up down control on the form
            playerRouletteTotal = 0;
            for (int i = 0; i < rouletteValueFlag.Length; i++) // set the array back to 0 for all values before next round of spins happen
                rouletteValueFlag[i] = 0;

            for (int games = 0; games < amount; games++)// amount of games
            {
                TxtDisplay.Text += "Player Total for game " + (games + 1) + ": " + playerRouletteTotal.ToString("c") + Environment.NewLine;
                playerRouletteTotal = 0;
                playerRouletteTotal -= Convert.ToDecimal(rouletteBuyIn); // player buys in for the first time

                while (true)
                {
                    // Get a random number
                    ballPlacement = rand.Next(0, 36);

                    // if landed on a unique number (one that hasn’t been rolled before)
                    if (rouletteValueFlag[ballPlacement] == 0)
                    {
                        // add 1 money to the players total
                        playerRouletteTotal++;
                        // mark off number so its not unique
                        rouletteValueFlag[ballPlacement] = 1;
                    }
                    // else you lose
                    else
                    {
                        // stop spinning and reset the valueFlags
                        for (int i = 0; i < rouletteValueFlag.Length; i++) // set the array back to 0 for all values before next round of spins happen
                            rouletteValueFlag[i] = 0;
                        break;
                    }
                }

            }
            // display the playerTotal and average amount made per game
            TxtDisplay.Text += "Total made: " + playerRouletteTotal.ToString("c") + Environment.NewLine + "Average Made per game: " + Convert.ToDecimal(playerRouletteTotal /amount).ToString("c");

        }

        // ------------------ Question 5 ------------------
        float moneySpendForThisSim;
        float playerToyTotal;
        int toyNumberValue;
        float toyBuyIn = 25f;
        int[] toyValueFlag = new int[28];

        private void BtnToyCollectables_Click(object sender, EventArgs e) 
        {
            TxtDisplay.Text = "";
            SimulateToyHelmet();
        } 
        void SimulateToyHelmet()
        {
            int amount = (int)numTimesPaidForToy.Value;
            for (int i = 0; i < toyValueFlag.Length; i++) // set the array back to 0 for all values before next round of spins happen
            {
                toyValueFlag[i] = 0;
            }
            moneySpendForThisSim = 0;
            playerToyTotal = 0;
            toyNumberValue = 0;

            for (int timesBoughtToy = 0; timesBoughtToy < amount; timesBoughtToy++)// amount of times they’ve bought the toy
            {
                for (int i = 0; i < toyValueFlag.Length; i++) // set the array back to 0 for all values before next round of spins happen
                {
                    toyValueFlag[i] = 0;
                }

                moneySpendForThisSim = 0;

                for (int uniqueToy = 1; uniqueToy <= 28; uniqueToy++)
                {
                    do
                    {
                        moneySpendForThisSim += toyBuyIn;
                        toyNumberValue = rand.Next(0, 28);
                    } while (toyValueFlag[toyNumberValue] == 1);

                    toyValueFlag[toyNumberValue] = 1;
                }

                TxtDisplay.Text += "Simulation " + (timesBoughtToy + 1) + ": " + moneySpendForThisSim.ToString("c") + Environment.NewLine;
                playerToyTotal += moneySpendForThisSim;

                }

            float average = playerToyTotal / amount;
            TxtDisplay.Text += "The average total spent to get all the unique toys is " + average.ToString("c");

            }
        }
    }
