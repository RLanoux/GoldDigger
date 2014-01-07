using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IT151GoldDigger
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///  Declare constants
        /// </summary>
        const String APP_VERSION = " v1.0";

        /// <summary>
        ///  Declare global variables
        /// </summary>
        Int32[,] miGarden = new Int32[10,10];
        Int32 iTries = 0;
        Int32 iGold = 0;
        Boolean bStart = false;
        MersenneTwister r = new MersenneTwister();
        

        /// <summary>
        /// DoEvents is a shortcut method to do the events of the interface.
        /// </summary>
        private void DoEvents()
        {
            Application.DoEvents();
        }

        private void DoWork(Int32 xCoordinate, Int32 yCoordinate)
        {
            if (bStart)
            {
                // Increment iTries and display it in the textbox
                iTries++;
                txtTries.Text = iTries.ToString();

                if (iGold == 9)
                {
                    MessageBox.Show("You Win!",
                        "Gold Digger " + APP_VERSION,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Reset();
                    btnStart.Enabled = true;
                    btnExit.Enabled = true;
                }
            }
            
        }

        /// <summary>
        /// SetStatus updates the status of the game in the status strip at the bottom.
        /// </summary>
        /// <param name="s"></param>
        private void SetStatus(String s)
        {
            tslStatus.Text = s;
            DoEvents();
        }
        /// <summary>
        /// This method establishes the game board, including placement of the gold nuggets
        /// and the land mine.
        /// </summary>
        private void Start()
        {
            // Clear all elements to zero in the array
            for (Int32 iY = 0; iY < 10; iY++)
            {
                for (Int32 iX = 0; iX < 10; iX++)
                {
                    miGarden[iX, iY] = 0;
                }
            }
            
            /**********************************************************************
             * Randomly select 9 sets of X and Y coordinates in the array         *
             * Keep selecting until a 0-value element is located                  *
             * For each pair, insert a 1 in the array to represent a gold nugget. *
             **********************************************************************/
            Int32 iXValue = 0;
            Int32 iYValue = 0;
            for (Int32 iNuggetPlacement = 0; iNuggetPlacement < 9; iNuggetPlacement++)
            {
                iXValue = r.Next(0, 10);
                iYValue = r.Next(0, 10);
                while (miGarden[iXValue, iYValue] != 0)
                {
                    iXValue = r.Next(0, 10);
                    iYValue = r.Next(0, 10);
                }
                miGarden[iXValue, iYValue] = 1;
            }

            /**************************************************************
             * Randomly select one more patch in the garden for the bomb  *
             * Keep selecting until a 0-value element (patch) is located. *
             **************************************************************/
            iXValue = r.Next(0, 10);
            iYValue = r.Next(0, 10);
            while (miGarden[iXValue, iYValue] != 0)
            {
                    iXValue = r.Next(0, 10);
                    iYValue = r.Next(0, 10);
            }
            miGarden[iXValue, iYValue] = -1;
            SetStatus("Gold Digger " + APP_VERSION + " is ready to play!");
        }

        private void Reset()
        {
            lblTile0000.BackColor = System.Drawing.Color.Green;
            lblTile0001.BackColor = System.Drawing.Color.Green;
            lblTile0002.BackColor = System.Drawing.Color.Green;
            lblTile0003.BackColor = System.Drawing.Color.Green;
            lblTile0004.BackColor = System.Drawing.Color.Green;
            lblTile0005.BackColor = System.Drawing.Color.Green;
            lblTile0006.BackColor = System.Drawing.Color.Green;
            lblTile0007.BackColor = System.Drawing.Color.Green;
            lblTile0008.BackColor = System.Drawing.Color.Green;
            lblTile0009.BackColor = System.Drawing.Color.Green;
            lblTile0100.BackColor = System.Drawing.Color.Green;
            lblTile0101.BackColor = System.Drawing.Color.Green;
            lblTile0102.BackColor = System.Drawing.Color.Green;
            lblTile0103.BackColor = System.Drawing.Color.Green;
            lblTile0104.BackColor = System.Drawing.Color.Green;
            lblTile0105.BackColor = System.Drawing.Color.Green;
            lblTile0106.BackColor = System.Drawing.Color.Green;
            lblTile0107.BackColor = System.Drawing.Color.Green;
            lblTile0108.BackColor = System.Drawing.Color.Green;
            lblTile0109.BackColor = System.Drawing.Color.Green;
            lblTile0200.BackColor = System.Drawing.Color.Green;
            lblTile0201.BackColor = System.Drawing.Color.Green;
            lblTile0202.BackColor = System.Drawing.Color.Green;
            lblTile0203.BackColor = System.Drawing.Color.Green;
            lblTile0204.BackColor = System.Drawing.Color.Green;
            lblTile0205.BackColor = System.Drawing.Color.Green;
            lblTile0206.BackColor = System.Drawing.Color.Green;
            lblTile0207.BackColor = System.Drawing.Color.Green;
            lblTile0208.BackColor = System.Drawing.Color.Green;
            lblTile0209.BackColor = System.Drawing.Color.Green;
            lblTile0300.BackColor = System.Drawing.Color.Green;
            lblTile0301.BackColor = System.Drawing.Color.Green;
            lblTile0302.BackColor = System.Drawing.Color.Green;
            lblTile0303.BackColor = System.Drawing.Color.Green;
            lblTile0304.BackColor = System.Drawing.Color.Green;
            lblTile0305.BackColor = System.Drawing.Color.Green;
            lblTile0306.BackColor = System.Drawing.Color.Green;
            lblTile0307.BackColor = System.Drawing.Color.Green;
            lblTile0308.BackColor = System.Drawing.Color.Green;
            lblTile0309.BackColor = System.Drawing.Color.Green;
            lblTile0400.BackColor = System.Drawing.Color.Green;
            lblTile0401.BackColor = System.Drawing.Color.Green;
            lblTile0402.BackColor = System.Drawing.Color.Green;
            lblTile0403.BackColor = System.Drawing.Color.Green;
            lblTile0404.BackColor = System.Drawing.Color.Green;
            lblTile0405.BackColor = System.Drawing.Color.Green;
            lblTile0406.BackColor = System.Drawing.Color.Green;
            lblTile0407.BackColor = System.Drawing.Color.Green;
            lblTile0408.BackColor = System.Drawing.Color.Green;
            lblTile0409.BackColor = System.Drawing.Color.Green;
            lblTile0500.BackColor = System.Drawing.Color.Green;
            lblTile0501.BackColor = System.Drawing.Color.Green;
            lblTile0502.BackColor = System.Drawing.Color.Green;
            lblTile0503.BackColor = System.Drawing.Color.Green;
            lblTile0504.BackColor = System.Drawing.Color.Green;
            lblTile0505.BackColor = System.Drawing.Color.Green;
            lblTile0506.BackColor = System.Drawing.Color.Green;
            lblTile0507.BackColor = System.Drawing.Color.Green;
            lblTile0508.BackColor = System.Drawing.Color.Green;
            lblTile0509.BackColor = System.Drawing.Color.Green;
            lblTile0600.BackColor = System.Drawing.Color.Green;
            lblTile0601.BackColor = System.Drawing.Color.Green;
            lblTile0602.BackColor = System.Drawing.Color.Green;
            lblTile0603.BackColor = System.Drawing.Color.Green;
            lblTile0604.BackColor = System.Drawing.Color.Green;
            lblTile0605.BackColor = System.Drawing.Color.Green;
            lblTile0606.BackColor = System.Drawing.Color.Green;
            lblTile0607.BackColor = System.Drawing.Color.Green;
            lblTile0608.BackColor = System.Drawing.Color.Green;
            lblTile0609.BackColor = System.Drawing.Color.Green;
            lblTile0700.BackColor = System.Drawing.Color.Green;
            lblTile0701.BackColor = System.Drawing.Color.Green;
            lblTile0702.BackColor = System.Drawing.Color.Green;
            lblTile0703.BackColor = System.Drawing.Color.Green;
            lblTile0704.BackColor = System.Drawing.Color.Green;
            lblTile0705.BackColor = System.Drawing.Color.Green;
            lblTile0706.BackColor = System.Drawing.Color.Green;
            lblTile0707.BackColor = System.Drawing.Color.Green;
            lblTile0708.BackColor = System.Drawing.Color.Green;
            lblTile0709.BackColor = System.Drawing.Color.Green;
            lblTile0800.BackColor = System.Drawing.Color.Green;
            lblTile0801.BackColor = System.Drawing.Color.Green;
            lblTile0802.BackColor = System.Drawing.Color.Green;
            lblTile0803.BackColor = System.Drawing.Color.Green;
            lblTile0804.BackColor = System.Drawing.Color.Green;
            lblTile0805.BackColor = System.Drawing.Color.Green;
            lblTile0806.BackColor = System.Drawing.Color.Green;
            lblTile0807.BackColor = System.Drawing.Color.Green;
            lblTile0808.BackColor = System.Drawing.Color.Green;
            lblTile0809.BackColor = System.Drawing.Color.Green;
            lblTile0900.BackColor = System.Drawing.Color.Green;
            lblTile0901.BackColor = System.Drawing.Color.Green;
            lblTile0902.BackColor = System.Drawing.Color.Green;
            lblTile0903.BackColor = System.Drawing.Color.Green;
            lblTile0904.BackColor = System.Drawing.Color.Green;
            lblTile0905.BackColor = System.Drawing.Color.Green;
            lblTile0906.BackColor = System.Drawing.Color.Green;
            lblTile0907.BackColor = System.Drawing.Color.Green;
            lblTile0908.BackColor = System.Drawing.Color.Green;
            lblTile0909.BackColor = System.Drawing.Color.Green;
            btnStart.Enabled = true;
            btnExit.Enabled = true;
            iTries = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            bStart = true;
            btnStart.Enabled = false;
            btnExit.Enabled = false;
            Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tslCopyright.Text = (char)169 + " 2013 H. W. Gould IT151 Midterm";
            DoEvents();
        }

        private void lblTile0209_Click(object sender, EventArgs e)
        {
            DoWork(2, 9);
            if (miGarden[2, 9] == 1)
            {
                lblTile0209.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[2, 9] == -1)
            {
                lblTile0209.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[2, 9] == 0)
            {
                lblTile0209.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0208_Click(object sender, EventArgs e)
        {
            DoWork(2, 8);
            if (miGarden[2, 8] == 1)
            {
                lblTile0208.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[2, 8] == -1)
            {
                lblTile0208.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[2, 8] == 0)
            {
                lblTile0208.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0207_Click(object sender, EventArgs e)
        {
            DoWork(2, 7);
            if (miGarden[2, 7] == 1)
            {
                lblTile0207.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[2, 7] == -1)
            {
                lblTile0207.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[2, 7] == 0)
            {
                lblTile0207.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0206_Click(object sender, EventArgs e)
        {
            DoWork(2, 6);
            if (miGarden[2, 6] == 1)
            {
                lblTile0206.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[2, 6] == -1)
            {
                lblTile0206.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[2, 6] == 0)
            {
                lblTile0206.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0205_Click(object sender, EventArgs e)
        {
            DoWork(2, 5);
            if (miGarden[2, 5] == 1)
            {
                lblTile0205.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[2, 5] == -1)
            {
                lblTile0205.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[2, 5] == 0)
            {
                lblTile0205.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0204_Click(object sender, EventArgs e)
        {
            DoWork(2, 4);
            if (miGarden[2, 4] == 1)
            {
                lblTile0204.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[2, 4] == -1)
            {
                lblTile0204.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[2, 4] == 0)
            {
                lblTile0204.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0203_Click(object sender, EventArgs e)
        {
            DoWork(2, 3);
            if (miGarden[2, 3] == 1)
            {
                lblTile0203.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[2, 3] == -1)
            {
                lblTile0203.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[2, 3] == 0)
            {
                lblTile0203.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0202_Click(object sender, EventArgs e)
        {
            DoWork(2, 2);
            if (miGarden[2, 2] == 1)
            {
                lblTile0202.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[2, 2] == -1)
            {
                lblTile0202.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[2, 2] == 0)
            {
                lblTile0202.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0201_Click(object sender, EventArgs e)
        {
            DoWork(2, 1);
            if (miGarden[2, 1] == 1)
            {
                lblTile0201.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[2, 1] == -1)
            {
                lblTile0201.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[2, 1] == 0)
            {
                lblTile0201.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0200_Click(object sender, EventArgs e)
        {
            DoWork(2, 0);
            if (miGarden[2, 0] == 1)
            {
                lblTile0200.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[2, 0] == -1)
            {
                lblTile0200.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[2, 0] == 0)
            {
                lblTile0200.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0109_Click(object sender, EventArgs e)
        {
            DoWork(1, 9);
            if (miGarden[1, 9] == 1)
            {
                lblTile0109.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[1, 9] == -1)
            {
                lblTile0109.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[1, 9] == 0)
            {
                lblTile0109.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0108_Click(object sender, EventArgs e)
        {
            DoWork(1, 8);
            if (miGarden[1, 8] == 1)
            {
                lblTile0108.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[1, 8] == -1)
            {
                lblTile0108.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[1, 8] == 0)
            {
                lblTile0108.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0107_Click(object sender, EventArgs e)
        {
            DoWork(1, 7);
            if (miGarden[1, 7] == 1)
            {
                lblTile0107.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[1, 7] == -1)
            {
                lblTile0107.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[1, 7] == 0)
            {
                lblTile0107.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0106_Click(object sender, EventArgs e)
        {
            DoWork(1, 6);
            if (miGarden[1, 6] == 1)
            {
                lblTile0106.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[1, 6] == -1)
            {
                lblTile0106.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[1, 6] == 0)
            {
                lblTile0106.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0105_Click(object sender, EventArgs e)
        {
            DoWork(1, 5);
            if (miGarden[1, 5] == 1)
            {
                lblTile0105.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[1, 5] == -1)
            {
                lblTile0105.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[1, 5] == 0)
            {
                lblTile0105.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0104_Click(object sender, EventArgs e)
        {
            DoWork(1, 4);
            if (miGarden[1, 4] == 1)
            {
                lblTile0104.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[1, 4] == -1)
            {
                lblTile0104.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[1, 4] == 0)
            {
                lblTile0104.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0103_Click(object sender, EventArgs e)
        {
            DoWork(1, 3);
            if (miGarden[1, 3] == 1)
            {
                lblTile0103.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[1, 3] == -1)
            {
                lblTile0103.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[1, 3] == 0)
            {
                lblTile0103.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0102_Click(object sender, EventArgs e)
        {
            DoWork(1, 2);
            if (miGarden[1, 2] == 1)
            {
                lblTile0102.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[1, 2] == -1)
            {
                lblTile0102.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[1, 2] == 0)
            {
                lblTile0102.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0101_Click(object sender, EventArgs e)
        {
            DoWork(1, 1);
            if (miGarden[1, 1] == 1)
            {
                lblTile0101.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[1, 1] == -1)
            {
                lblTile0101.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[1, 1] == 0)
            {
                lblTile0101.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0100_Click(object sender, EventArgs e)
        {
            DoWork(1, 0);
            if (miGarden[1, 0] == 1)
            {
                lblTile0100.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[1, 0] == -1)
            {
                lblTile0100.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[1, 0] == 0)
            {
                lblTile0100.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0909_Click(object sender, EventArgs e)
        {
            DoWork(9, 9);
            if (miGarden[9, 9] == 1)
            {
                lblTile0909.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[9, 9] == -1)
            {
                lblTile0909.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }
            else if (miGarden[9, 9] == 0)
            {
                lblTile0909.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0908_Click(object sender, EventArgs e)
        {
            DoWork(9, 8);
            if (miGarden[9, 8] == 1)
            {
                lblTile0908.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[9, 8] == -1)
            {
                lblTile0908.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }
            else if (miGarden[9, 8] == 0)
            {
                lblTile0908.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0907_Click(object sender, EventArgs e)
        {
            DoWork(9, 7);
            if (miGarden[9, 7] == 1)
            {
                lblTile0907.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[9, 7] == -1)
            {
                lblTile0907.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }
            else if (miGarden[9, 7] == 0)
            {
                lblTile0907.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0906_Click(object sender, EventArgs e)
        {
            DoWork(9, 6);
            if (miGarden[9, 6] == 1)
            {
                lblTile0906.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[9, 6] == -1)
            {
                lblTile0906.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }
            else if (miGarden[9, 6] == 0)
            {
                lblTile0906.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0905_Click(object sender, EventArgs e)
        {
            DoWork(9, 5);
            if (miGarden[9, 5] == 1)
            {
                lblTile0905.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[9, 5] == -1)
            {
                lblTile0905.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }
            else if (miGarden[9, 5] == 0)
            {
                lblTile0905.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0904_Click(object sender, EventArgs e)
        {
            DoWork(9, 4);
            if (miGarden[9, 4] == 1)
            {
                lblTile0904.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[9, 4] == -1)
            {
                lblTile0904.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }
            else if (miGarden[9, 4] == 0)
            {
                lblTile0904.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0903_Click(object sender, EventArgs e)
        {
            DoWork(9, 3); 
            if (miGarden[9, 3] == 1)
            {
                lblTile0903.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[9, 3] == -1)
            {
                lblTile0903.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }
            else if (miGarden[9, 3] == 0)
            {
                lblTile0903.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0902_Click(object sender, EventArgs e)
        {
            DoWork(9, 2);
            if (miGarden[9, 2] == 1)
            {
                lblTile0902.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[9, 2] == -1)
            {
                lblTile0902.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }
            else if (miGarden[9, 2] == 0)
            {
                lblTile0902.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0901_Click(object sender, EventArgs e)
        {
            DoWork(9, 1);
            if (miGarden[9, 1] == 1)
            {
                lblTile0901.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[9, 1] == -1)
            {
                lblTile0901.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }
            else if (miGarden[9, 1] == 0)
            {
                lblTile0901.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0900_Click(object sender, EventArgs e)
        {
            DoWork(9, 0);
            if (miGarden[9, 0] == 1)
            {
                lblTile0900.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[9, 0] == -1)
            {
                lblTile0900.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }
            else if (miGarden[9, 0] == 0)
            {
                lblTile0900.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0809_Click(object sender, EventArgs e)
        {
            DoWork(8, 9);
            if (miGarden[8, 9] == 1)
            {
                lblTile0809.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[8, 9] == -1)
            {
                lblTile0809.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[8, 9] == 0)
            {
                lblTile0809.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0808_Click(object sender, EventArgs e)
        {
            DoWork(8, 8);
            if (miGarden[8, 8] == 1)
            {
                lblTile0808.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[8, 8] == -1)
            {
                lblTile0808.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[8, 8] == 0)
            {
                lblTile0808.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0807_Click(object sender, EventArgs e)
        {
            DoWork(8, 7);
            if (miGarden[8, 7] == 1)
            {
                lblTile0807.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[8, 7] == -1)
            {
                lblTile0807.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }
            else if (miGarden[8, 7] == 0)
            {
                lblTile0807.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0806_Click(object sender, EventArgs e)
        {
            DoWork(8, 6);
            if (miGarden[8, 6] == 1)
            {
                lblTile0806.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[8, 6] == -1)
            {
                lblTile0806.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[8, 6] == 0)
            {
                lblTile0806.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0805_Click(object sender, EventArgs e)
        {
            DoWork(8, 5);
            if (miGarden[8, 5] == 1)
            {
                lblTile0805.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[8, 5] == -1)
            {
                lblTile0805.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[8, 5] == 0)
            {
                lblTile0805.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0804_Click(object sender, EventArgs e)
        {
            DoWork(8, 4);
            if (miGarden[8, 4] == 1)
            {
                lblTile0804.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[8, 4] == -1)
            {
                lblTile0804.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[8, 4] == 0)
            {
                lblTile0804.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0803_Click(object sender, EventArgs e)
        {
            DoWork(8, 3);
            if (miGarden[8, 3] == 1)
            {
                lblTile0803.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[8, 3] == -1)
            {
                lblTile0803.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[8, 3] == 0)
            {
                lblTile0803.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0802_Click(object sender, EventArgs e)
        {
            DoWork(8, 2);
            if (miGarden[8, 2] == 1)
            {
                lblTile0802.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[8, 2] == -1)
            {
                lblTile0802.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[8, 2] == 0)
            {
                lblTile0802.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0801_Click(object sender, EventArgs e)
        {
            DoWork(8, 1);
            if (miGarden[8, 1] == 1)
            {
                lblTile0801.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[8, 1] == -1)
            {
                lblTile0801.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[8, 1] == 0)
            {
                lblTile0801.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0800_Click(object sender, EventArgs e)
        {
            DoWork(8, 0);
            if (miGarden[8, 0] == 1)
            {
                lblTile0800.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[8, 0] == -1)
            {
                lblTile0800.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[8, 0] == 0)
            {
                lblTile0800.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0709_Click(object sender, EventArgs e)
        {
            DoWork(7, 9);
            if (miGarden[7, 9] == 1)
            {
                lblTile0709.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[7, 9] == -1)
            {
                lblTile0709.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[7, 9] == 0)
            {
                lblTile0709.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0708_Click(object sender, EventArgs e)
        {
            DoWork(7, 8);
            if (miGarden[7, 8] == 1)
            {
                lblTile0708.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[7, 8] == -1)
            {
                lblTile0708.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[7, 8] == 0)
            {
                lblTile0708.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0707_Click(object sender, EventArgs e)
        {
            DoWork(7, 7);
            if (miGarden[7, 7] == 1)
            {
                lblTile0707.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[7, 7] == -1)
            {
                lblTile0707.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[7, 7] == 0)
            {
                lblTile0707.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0706_Click(object sender, EventArgs e)
        {
            DoWork(7, 6);
            if (miGarden[7, 6] == 1)
            {
                lblTile0706.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[7, 6] == -1)
            {
                lblTile0706.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[7, 6] == 0)
            {
                lblTile0706.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0705_Click(object sender, EventArgs e)
        {
            DoWork(7, 5);
            if (miGarden[7, 5] == 1)
            {
                lblTile0705.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[7, 5] == -1)
            {
                lblTile0705.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[7, 5] == 0)
            {
                lblTile0705.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0704_Click(object sender, EventArgs e)
        {
            DoWork(7, 4);
            if (miGarden[7, 4] == 1)
            {
                lblTile0704.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[7, 4] == -1)
            {
                lblTile0704.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[7, 4] == 0)
            {
                lblTile0704.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0703_Click(object sender, EventArgs e)
        {
            DoWork(7, 3);
            if (miGarden[7, 3] == 1)
            {
                lblTile0703.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[7, 3] == -1)
            {
                lblTile0703.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[7, 3] == 0)
            {
                lblTile0703.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0702_Click(object sender, EventArgs e)
        {
            DoWork(7, 2);
            if (miGarden[7, 2] == 1)
            {
                lblTile0702.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[7, 2] == -1)
            {
                lblTile0702.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[7, 2] == 0)
            {
                lblTile0702.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0701_Click(object sender, EventArgs e)
        {
            DoWork(7, 1);
            if (miGarden[7, 1] == 1)
            {
                lblTile0701.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[7, 1] == -1)
            {
                lblTile0701.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[7, 1] == 0)
            {
                lblTile0701.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0700_Click(object sender, EventArgs e)
        {
            DoWork(7, 0);
            if (miGarden[7, 0] == 1)
            {
                lblTile0700.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[7, 0] == -1)
            {
                lblTile0700.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[7, 0] == 0)
            {
                lblTile0700.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0609_Click(object sender, EventArgs e)
        {
            DoWork(6, 9);
            if (miGarden[6, 9] == 1)
            {
                lblTile0609.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[6, 9] == -1)
            {
                lblTile0609.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[6, 9] == 0)
            {
                lblTile0609.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0608_Click(object sender, EventArgs e)
        {
            DoWork(6, 8);
            if (miGarden[6, 8] == 1)
            {
                lblTile0608.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[6, 8] == -1)
            {
                lblTile0608.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[6, 8] == 0)
            {
                lblTile0608.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0607_Click(object sender, EventArgs e)
        {
            DoWork(6, 7);
            if (miGarden[6, 7] == 1)
            {
                lblTile0607.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[6, 7] == -1)
            {
                lblTile0607.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[6, 7] == 0)
            {
                lblTile0607.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0606_Click(object sender, EventArgs e)
        {
            DoWork(6, 6);
            if (miGarden[6, 6] == 1)
            {
                lblTile0606.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[6, 6] == -1)
            {
                lblTile0606.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[6, 6] == 0)
            {
                lblTile0606.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0605_Click(object sender, EventArgs e)
        {
            DoWork(6, 5);
            if (miGarden[6, 5] == 1)
            {
                lblTile0605.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[6, 5] == -1)
            {
                lblTile0605.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[6, 5] == 0)
            {
                lblTile0605.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0604_Click(object sender, EventArgs e)
        {
            DoWork(6, 4);
            if (miGarden[6, 4] == 1)
            {
                lblTile0604.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[6, 4] == -1)
            {
                lblTile0604.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[6, 4] == 0)
            {
                lblTile0604.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0603_Click(object sender, EventArgs e)
        {
            DoWork(6, 3);
            if (miGarden[6, 3] == 1)
            {
                lblTile0603.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[6, 3] == -1)
            {
                lblTile0603.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[6, 3] == 0)
            {
                lblTile0603.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0602_Click(object sender, EventArgs e)
        {
            DoWork(6, 2);
            if (miGarden[6, 2] == 1)
            {
                lblTile0602.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[6, 2] == -1)
            {
                lblTile0602.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[6, 2] == 0)
            {
                lblTile0602.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0601_Click(object sender, EventArgs e)
        {
            DoWork(6, 1);
            if (miGarden[6, 1] == 1)
            {
                lblTile0601.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[6, 1] == -1)
            {
                lblTile0601.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[6, 1] == 0)
            {
                lblTile0601.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0600_Click(object sender, EventArgs e)
        {
            DoWork(6, 0);
            if (miGarden[6, 0] == 1)
            {
                lblTile0600.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[6, 0] == -1)
            {
                lblTile0600.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[6, 0] == 0)
            {
                lblTile0600.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0509_Click(object sender, EventArgs e)
        {
            DoWork(5, 9);
            if (miGarden[5, 9] == 1)
            {
                lblTile0509.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[5, 9] == -1)
            {
                lblTile0509.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[5, 9] == 0)
            {
                lblTile0509.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0508_Click(object sender, EventArgs e)
        {
            DoWork(5, 8);
            if (miGarden[5, 8] == 1)
            {
                lblTile0508.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[5, 8] == -1)
            {
                lblTile0508.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[5, 8] == 0)
            {
                lblTile0508.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0507_Click(object sender, EventArgs e)
        {
            DoWork(5, 7);
            if (miGarden[5, 7] == 1)
            {
                lblTile0507.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[5, 7] == -1)
            {
                lblTile0507.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[5, 7] == 0)
            {
                lblTile0507.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0506_Click(object sender, EventArgs e)
        {
            DoWork(5, 6);
            if (miGarden[5, 6] == 1)
            {
                lblTile0506.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[5, 6] == -1)
            {
                lblTile0506.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[5, 6] == 0)
            {
                lblTile0506.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0505_Click(object sender, EventArgs e)
        {
            DoWork(5, 5);
            if (miGarden[5, 5] == 1)
            {
                lblTile0505.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[5, 5] == -1)
            {
                lblTile0505.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[5, 5] == 0)
            {
                lblTile0505.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0504_Click(object sender, EventArgs e)
        {
            DoWork(5, 4);
            if (miGarden[5, 4] == 1)
            {
                lblTile0504.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[5, 4] == -1)
            {
                lblTile0504.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[5, 4] == 0)
            {
                lblTile0504.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0503_Click(object sender, EventArgs e)
        {
            DoWork(5, 3);
            if (miGarden[5, 3] == 1)
            {
                lblTile0503.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[5, 3] == -1)
            {
                lblTile0503.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[5, 3] == 0)
            {
                lblTile0503.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0502_Click(object sender, EventArgs e)
        {
            DoWork(5, 2);
            if (miGarden[5, 2] == 1)
            {
                lblTile0502.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[5, 2] == -1)
            {
                lblTile0502.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[5, 2] == 0)
            {
                lblTile0502.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0501_Click(object sender, EventArgs e)
        {
            DoWork(5, 1);
            if (miGarden[5, 1] == 1)
            {
                lblTile0501.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[5, 1] == -1)
            {
                lblTile0501.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[5, 1] == 0)
            {
                lblTile0501.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0500_Click(object sender, EventArgs e)
        {
            DoWork(5, 0);
            if (miGarden[5, 0] == 1)
            {
                lblTile0500.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[5, 0] == -1)
            {
                lblTile0500.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[5, 0] == 0)
            {
                lblTile0500.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0409_Click(object sender, EventArgs e)
        {
            DoWork(4, 9);
            if (miGarden[4, 9] == 1)
            {
                lblTile0409.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[4, 9] == -1)
            {
                lblTile0409.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[4, 9] == 0)
            {
                lblTile0409.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0408_Click(object sender, EventArgs e)
        {
            DoWork(4, 8);
            if (miGarden[4, 8] == 1)
            {
                lblTile0408.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[4, 8] == -1)
            {
                lblTile0408.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[4, 8] == 0)
            {
                lblTile0408.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0407_Click(object sender, EventArgs e)
        {
            DoWork(4, 7);
            if (miGarden[4, 7] == 1)
            {
                lblTile0407.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[4, 7] == -1)
            {
                lblTile0407.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[4, 7] == 0)
            {
                lblTile0407.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0406_Click(object sender, EventArgs e)
        {
            DoWork(4, 6);
            if (miGarden[4, 6] == 1)
            {
                lblTile0406.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[4, 6] == -1)
            {
                lblTile0406.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[4, 6] == 0)
            {
                lblTile0406.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0405_Click(object sender, EventArgs e)
        {
            DoWork(4, 5);
            if (miGarden[4, 5] == 1)
            {
                lblTile0405.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[4, 5] == -1)
            {
                lblTile0405.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[4, 5] == 0)
            {
                lblTile0405.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0404_Click(object sender, EventArgs e)
        {
            DoWork(4, 4);
            if (miGarden[4, 4] == 1)
            {
                lblTile0404.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[4, 4] == -1)
            {
                lblTile0404.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[4, 4] == 0)
            {
                lblTile0404.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0403_Click(object sender, EventArgs e)
        {
            DoWork(4, 3);
            if (miGarden[4, 3] == 1)
            {
                lblTile0403.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[4, 3] == -1)
            {
                lblTile0403.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[4, 3] == 0)
            {
                lblTile0403.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0402_Click(object sender, EventArgs e)
        {
            DoWork(4, 2);
            if (miGarden[4, 2] == 1)
            {
                lblTile0402.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[4, 2] == -1)
            {
                lblTile0402.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[4, 2] == 0)
            {
                lblTile0402.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0401_Click(object sender, EventArgs e)
        {
            DoWork(4, 1);
            if (miGarden[4, 1] == 1)
            {
                lblTile0401.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[4, 1] == -1)
            {
                lblTile0401.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[4, 1] == 0)
            {
                lblTile0401.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0400_Click(object sender, EventArgs e)
        {
            DoWork(4, 0);
            if (miGarden[4, 0] == 1)
            {
                lblTile0400.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[4, 0] == -1)
            {
                lblTile0400.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[4, 0] == 0)
            {
                lblTile0400.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0309_Click(object sender, EventArgs e)
        {
            DoWork(3, 9);
            if (miGarden[3, 9] == 1)
            {
                lblTile0309.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[3, 9] == -1)
            {
                lblTile0309.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[3, 9] == 0)
            {
                lblTile0309.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0308_Click(object sender, EventArgs e)
        {
            DoWork(3, 8);
            if (miGarden[3, 8] == 1)
            {
                lblTile0308.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[3, 8] == -1)
            {
                lblTile0308.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[3, 8] == 0)
            {
                lblTile0308.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0307_Click(object sender, EventArgs e)
        {
            DoWork(3, 7);
            if (miGarden[3, 7] == 1)
            {
                lblTile0307.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[3, 7] == -1)
            {
                lblTile0307.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[3, 7] == 0)
            {
                lblTile0307.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0306_Click(object sender, EventArgs e)
        {
            DoWork(3, 6);
            if (miGarden[3, 6] == 1)
            {
                lblTile0306.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[3, 6] == -1)
            {
                lblTile0306.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[3, 6] == 0)
            {
                lblTile0306.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0305_Click(object sender, EventArgs e)
        {
            DoWork(3, 5);
            if (miGarden[3, 5] == 1)
            {
                lblTile0305.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[3, 5] == -1)
            {
                lblTile0305.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[3, 5] == 0)
            {
                lblTile0305.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0304_Click(object sender, EventArgs e)
        {
            DoWork(3, 4);
            if (miGarden[3, 4] == 1)
            {
                lblTile0304.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[3, 4] == -1)
            {
                lblTile0304.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[3, 4] == 0)
            {
                lblTile0304.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0303_Click(object sender, EventArgs e)
        {
            DoWork(3, 3);
            if (miGarden[3, 3] == 1)
            {
                lblTile0303.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[3, 3] == -1)
            {
                lblTile0303.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[3, 3] == 0)
            {
                lblTile0303.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0302_Click(object sender, EventArgs e)
        {
            DoWork(3, 2);
            if (miGarden[3, 2] == 1)
            {
                lblTile0302.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[3, 2] == -1)
            {
                lblTile0302.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[3, 2] == 0)
            {
                lblTile0302.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0301_Click(object sender, EventArgs e)
        {
            DoWork(3, 1);
            if (miGarden[3, 0] == 1)
            {
                lblTile0301.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[3, 0] == -1)
            {
                lblTile0301.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[3, 0] == 0)
            {
                lblTile0301.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0300_Click(object sender, EventArgs e)
        {
            DoWork(3, 0);
            if (miGarden[3, 0] == 1)
            {
                lblTile0300.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[3, 0] == -1)
            {
                lblTile0300.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[3, 0] == 0)
            {
                lblTile0300.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0009_Click(object sender, EventArgs e)
        {
            DoWork(0, 9); 
            if (miGarden[0, 9] == 1)
            {
                lblTile0009.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[0, 9] == -1)
            {
                lblTile0009.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[0, 9] == 0)
            {
                lblTile0009.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0008_Click(object sender, EventArgs e)
        {
            DoWork(0, 8);
            if (miGarden[0, 8] == 1)
            {
                lblTile0008.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[0, 8] == -1)
            {
                lblTile0008.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[0, 8] == 0)
            {
                lblTile0008.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0007_Click(object sender, EventArgs e)
        {
            DoWork(0, 7);
            if (miGarden[0, 7] == 1)
            {
                lblTile0007.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[0, 7] == -1)
            {
                lblTile0007.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }
            else if (miGarden[0, 7] == 0)
            {
                lblTile0007.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0006_Click(object sender, EventArgs e)
        {
            DoWork(0, 6);
            if (miGarden[0, 6] == 1)
            {
                lblTile0006.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[0, 6] == -1)
            {
                lblTile0006.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[0, 6] == 0)
            {
                lblTile0006.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0005_Click(object sender, EventArgs e)
        {
            DoWork(0, 5);
            if (miGarden[0, 5] == 1)
            {
                lblTile0005.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[0, 5] == -1)
            {
                lblTile0005.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[0, 5] == 0)
            {
                lblTile0005.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0004_Click(object sender, EventArgs e)
        {
            DoWork(0, 4);
            if (miGarden[0, 4] == 1)
            {
                lblTile0004.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[0, 4] == -1)
            {
                lblTile0004.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger " + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[0,4] == 0)
            {
                lblTile0004.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0003_Click(object sender, EventArgs e)
        {
            DoWork(0, 3);
            if (miGarden[0, 3] == 1)
            {
                lblTile0003.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[0, 3] == -1)
            {
                lblTile0003.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger" + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[0, 3] == 0)
            {
                lblTile0003.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0002_Click(object sender, EventArgs e)
        {
            if (miGarden[0, 2] == 1)
            {
                lblTile0002.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[0, 2] == -1)
            {
                lblTile0002.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger" + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[0,2] == 0)
            {
                lblTile0002.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0001_Click(object sender, EventArgs e)
        {
            DoWork(0, 1);
            if (miGarden[0, 1] == 1)
            {
                lblTile0001.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[0, 1] == -1)
            {
                lblTile0001.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger" + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }

            else if (miGarden[0,1] == 0)
            {
                lblTile0001.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void lblTile0000_Click(object sender, EventArgs e)
        {
            DoWork(0, 0);
            if (miGarden[0, 0] == 1)
            {
                lblTile0000.BackColor = System.Drawing.Color.Gold;
                iGold++;
            }
            else if (miGarden[0, 0] == -1)
            {
                lblTile0000.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("You Lose!",
                    "Gold Digger" + APP_VERSION,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (miGarden[0,0] == 0)
            {
                lblTile0000.BackColor = System.Drawing.Color.Tan;
            }
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The object of this game is to find the 9 gold pieces without hitting the dynamite that " +
            "your coworker left. You will click each individual tile " +
            "until a) you find all nine pieces of gold, or b) you get blown to smithereens by the dynamite.",
            "Gold Digger" + APP_VERSION,
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Awwww. Tired of breaking your back to make someone else richer?",
                "Gold Digger" + APP_VERSION,
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            this.Close();
            Application.Exit();
        }

    } // End of class Program

} // end of namespace IT151GoldDigger
