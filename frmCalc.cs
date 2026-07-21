using RoundButton;
using SimpleCalculator.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }
        //*------------------------------------------------------------------------*//
        //*                           General Attributes                           *//
        //*------------------------------------------------------------------------*//
        //Calculation Variables
        private double num1 = 0f;
        private double num2 = 0f;
        private string operation = string.Empty;

        // DAY-DARK Mode Variable
        private bool colored = true;

        // Moving Screen Variables
        private int move;
        private int movX;
        private int movY;

        //*------------------------------------------------------------------------------*//
        //*                           DAY-DARK MODE (METHODS)                            *//
        //*------------------------------------------------------------------------------*//
        void DayMode()
        {
            colored = false;
            btnStyleMode.Image = Resources.DayMode;
            pnlCalcBody.BackColor = Color.FromArgb(241, 243, 249);
            pnlOperation.BackColor = Color.FromArgb(241, 243, 249);
            pnlOutControls.BackColor = Color.FromArgb(241, 243, 249);
            pnlTitle.BackColor = Color.FromArgb(241, 243, 249);

            lbl_Operations.ForeColor = Color.Black;
            lbl_Result.ForeColor = Color.Black;

            fbtnEqual.Image = Resources.Equal;
            fbtnEqual.BackColor = Color.Blue;

            fbtnDot.ForeColor = Color.Black;
            fbtnDot.BackColor = Color.FromArgb(223, 234, 251);

            fbtnZero.ForeColor = Color.Black;
            fbtnZero.BackColor = Color.White;

            fbtnOne.ForeColor = Color.Black;
            fbtnOne.BackColor = Color.White;

            fbtnTwo.ForeColor = Color.Black;
            fbtnTwo.BackColor = Color.White;

            fbtnThree.ForeColor = Color.Black;
            fbtnThree.BackColor = Color.White;

            fbtnFour.ForeColor = Color.Black;
            fbtnFour.BackColor = Color.White;

            fbtnFive.ForeColor = Color.Black;
            fbtnFive.BackColor = Color.White;

            fbtnSix.ForeColor = Color.Black;
            fbtnSix.BackColor = Color.White;

            fbtnSeven.ForeColor = Color.Black;
            fbtnSeven.BackColor = Color.White;

            fbtnEight.ForeColor = Color.Black;
            fbtnEight.BackColor = Color.White;

            fbtnNine.ForeColor = Color.Black;
            fbtnNine.BackColor = Color.White;

            fbtnPercent.ForeColor = Color.Black;
            fbtnPercent.BackColor = Color.FromArgb(223, 234, 251);

            fbtnClearAll.ForeColor = Color.Black;
            fbtnClearAll.BackColor = Color.FromArgb(223, 234, 251);

            fbtnClearTemp.ForeColor = Color.Black;
            fbtnClearTemp.BackColor = Color.FromArgb(223, 234, 251);

            fbtnPM.ForeColor = Color.Black;
            fbtnPM.BackColor = Color.FromArgb(223, 234, 251);

            fbtnAdd.Image = Resources.Addition_Dark;
            fbtnAdd.BackColor = Color.FromArgb(223, 234, 251);

            fbtnMinus.Image = Resources.Minus_Dark;
            fbtnMinus.BackColor = Color.FromArgb(223, 234, 251);

            fbtnDivision.Image = Resources.Division_Dark;
            fbtnDivision.BackColor = Color.FromArgb(223, 234, 251);

            fbtnMulti.Image = Resources.Multi_Dark;
            fbtnMulti.BackColor = Color.FromArgb(223, 234, 251);

            fbtnSquare.Image = Resources.SquareSymbol_Dark;
            fbtnSquare.BackColor = Color.FromArgb(223, 234, 251);

            fbtnSquareRoot.Image = Resources.Square_Dark;
            fbtnSquareRoot.BackColor = Color.FromArgb(223, 234, 251);

            fbtn1X.Image = Resources.symbol_Dark;
            fbtn1X.BackColor = Color.FromArgb(223, 234, 251);

            fbtnBackspace.Image = Resources.Backspase_Dark;
            fbtnBackspace.BackColor = Color.FromArgb(223, 234, 251);

            btnMenu.Image = Resources.Menu_Dark;
            btnExit.Image = Resources.CloseIcon_Dark;
            btnMaximized.Image = Resources.Max_Dark;
            btnMinimized.Image = Resources.Minimise_Dark;
        }
        void DarkMode()
        {
            colored = true;

            btnStyleMode.Image = Resources.DarkMode;

            pnlCalcBody.BackColor = Color.FromArgb(36, 36, 36);
            pnlOperation.BackColor = Color.FromArgb(36, 36, 36);
            pnlOutControls.BackColor = Color.FromArgb(36, 36, 36);
            pnlTitle.BackColor = Color.FromArgb(36, 36, 36);

            lbl_Operations.ForeColor = Color.White;
            lbl_Result.ForeColor = Color.White;

            fbtnEqual.Image = Resources.Equal_Black;
            fbtnEqual.BackColor = Color.FromArgb(76, 194, 255);

            fbtnDot.ForeColor = Color.White;
            fbtnDot.BackColor = Color.FromArgb(60, 60, 60);

            fbtnZero.ForeColor = Color.White;
            fbtnZero.BackColor = Color.FromArgb(70, 70, 70);

            fbtnOne.ForeColor = Color.White;
            fbtnOne.BackColor = Color.FromArgb(70, 70, 70);

            fbtnTwo.ForeColor = Color.White;
            fbtnTwo.BackColor = Color.FromArgb(70, 70, 70);

            fbtnThree.ForeColor = Color.White;
            fbtnThree.BackColor = Color.FromArgb(70, 70, 70);

            fbtnFour.ForeColor = Color.White;
            fbtnFour.BackColor = Color.FromArgb(70, 70, 70);

            fbtnFive.ForeColor = Color.White;
            fbtnFive.BackColor = Color.FromArgb(70, 70, 70);

            fbtnSix.ForeColor = Color.White;
            fbtnSix.BackColor = Color.FromArgb(70, 70, 70);

            fbtnSeven.ForeColor = Color.White;
            fbtnSeven.BackColor = Color.FromArgb(70, 70, 70);

            fbtnEight.ForeColor = Color.White;
            fbtnEight.BackColor = Color.FromArgb(70, 70, 70);

            fbtnNine.ForeColor = Color.White;
            fbtnNine.BackColor = Color.FromArgb(70, 70, 70);

            fbtnPercent.ForeColor = Color.White;
            fbtnPercent.BackColor = Color.FromArgb(60, 60, 60);

            fbtnClearAll.ForeColor = Color.White;
            fbtnClearAll.BackColor = Color.FromArgb(60, 60, 60);

            fbtnClearTemp.ForeColor = Color.White;
            fbtnClearTemp.BackColor = Color.FromArgb(60, 60, 60);

            fbtnPM.ForeColor = Color.White;
            fbtnPM.BackColor = Color.FromArgb(60, 60, 60);

            fbtnAdd.Image = Resources.Addition;
            fbtnAdd.BackColor = Color.FromArgb(60, 60, 60);

            fbtnMinus.Image = Resources.Minus;
            fbtnMinus.BackColor = Color.FromArgb(60, 60, 60);

            fbtnDivision.Image = Resources.Division;
            fbtnDivision.BackColor = Color.FromArgb(60, 60, 60);

            fbtnMulti.Image = Resources.Multi;
            fbtnMulti.BackColor = Color.FromArgb(60, 60, 60);

            fbtnSquare.Image = Resources.SquareSymbol;
            fbtnSquare.BackColor = Color.FromArgb(60, 60, 60);

            fbtnSquareRoot.Image = Resources.Square;
            fbtnSquareRoot.BackColor = Color.FromArgb(60, 60, 60);

            fbtn1X.Image = Resources.symbo_;
            fbtn1X.BackColor = Color.FromArgb(60, 60, 60);

            fbtnBackspace.Image = Resources.Backspase;
            fbtnBackspace.BackColor = Color.FromArgb(60, 60, 60);

            btnMenu.Image = Resources.Menu;
            btnExit.Image = Resources.CloseIcon;
            btnMaximized.Image = Resources.Max;
            btnMinimized.Image = Resources.Minimise;
        }
        private void btnStyleMode_Click(object sender, EventArgs e)
        {
            if (colored)
                DayMode();
            else
                DarkMode();
        }

        //*------------------------------------------------------------------------------*//
        //*                           CORE FUNCTIONS (METHODS)                           *//
        //*------------------------------------------------------------------------------*//
        bool CheckIfThereMoreThanOneDot(string txt)
        {
            bool found = txt.Contains('.');

            if (found)
                return true;
            else
                return false;
        }
        void OperationType(string op)
        {
            lbl_Operations.Text = lbl_Result.Text + " " + op + " ";
            num1 = Convert.ToDouble(lbl_Result.Text);
            lbl_Result.Text = "0";
            operation = op;
        }
        string Calculate(double Number1, double Number2, string op)
        {
            double Result = 0;
            switch (op)
            {
                case "+":
                    Result = Number1 + Number2;
                    break;
                case "-":
                    Result = Number1 - Number2;
                    break;
                case "×":
                    Result = Number1 * Number2;
                    break;
                case "÷":
                    Result = Number1 / Number2;
                    break;
                case "^":
                    Result = Math.Pow(Number1, Number2);
                    break;
                case "√":
                    Result = Math.Sqrt(Number1);
                    break;
            }

            return Result.ToString();
        }
        void WriteNumbers(Button b)
        {
            if (lbl_Result.Text == "0")
                lbl_Result.Text = b.Text;
            else
                lbl_Result.Text += b.Text;
        }
        bool EmptyNumberValidation()
        {
            if (lbl_Result.Text == "0")
            {
                MessageBox.Show("Invalid Operation, There Is No Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            WriteNumbers((Button)sender);
        }
        private void fbtnBackspace_Click(object sender, EventArgs e)
        {
            EmptyNumberValidation();

            if (lbl_Result.Text.Length > 0)
                lbl_Result.Text = lbl_Result.Text.Remove(lbl_Result.Text.Length - 1);

            if (lbl_Result.Text.Length == 0)
                lbl_Result.Text = "0";
        }
        private void fbtnOperations_Click(object sender, EventArgs e)
        {
            if(!EmptyNumberValidation())
            {
                FRoundButton fbtn = (FRoundButton)sender;
                OperationType(fbtn.Tag.ToString());
            }
        }
        private void fbtnEqual_Click(object sender, EventArgs e)
        {
            if (lbl_Operations.Text == "0" || lbl_Operations.Text.StartsWith(" = "))
                lbl_Operations.Text = " = " + lbl_Result.Text;

            if (num1 == 0f && num2 == 0f)
                return;

            num2 = Convert.ToDouble(lbl_Result.Text);
            lbl_Operations.Text += num2 + " = ";
            switch (operation)
            {
                case "+":
                    lbl_Result.Text = Calculate(num1, num2, operation);
                    break;
                case "-":
                    lbl_Result.Text = Calculate(num1, num2, operation);
                    break;
                case "×":
                    lbl_Result.Text = Calculate(num1, num2, operation);
                    break;
                case "÷":
                    lbl_Result.Text = Calculate(num1, num2, operation);
                    break;
                case "^":
                    lbl_Result.Text = Calculate(num1, num2, operation);
                    break;
                case "√":
                    lbl_Result.Text = Calculate(num1, num2, operation);
                    break;
            }
        }
        private void fbtnDot_Click(object sender, EventArgs e)
        {
            if (!CheckIfThereMoreThanOneDot(lbl_Result.Text))
                lbl_Result.Text += fbtnDot.Text;
        }
        private void fbtnClearAll_Click(object sender, EventArgs e)
        {
            lbl_Result.Text = "0";
            lbl_Operations.Text = "0";
            num1 = 0f;
            num2 = 0f;
        }
        private void fbtnClearTemp_Click(object sender, EventArgs e)
        {
            lbl_Result.Text = "0";
        }


        //*------------------------------------------------------------------------------*//
        //*                          Windows Control (METHODS)                           *//
        //*------------------------------------------------------------------------------*//
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

        }

        //*------------------------------------------------------------------------------*//
        //*                           Moving Screen (METHODS)                            *//
        //*------------------------------------------------------------------------------*//
        private void pnlOutControls_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void pnlOutControls_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
        private void pnlOutControls_MouseMove(object sender, MouseEventArgs e)
        {
            if(move == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }
    }
}