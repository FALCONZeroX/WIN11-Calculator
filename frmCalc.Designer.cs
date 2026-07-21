namespace SimpleCalculator
{
    partial class frmCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalc));
            this.pnlOutControls = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnMaximized = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnStyleMode = new System.Windows.Forms.Button();
            this.lbl_Operations = new System.Windows.Forms.Label();
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.pnlCalcBody = new System.Windows.Forms.Panel();
            this.fbtnBackspace = new RoundButton.FRoundButton();
            this.fbtnZero = new RoundButton.FRoundButton();
            this.fbtn1X = new RoundButton.FRoundButton();
            this.fbtnSeven = new RoundButton.FRoundButton();
            this.fbtnFour = new RoundButton.FRoundButton();
            this.fbtnOne = new RoundButton.FRoundButton();
            this.fbtnSquare = new RoundButton.FRoundButton();
            this.fbtnEight = new RoundButton.FRoundButton();
            this.fbtnFive = new RoundButton.FRoundButton();
            this.fbtnTwo = new RoundButton.FRoundButton();
            this.fbtnPercent = new RoundButton.FRoundButton();
            this.fbtnClearTemp = new RoundButton.FRoundButton();
            this.fbtnClearAll = new RoundButton.FRoundButton();
            this.fbtnSquareRoot = new RoundButton.FRoundButton();
            this.fbtnNine = new RoundButton.FRoundButton();
            this.fbtnSix = new RoundButton.FRoundButton();
            this.fbtnThree = new RoundButton.FRoundButton();
            this.fbtnDot = new RoundButton.FRoundButton();
            this.fbtnPM = new RoundButton.FRoundButton();
            this.fbtnDivision = new RoundButton.FRoundButton();
            this.fbtnEqual = new RoundButton.FRoundButton();
            this.fbtnMinus = new RoundButton.FRoundButton();
            this.fbtnAdd = new RoundButton.FRoundButton();
            this.fbtnMulti = new RoundButton.FRoundButton();
            this.pnlOutControls.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlOperation.SuspendLayout();
            this.pnlCalcBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOutControls
            // 
            this.pnlOutControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnlOutControls.Controls.Add(this.btnMenu);
            this.pnlOutControls.Controls.Add(this.btnMinimized);
            this.pnlOutControls.Controls.Add(this.btnMaximized);
            this.pnlOutControls.Controls.Add(this.btnExit);
            this.pnlOutControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOutControls.Location = new System.Drawing.Point(0, 0);
            this.pnlOutControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOutControls.Name = "pnlOutControls";
            this.pnlOutControls.Size = new System.Drawing.Size(490, 58);
            this.pnlOutControls.TabIndex = 31;
            this.pnlOutControls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlOutControls_MouseDown);
            this.pnlOutControls.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlOutControls_MouseMove);
            this.pnlOutControls.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlOutControls_MouseUp);
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 58);
            this.btnMenu.TabIndex = 32;
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.Location = new System.Drawing.Point(265, 0);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(75, 58);
            this.btnMinimized.TabIndex = 2;
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximized.FlatAppearance.BorderSize = 0;
            this.btnMaximized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Location = new System.Drawing.Point(340, 0);
            this.btnMaximized.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(75, 58);
            this.btnMaximized.TabIndex = 1;
            this.btnMaximized.UseVisualStyleBackColor = true;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(415, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 58);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnlTitle.Controls.Add(this.btnStyleMode);
            this.pnlTitle.Controls.Add(this.lbl_Operations);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.ForeColor = System.Drawing.Color.White;
            this.pnlTitle.Location = new System.Drawing.Point(0, 58);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlTitle.Size = new System.Drawing.Size(490, 64);
            this.pnlTitle.TabIndex = 32;
            // 
            // btnStyleMode
            // 
            this.btnStyleMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStyleMode.FlatAppearance.BorderSize = 0;
            this.btnStyleMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnStyleMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStyleMode.Image = global::SimpleCalculator.Properties.Resources.DarkMode;
            this.btnStyleMode.Location = new System.Drawing.Point(0, 0);
            this.btnStyleMode.Margin = new System.Windows.Forms.Padding(0);
            this.btnStyleMode.Name = "btnStyleMode";
            this.btnStyleMode.Size = new System.Drawing.Size(75, 64);
            this.btnStyleMode.TabIndex = 31;
            this.btnStyleMode.UseVisualStyleBackColor = true;
            this.btnStyleMode.Click += new System.EventHandler(this.btnStyleMode_Click);
            // 
            // lbl_Operations
            // 
            this.lbl_Operations.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Operations.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Operations.Location = new System.Drawing.Point(109, 0);
            this.lbl_Operations.Name = "lbl_Operations";
            this.lbl_Operations.Size = new System.Drawing.Size(381, 64);
            this.lbl_Operations.TabIndex = 30;
            this.lbl_Operations.Text = "0";
            this.lbl_Operations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlOperation
            // 
            this.pnlOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnlOperation.Controls.Add(this.lbl_Result);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperation.Location = new System.Drawing.Point(0, 122);
            this.pnlOperation.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlOperation.Size = new System.Drawing.Size(490, 99);
            this.pnlOperation.TabIndex = 33;
            // 
            // lbl_Result
            // 
            this.lbl_Result.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Result.Font = new System.Drawing.Font("JetBrains Mono NL", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.ForeColor = System.Drawing.Color.White;
            this.lbl_Result.Location = new System.Drawing.Point(132, 0);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(358, 99);
            this.lbl_Result.TabIndex = 29;
            this.lbl_Result.Text = "0";
            this.lbl_Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCalcBody
            // 
            this.pnlCalcBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnlCalcBody.Controls.Add(this.fbtnBackspace);
            this.pnlCalcBody.Controls.Add(this.fbtnZero);
            this.pnlCalcBody.Controls.Add(this.fbtn1X);
            this.pnlCalcBody.Controls.Add(this.fbtnSeven);
            this.pnlCalcBody.Controls.Add(this.fbtnFour);
            this.pnlCalcBody.Controls.Add(this.fbtnOne);
            this.pnlCalcBody.Controls.Add(this.fbtnSquare);
            this.pnlCalcBody.Controls.Add(this.fbtnEight);
            this.pnlCalcBody.Controls.Add(this.fbtnFive);
            this.pnlCalcBody.Controls.Add(this.fbtnTwo);
            this.pnlCalcBody.Controls.Add(this.fbtnPercent);
            this.pnlCalcBody.Controls.Add(this.fbtnClearTemp);
            this.pnlCalcBody.Controls.Add(this.fbtnClearAll);
            this.pnlCalcBody.Controls.Add(this.fbtnSquareRoot);
            this.pnlCalcBody.Controls.Add(this.fbtnNine);
            this.pnlCalcBody.Controls.Add(this.fbtnSix);
            this.pnlCalcBody.Controls.Add(this.fbtnThree);
            this.pnlCalcBody.Controls.Add(this.fbtnDot);
            this.pnlCalcBody.Controls.Add(this.fbtnPM);
            this.pnlCalcBody.Controls.Add(this.fbtnDivision);
            this.pnlCalcBody.Controls.Add(this.fbtnEqual);
            this.pnlCalcBody.Controls.Add(this.fbtnMinus);
            this.pnlCalcBody.Controls.Add(this.fbtnAdd);
            this.pnlCalcBody.Controls.Add(this.fbtnMulti);
            this.pnlCalcBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCalcBody.Location = new System.Drawing.Point(0, 221);
            this.pnlCalcBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCalcBody.Name = "pnlCalcBody";
            this.pnlCalcBody.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlCalcBody.Size = new System.Drawing.Size(490, 521);
            this.pnlCalcBody.TabIndex = 34;
            // 
            // fbtnBackspace
            // 
            this.fbtnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnBackspace.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnBackspace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fbtnBackspace.BorderRadius = 15;
            this.fbtnBackspace.BorderSize = 0;
            this.fbtnBackspace.FlatAppearance.BorderSize = 0;
            this.fbtnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnBackspace.Font = new System.Drawing.Font("JetBrains Mono NL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnBackspace.ForeColor = System.Drawing.Color.White;
            this.fbtnBackspace.Image = ((System.Drawing.Image)(resources.GetObject("fbtnBackspace.Image")));
            this.fbtnBackspace.Location = new System.Drawing.Point(363, 16);
            this.fbtnBackspace.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnBackspace.Name = "fbtnBackspace";
            this.fbtnBackspace.Size = new System.Drawing.Size(117, 80);
            this.fbtnBackspace.TabIndex = 39;
            this.fbtnBackspace.TextColor = System.Drawing.Color.White;
            this.fbtnBackspace.UseVisualStyleBackColor = false;
            this.fbtnBackspace.Click += new System.EventHandler(this.fbtnBackspace_Click);
            // 
            // fbtnZero
            // 
            this.fbtnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnZero.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnZero.BorderRadius = 15;
            this.fbtnZero.BorderSize = 0;
            this.fbtnZero.FlatAppearance.BorderSize = 0;
            this.fbtnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnZero.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnZero.ForeColor = System.Drawing.Color.White;
            this.fbtnZero.Location = new System.Drawing.Point(126, 425);
            this.fbtnZero.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnZero.Name = "fbtnZero";
            this.fbtnZero.Size = new System.Drawing.Size(117, 80);
            this.fbtnZero.TabIndex = 40;
            this.fbtnZero.Text = "0";
            this.fbtnZero.TextColor = System.Drawing.Color.White;
            this.fbtnZero.UseVisualStyleBackColor = false;
            this.fbtnZero.Click += new System.EventHandler(this.btn_Click);
            // 
            // fbtn1X
            // 
            this.fbtn1X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtn1X.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtn1X.BorderRadius = 15;
            this.fbtn1X.BorderSize = 0;
            this.fbtn1X.FlatAppearance.BorderSize = 0;
            this.fbtn1X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtn1X.Font = new System.Drawing.Font("JetBrains Mono NL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtn1X.ForeColor = System.Drawing.Color.White;
            this.fbtn1X.Image = ((System.Drawing.Image)(resources.GetObject("fbtn1X.Image")));
            this.fbtn1X.Location = new System.Drawing.Point(8, 98);
            this.fbtn1X.Margin = new System.Windows.Forms.Padding(4);
            this.fbtn1X.Name = "fbtn1X";
            this.fbtn1X.Size = new System.Drawing.Size(117, 80);
            this.fbtn1X.TabIndex = 40;
            this.fbtn1X.TextColor = System.Drawing.Color.White;
            this.fbtn1X.UseVisualStyleBackColor = false;
            // 
            // fbtnSeven
            // 
            this.fbtnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnSeven.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnSeven.BorderRadius = 15;
            this.fbtnSeven.BorderSize = 0;
            this.fbtnSeven.FlatAppearance.BorderSize = 0;
            this.fbtnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnSeven.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnSeven.ForeColor = System.Drawing.Color.White;
            this.fbtnSeven.Location = new System.Drawing.Point(8, 180);
            this.fbtnSeven.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnSeven.Name = "fbtnSeven";
            this.fbtnSeven.Size = new System.Drawing.Size(117, 80);
            this.fbtnSeven.TabIndex = 40;
            this.fbtnSeven.Text = "7";
            this.fbtnSeven.TextColor = System.Drawing.Color.White;
            this.fbtnSeven.UseVisualStyleBackColor = false;
            this.fbtnSeven.Click += new System.EventHandler(this.btn_Click);
            // 
            // fbtnFour
            // 
            this.fbtnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnFour.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnFour.BorderRadius = 15;
            this.fbtnFour.BorderSize = 0;
            this.fbtnFour.FlatAppearance.BorderSize = 0;
            this.fbtnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnFour.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnFour.ForeColor = System.Drawing.Color.White;
            this.fbtnFour.Location = new System.Drawing.Point(8, 262);
            this.fbtnFour.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnFour.Name = "fbtnFour";
            this.fbtnFour.Size = new System.Drawing.Size(117, 80);
            this.fbtnFour.TabIndex = 40;
            this.fbtnFour.Text = "4";
            this.fbtnFour.TextColor = System.Drawing.Color.White;
            this.fbtnFour.UseVisualStyleBackColor = false;
            this.fbtnFour.Click += new System.EventHandler(this.btn_Click);
            // 
            // fbtnOne
            // 
            this.fbtnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnOne.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnOne.BorderRadius = 15;
            this.fbtnOne.BorderSize = 0;
            this.fbtnOne.FlatAppearance.BorderSize = 0;
            this.fbtnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnOne.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnOne.ForeColor = System.Drawing.Color.White;
            this.fbtnOne.Location = new System.Drawing.Point(8, 343);
            this.fbtnOne.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnOne.Name = "fbtnOne";
            this.fbtnOne.Size = new System.Drawing.Size(117, 80);
            this.fbtnOne.TabIndex = 40;
            this.fbtnOne.Text = "1";
            this.fbtnOne.TextColor = System.Drawing.Color.White;
            this.fbtnOne.UseVisualStyleBackColor = false;
            this.fbtnOne.Click += new System.EventHandler(this.btn_Click);
            // 
            // fbtnSquare
            // 
            this.fbtnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnSquare.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnSquare.BorderRadius = 15;
            this.fbtnSquare.BorderSize = 0;
            this.fbtnSquare.FlatAppearance.BorderSize = 0;
            this.fbtnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnSquare.Font = new System.Drawing.Font("JetBrains Mono NL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnSquare.ForeColor = System.Drawing.Color.White;
            this.fbtnSquare.Image = ((System.Drawing.Image)(resources.GetObject("fbtnSquare.Image")));
            this.fbtnSquare.Location = new System.Drawing.Point(126, 98);
            this.fbtnSquare.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnSquare.Name = "fbtnSquare";
            this.fbtnSquare.Size = new System.Drawing.Size(117, 80);
            this.fbtnSquare.TabIndex = 40;
            this.fbtnSquare.Tag = "^";
            this.fbtnSquare.TextColor = System.Drawing.Color.White;
            this.fbtnSquare.UseVisualStyleBackColor = false;
            this.fbtnSquare.Click += new System.EventHandler(this.fbtnOperations_Click);
            // 
            // fbtnEight
            // 
            this.fbtnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnEight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnEight.BorderRadius = 15;
            this.fbtnEight.BorderSize = 0;
            this.fbtnEight.FlatAppearance.BorderSize = 0;
            this.fbtnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnEight.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnEight.ForeColor = System.Drawing.Color.White;
            this.fbtnEight.Location = new System.Drawing.Point(126, 180);
            this.fbtnEight.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnEight.Name = "fbtnEight";
            this.fbtnEight.Size = new System.Drawing.Size(117, 80);
            this.fbtnEight.TabIndex = 40;
            this.fbtnEight.Text = "8";
            this.fbtnEight.TextColor = System.Drawing.Color.White;
            this.fbtnEight.UseVisualStyleBackColor = false;
            this.fbtnEight.Click += new System.EventHandler(this.btn_Click);
            // 
            // fbtnFive
            // 
            this.fbtnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnFive.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnFive.BorderRadius = 15;
            this.fbtnFive.BorderSize = 0;
            this.fbtnFive.FlatAppearance.BorderSize = 0;
            this.fbtnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnFive.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnFive.ForeColor = System.Drawing.Color.White;
            this.fbtnFive.Location = new System.Drawing.Point(126, 262);
            this.fbtnFive.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnFive.Name = "fbtnFive";
            this.fbtnFive.Size = new System.Drawing.Size(117, 80);
            this.fbtnFive.TabIndex = 40;
            this.fbtnFive.Text = "5";
            this.fbtnFive.TextColor = System.Drawing.Color.White;
            this.fbtnFive.UseVisualStyleBackColor = false;
            this.fbtnFive.Click += new System.EventHandler(this.btn_Click);
            // 
            // fbtnTwo
            // 
            this.fbtnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnTwo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnTwo.BorderRadius = 15;
            this.fbtnTwo.BorderSize = 0;
            this.fbtnTwo.FlatAppearance.BorderSize = 0;
            this.fbtnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnTwo.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnTwo.ForeColor = System.Drawing.Color.White;
            this.fbtnTwo.Location = new System.Drawing.Point(126, 343);
            this.fbtnTwo.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnTwo.Name = "fbtnTwo";
            this.fbtnTwo.Size = new System.Drawing.Size(117, 80);
            this.fbtnTwo.TabIndex = 40;
            this.fbtnTwo.Text = "2";
            this.fbtnTwo.TextColor = System.Drawing.Color.White;
            this.fbtnTwo.UseVisualStyleBackColor = false;
            this.fbtnTwo.Click += new System.EventHandler(this.btn_Click);
            // 
            // fbtnPercent
            // 
            this.fbtnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnPercent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnPercent.BorderRadius = 15;
            this.fbtnPercent.BorderSize = 0;
            this.fbtnPercent.FlatAppearance.BorderSize = 0;
            this.fbtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnPercent.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnPercent.ForeColor = System.Drawing.Color.White;
            this.fbtnPercent.Location = new System.Drawing.Point(8, 16);
            this.fbtnPercent.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnPercent.Name = "fbtnPercent";
            this.fbtnPercent.Size = new System.Drawing.Size(117, 80);
            this.fbtnPercent.TabIndex = 40;
            this.fbtnPercent.Text = "%";
            this.fbtnPercent.TextColor = System.Drawing.Color.White;
            this.fbtnPercent.UseVisualStyleBackColor = false;
            // 
            // fbtnClearTemp
            // 
            this.fbtnClearTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnClearTemp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnClearTemp.BorderRadius = 15;
            this.fbtnClearTemp.BorderSize = 0;
            this.fbtnClearTemp.FlatAppearance.BorderSize = 0;
            this.fbtnClearTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnClearTemp.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnClearTemp.ForeColor = System.Drawing.Color.White;
            this.fbtnClearTemp.Location = new System.Drawing.Point(126, 16);
            this.fbtnClearTemp.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnClearTemp.Name = "fbtnClearTemp";
            this.fbtnClearTemp.Size = new System.Drawing.Size(117, 80);
            this.fbtnClearTemp.TabIndex = 40;
            this.fbtnClearTemp.Text = "CE";
            this.fbtnClearTemp.TextColor = System.Drawing.Color.White;
            this.fbtnClearTemp.UseVisualStyleBackColor = false;
            this.fbtnClearTemp.Click += new System.EventHandler(this.fbtnClearTemp_Click);
            // 
            // fbtnClearAll
            // 
            this.fbtnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnClearAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnClearAll.BorderRadius = 15;
            this.fbtnClearAll.BorderSize = 0;
            this.fbtnClearAll.FlatAppearance.BorderSize = 0;
            this.fbtnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnClearAll.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnClearAll.ForeColor = System.Drawing.Color.White;
            this.fbtnClearAll.Location = new System.Drawing.Point(244, 16);
            this.fbtnClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnClearAll.Name = "fbtnClearAll";
            this.fbtnClearAll.Size = new System.Drawing.Size(117, 80);
            this.fbtnClearAll.TabIndex = 40;
            this.fbtnClearAll.Text = "C";
            this.fbtnClearAll.TextColor = System.Drawing.Color.White;
            this.fbtnClearAll.UseVisualStyleBackColor = false;
            this.fbtnClearAll.Click += new System.EventHandler(this.fbtnClearAll_Click);
            // 
            // fbtnSquareRoot
            // 
            this.fbtnSquareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnSquareRoot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnSquareRoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fbtnSquareRoot.BorderRadius = 15;
            this.fbtnSquareRoot.BorderSize = 0;
            this.fbtnSquareRoot.FlatAppearance.BorderSize = 0;
            this.fbtnSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnSquareRoot.Font = new System.Drawing.Font("JetBrains Mono NL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnSquareRoot.ForeColor = System.Drawing.Color.White;
            this.fbtnSquareRoot.Image = ((System.Drawing.Image)(resources.GetObject("fbtnSquareRoot.Image")));
            this.fbtnSquareRoot.Location = new System.Drawing.Point(244, 98);
            this.fbtnSquareRoot.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnSquareRoot.Name = "fbtnSquareRoot";
            this.fbtnSquareRoot.Size = new System.Drawing.Size(117, 80);
            this.fbtnSquareRoot.TabIndex = 40;
            this.fbtnSquareRoot.Tag = "√";
            this.fbtnSquareRoot.TextColor = System.Drawing.Color.White;
            this.fbtnSquareRoot.UseVisualStyleBackColor = false;
            this.fbtnSquareRoot.Click += new System.EventHandler(this.fbtnOperations_Click);
            // 
            // fbtnNine
            // 
            this.fbtnNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnNine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnNine.BorderRadius = 15;
            this.fbtnNine.BorderSize = 0;
            this.fbtnNine.FlatAppearance.BorderSize = 0;
            this.fbtnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnNine.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnNine.ForeColor = System.Drawing.Color.White;
            this.fbtnNine.Location = new System.Drawing.Point(244, 180);
            this.fbtnNine.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnNine.Name = "fbtnNine";
            this.fbtnNine.Size = new System.Drawing.Size(117, 80);
            this.fbtnNine.TabIndex = 40;
            this.fbtnNine.Text = "9";
            this.fbtnNine.TextColor = System.Drawing.Color.White;
            this.fbtnNine.UseVisualStyleBackColor = false;
            this.fbtnNine.Click += new System.EventHandler(this.btn_Click);
            // 
            // fbtnSix
            // 
            this.fbtnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnSix.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnSix.BorderRadius = 15;
            this.fbtnSix.BorderSize = 0;
            this.fbtnSix.FlatAppearance.BorderSize = 0;
            this.fbtnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnSix.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnSix.ForeColor = System.Drawing.Color.White;
            this.fbtnSix.Location = new System.Drawing.Point(244, 262);
            this.fbtnSix.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnSix.Name = "fbtnSix";
            this.fbtnSix.Size = new System.Drawing.Size(117, 80);
            this.fbtnSix.TabIndex = 40;
            this.fbtnSix.Text = "6";
            this.fbtnSix.TextColor = System.Drawing.Color.White;
            this.fbtnSix.UseVisualStyleBackColor = false;
            this.fbtnSix.Click += new System.EventHandler(this.btn_Click);
            // 
            // fbtnThree
            // 
            this.fbtnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnThree.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fbtnThree.BorderRadius = 15;
            this.fbtnThree.BorderSize = 0;
            this.fbtnThree.FlatAppearance.BorderSize = 0;
            this.fbtnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnThree.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnThree.ForeColor = System.Drawing.Color.White;
            this.fbtnThree.Location = new System.Drawing.Point(244, 343);
            this.fbtnThree.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnThree.Name = "fbtnThree";
            this.fbtnThree.Size = new System.Drawing.Size(117, 80);
            this.fbtnThree.TabIndex = 40;
            this.fbtnThree.Text = "3";
            this.fbtnThree.TextColor = System.Drawing.Color.White;
            this.fbtnThree.UseVisualStyleBackColor = false;
            this.fbtnThree.Click += new System.EventHandler(this.btn_Click);
            // 
            // fbtnDot
            // 
            this.fbtnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnDot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnDot.BorderRadius = 15;
            this.fbtnDot.BorderSize = 0;
            this.fbtnDot.FlatAppearance.BorderSize = 0;
            this.fbtnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnDot.Font = new System.Drawing.Font("JetBrains Mono NL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnDot.ForeColor = System.Drawing.Color.White;
            this.fbtnDot.Location = new System.Drawing.Point(244, 425);
            this.fbtnDot.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnDot.Name = "fbtnDot";
            this.fbtnDot.Size = new System.Drawing.Size(117, 80);
            this.fbtnDot.TabIndex = 40;
            this.fbtnDot.Text = ".";
            this.fbtnDot.TextColor = System.Drawing.Color.White;
            this.fbtnDot.UseVisualStyleBackColor = false;
            this.fbtnDot.Click += new System.EventHandler(this.fbtnDot_Click);
            // 
            // fbtnPM
            // 
            this.fbtnPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnPM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnPM.BorderRadius = 15;
            this.fbtnPM.BorderSize = 0;
            this.fbtnPM.FlatAppearance.BorderSize = 0;
            this.fbtnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnPM.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnPM.ForeColor = System.Drawing.Color.White;
            this.fbtnPM.Location = new System.Drawing.Point(8, 425);
            this.fbtnPM.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnPM.Name = "fbtnPM";
            this.fbtnPM.Size = new System.Drawing.Size(117, 80);
            this.fbtnPM.TabIndex = 40;
            this.fbtnPM.Text = "±";
            this.fbtnPM.TextColor = System.Drawing.Color.White;
            this.fbtnPM.UseVisualStyleBackColor = false;
            // 
            // fbtnDivision
            // 
            this.fbtnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnDivision.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnDivision.BorderRadius = 15;
            this.fbtnDivision.BorderSize = 0;
            this.fbtnDivision.FlatAppearance.BorderSize = 0;
            this.fbtnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnDivision.Font = new System.Drawing.Font("JetBrains Mono NL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnDivision.ForeColor = System.Drawing.Color.White;
            this.fbtnDivision.Image = ((System.Drawing.Image)(resources.GetObject("fbtnDivision.Image")));
            this.fbtnDivision.Location = new System.Drawing.Point(363, 98);
            this.fbtnDivision.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnDivision.Name = "fbtnDivision";
            this.fbtnDivision.Size = new System.Drawing.Size(117, 80);
            this.fbtnDivision.TabIndex = 41;
            this.fbtnDivision.Tag = "÷";
            this.fbtnDivision.TextColor = System.Drawing.Color.White;
            this.fbtnDivision.UseVisualStyleBackColor = false;
            this.fbtnDivision.Click += new System.EventHandler(this.fbtnOperations_Click);
            // 
            // fbtnEqual
            // 
            this.fbtnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.fbtnEqual.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.fbtnEqual.BorderRadius = 15;
            this.fbtnEqual.BorderSize = 0;
            this.fbtnEqual.FlatAppearance.BorderSize = 0;
            this.fbtnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnEqual.Font = new System.Drawing.Font("JetBrains Mono NL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnEqual.ForeColor = System.Drawing.Color.Black;
            this.fbtnEqual.Image = ((System.Drawing.Image)(resources.GetObject("fbtnEqual.Image")));
            this.fbtnEqual.Location = new System.Drawing.Point(363, 425);
            this.fbtnEqual.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnEqual.Name = "fbtnEqual";
            this.fbtnEqual.Size = new System.Drawing.Size(117, 80);
            this.fbtnEqual.TabIndex = 42;
            this.fbtnEqual.TextColor = System.Drawing.Color.Black;
            this.fbtnEqual.UseVisualStyleBackColor = false;
            this.fbtnEqual.Click += new System.EventHandler(this.fbtnEqual_Click);
            // 
            // fbtnMinus
            // 
            this.fbtnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnMinus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnMinus.BorderRadius = 15;
            this.fbtnMinus.BorderSize = 0;
            this.fbtnMinus.FlatAppearance.BorderSize = 0;
            this.fbtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnMinus.Font = new System.Drawing.Font("JetBrains Mono NL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnMinus.ForeColor = System.Drawing.Color.White;
            this.fbtnMinus.Image = ((System.Drawing.Image)(resources.GetObject("fbtnMinus.Image")));
            this.fbtnMinus.Location = new System.Drawing.Point(363, 262);
            this.fbtnMinus.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnMinus.Name = "fbtnMinus";
            this.fbtnMinus.Size = new System.Drawing.Size(117, 80);
            this.fbtnMinus.TabIndex = 43;
            this.fbtnMinus.Tag = "-";
            this.fbtnMinus.TextColor = System.Drawing.Color.White;
            this.fbtnMinus.UseVisualStyleBackColor = false;
            this.fbtnMinus.Click += new System.EventHandler(this.fbtnOperations_Click);
            // 
            // fbtnAdd
            // 
            this.fbtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnAdd.BorderRadius = 15;
            this.fbtnAdd.BorderSize = 0;
            this.fbtnAdd.FlatAppearance.BorderSize = 0;
            this.fbtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnAdd.Font = new System.Drawing.Font("JetBrains Mono NL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnAdd.ForeColor = System.Drawing.Color.White;
            this.fbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("fbtnAdd.Image")));
            this.fbtnAdd.Location = new System.Drawing.Point(363, 343);
            this.fbtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnAdd.Name = "fbtnAdd";
            this.fbtnAdd.Size = new System.Drawing.Size(117, 80);
            this.fbtnAdd.TabIndex = 43;
            this.fbtnAdd.Tag = "+";
            this.fbtnAdd.TextColor = System.Drawing.Color.White;
            this.fbtnAdd.UseVisualStyleBackColor = false;
            this.fbtnAdd.Click += new System.EventHandler(this.fbtnOperations_Click);
            // 
            // fbtnMulti
            // 
            this.fbtnMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnMulti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fbtnMulti.BorderRadius = 15;
            this.fbtnMulti.BorderSize = 0;
            this.fbtnMulti.FlatAppearance.BorderSize = 0;
            this.fbtnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbtnMulti.Font = new System.Drawing.Font("JetBrains Mono NL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnMulti.ForeColor = System.Drawing.Color.White;
            this.fbtnMulti.Image = ((System.Drawing.Image)(resources.GetObject("fbtnMulti.Image")));
            this.fbtnMulti.Location = new System.Drawing.Point(363, 180);
            this.fbtnMulti.Margin = new System.Windows.Forms.Padding(4);
            this.fbtnMulti.Name = "fbtnMulti";
            this.fbtnMulti.Size = new System.Drawing.Size(117, 80);
            this.fbtnMulti.TabIndex = 44;
            this.fbtnMulti.Tag = "×";
            this.fbtnMulti.TextColor = System.Drawing.Color.White;
            this.fbtnMulti.UseVisualStyleBackColor = false;
            this.fbtnMulti.Click += new System.EventHandler(this.fbtnOperations_Click);
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(490, 742);
            this.Controls.Add(this.pnlCalcBody);
            this.Controls.Add(this.pnlOperation);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlOutControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "آله حاسبة";
            this.pnlOutControls.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlOperation.ResumeLayout(false);
            this.pnlCalcBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlOutControls;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lbl_Operations;
        private System.Windows.Forms.Panel pnlOperation;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Panel pnlCalcBody;
        private RoundButton.FRoundButton fbtnBackspace;
        private RoundButton.FRoundButton fbtnZero;
        private RoundButton.FRoundButton fbtn1X;
        private RoundButton.FRoundButton fbtnSeven;
        private RoundButton.FRoundButton fbtnFour;
        private RoundButton.FRoundButton fbtnOne;
        private RoundButton.FRoundButton fbtnSquare;
        private RoundButton.FRoundButton fbtnEight;
        private RoundButton.FRoundButton fbtnFive;
        private RoundButton.FRoundButton fbtnTwo;
        private RoundButton.FRoundButton fbtnPercent;
        private RoundButton.FRoundButton fbtnClearTemp;
        private RoundButton.FRoundButton fbtnClearAll;
        private RoundButton.FRoundButton fbtnSquareRoot;
        private RoundButton.FRoundButton fbtnNine;
        private RoundButton.FRoundButton fbtnSix;
        private RoundButton.FRoundButton fbtnThree;
        private RoundButton.FRoundButton fbtnDot;
        private RoundButton.FRoundButton fbtnPM;
        private RoundButton.FRoundButton fbtnDivision;
        private RoundButton.FRoundButton fbtnEqual;
        private RoundButton.FRoundButton fbtnMinus;
        private RoundButton.FRoundButton fbtnAdd;
        private RoundButton.FRoundButton fbtnMulti;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Button btnMaximized;
        private System.Windows.Forms.Button btnStyleMode;
        private System.Windows.Forms.Button btnMenu;
    }
}

