namespace CarRace {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.Car3 = new System.Windows.Forms.PictureBox();
            this.Car4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.p3Bet = new System.Windows.Forms.Label();
            this.p2Bet = new System.Windows.Forms.Label();
            this.p1Bet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.CarsNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.carRaceAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.LimRButton = new System.Windows.Forms.RadioButton();
            this.MarkRButton = new System.Windows.Forms.RadioButton();
            this.JhonButton = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRaceAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrack
            // 
            this.racetrack.BackColor = System.Drawing.SystemColors.Control;
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(-1, 12);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(1120, 383);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            this.racetrack.Click += new System.EventHandler(this.Racetrack_Click);
            // 
            // Car1
            // 
            this.Car1.BackColor = System.Drawing.Color.Transparent;
            this.Car1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Car1.Image = ((System.Drawing.Image)(resources.GetObject("Car1.Image")));
            this.Car1.Location = new System.Drawing.Point(15, 40);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(136, 59);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car1.TabIndex = 1;
            this.Car1.TabStop = false;
            // 
            // Car2
            // 
            this.Car2.BackColor = System.Drawing.Color.Transparent;
            this.Car2.Image = ((System.Drawing.Image)(resources.GetObject("Car2.Image")));
            this.Car2.Location = new System.Drawing.Point(12, 125);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(139, 59);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car2.TabIndex = 2;
            this.Car2.TabStop = false;
            // 
            // Car3
            // 
            this.Car3.BackColor = System.Drawing.Color.Transparent;
            this.Car3.Image = ((System.Drawing.Image)(resources.GetObject("Car3.Image")));
            this.Car3.Location = new System.Drawing.Point(15, 226);
            this.Car3.Name = "Car3";
            this.Car3.Size = new System.Drawing.Size(136, 59);
            this.Car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car3.TabIndex = 3;
            this.Car3.TabStop = false;
            // 
            // Car4
            // 
            this.Car4.BackColor = System.Drawing.Color.Transparent;
            this.Car4.Image = ((System.Drawing.Image)(resources.GetObject("Car4.Image")));
            this.Car4.Location = new System.Drawing.Point(15, 322);
            this.Car4.Name = "Car4";
            this.Car4.Size = new System.Drawing.Size(136, 59);
            this.Car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car4.TabIndex = 4;
            this.Car4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.p3Bet);
            this.groupBox1.Controls.Add(this.p2Bet);
            this.groupBox1.Controls.Add(this.p1Bet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.CarsNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.carRaceAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.LimRButton);
            this.groupBox1.Controls.Add(this.MarkRButton);
            this.groupBox1.Controls.Add(this.JhonButton);
            this.groupBox1.Controls.Add(this.MaximumBet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(-1, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1120, 168);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Race";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // p3Bet
            // 
            this.p3Bet.BackColor = System.Drawing.SystemColors.Info;
            this.p3Bet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p3Bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.p3Bet.Location = new System.Drawing.Point(523, 112);
            this.p3Bet.Name = "p3Bet";
            this.p3Bet.Size = new System.Drawing.Size(290, 17);
            this.p3Bet.TabIndex = 13;
            this.p3Bet.Text = "label6";
            // 
            // p2Bet
            // 
            this.p2Bet.BackColor = System.Drawing.SystemColors.Info;
            this.p2Bet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2Bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.p2Bet.Location = new System.Drawing.Point(523, 80);
            this.p2Bet.Name = "p2Bet";
            this.p2Bet.Size = new System.Drawing.Size(290, 17);
            this.p2Bet.TabIndex = 12;
            this.p2Bet.Text = "label5";
            // 
            // p1Bet
            // 
            this.p1Bet.BackColor = System.Drawing.SystemColors.Info;
            this.p1Bet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1Bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.p1Bet.Location = new System.Drawing.Point(523, 49);
            this.p1Bet.Name = "p1Bet";
            this.p1Bet.Size = new System.Drawing.Size(290, 17);
            this.p1Bet.TabIndex = 11;
            this.p1Bet.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // race
            // 
            this.race.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.ForeColor = System.Drawing.Color.Black;
            this.race.Location = new System.Drawing.Point(911, 67);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(135, 30);
            this.race.TabIndex = 9;
            this.race.Text = "START RACE";
            this.race.UseVisualStyleBackColor = true;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // CarsNumber
            // 
            this.CarsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CarsNumber.Location = new System.Drawing.Point(320, 62);
            this.CarsNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.CarsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CarsNumber.Name = "CarsNumber";
            this.CarsNumber.Size = new System.Drawing.Size(64, 23);
            this.CarsNumber.TabIndex = 8;
            this.CarsNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CarsNumber.ValueChanged += new System.EventHandler(this.CarsNumber_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(317, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cars number";
            // 
            // carRaceAmount
            // 
            this.carRaceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.carRaceAmount.Location = new System.Drawing.Point(149, 61);
            this.carRaceAmount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.carRaceAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.carRaceAmount.Name = "carRaceAmount";
            this.carRaceAmount.Size = new System.Drawing.Size(63, 23);
            this.carRaceAmount.TabIndex = 6;
            this.carRaceAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.carRaceAmount.ValueChanged += new System.EventHandler(this.carRaceAmount_ValueChanged);
            // 
            // Bets
            // 
            this.Bets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Bets.Location = new System.Drawing.Point(196, 105);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(126, 30);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Place Bet";
            this.Bets.UseVisualStyleBackColor = true;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // LimRButton
            // 
            this.LimRButton.AutoSize = true;
            this.LimRButton.Checked = true;
            this.LimRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LimRButton.Location = new System.Drawing.Point(14, 97);
            this.LimRButton.Name = "LimRButton";
            this.LimRButton.Size = new System.Drawing.Size(74, 21);
            this.LimRButton.TabIndex = 3;
            this.LimRButton.TabStop = true;
            this.LimRButton.Text = "Player3";
            this.LimRButton.UseVisualStyleBackColor = true;
            this.LimRButton.CheckedChanged += new System.EventHandler(this.LimButton_CheckedChanged);
            // 
            // MarkRButton
            // 
            this.MarkRButton.AutoSize = true;
            this.MarkRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MarkRButton.Location = new System.Drawing.Point(14, 73);
            this.MarkRButton.Name = "MarkRButton";
            this.MarkRButton.Size = new System.Drawing.Size(74, 21);
            this.MarkRButton.TabIndex = 2;
            this.MarkRButton.Text = "Player2";
            this.MarkRButton.UseVisualStyleBackColor = true;
            this.MarkRButton.CheckedChanged += new System.EventHandler(this.MarkButton_CheckedChanged);
            // 
            // JhonButton
            // 
            this.JhonButton.AutoSize = true;
            this.JhonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.JhonButton.Location = new System.Drawing.Point(14, 49);
            this.JhonButton.Name = "JhonButton";
            this.JhonButton.Size = new System.Drawing.Size(74, 21);
            this.JhonButton.TabIndex = 1;
            this.JhonButton.Text = "Player1";
            this.JhonButton.UseVisualStyleBackColor = true;
            this.JhonButton.CheckedChanged += new System.EventHandler(this.JhonButton_CheckedChanged);
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(136, 28);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(101, 17);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            this.MaximumBet.Click += new System.EventHandler(this.MaximumBet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Car4);
            this.Controls.Add(this.Car3);
            this.Controls.Add(this.Car2);
            this.Controls.Add(this.Car1);
            this.Controls.Add(this.racetrack);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Race Course";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRaceAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.PictureBox Car3;
        private System.Windows.Forms.PictureBox Car4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LimRButton;
        private System.Windows.Forms.RadioButton MarkRButton;
        private System.Windows.Forms.RadioButton JhonButton;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown carRaceAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.NumericUpDown CarsNumber;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label p1Bet;
        private System.Windows.Forms.Label p3Bet;
        private System.Windows.Forms.Label p2Bet;
    }
}

