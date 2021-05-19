
namespace Probabilistic_Simulations
{
    partial class Form1
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
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnPlinko = new System.Windows.Forms.Button();
            this.BtnShootingGallery = new System.Windows.Forms.Button();
            this.numGames = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPeopleShooting = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numDrivingTests = new System.Windows.Forms.NumericUpDown();
            this.BtnDrivingSchool = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numWheelSpins = new System.Windows.Forms.NumericUpDown();
            this.BtnRouletteWheel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numTimesPaidForToy = new System.Windows.Forms.NumericUpDown();
            this.BtnToyCollectables = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeopleShooting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrivingTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSpins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimesPaidForToy)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(12, 12);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(448, 139);
            this.TxtDisplay.TabIndex = 0;
            // 
            // BtnPlinko
            // 
            this.BtnPlinko.Location = new System.Drawing.Point(12, 157);
            this.BtnPlinko.Name = "BtnPlinko";
            this.BtnPlinko.Size = new System.Drawing.Size(75, 51);
            this.BtnPlinko.TabIndex = 1;
            this.BtnPlinko.Text = "Plinko";
            this.BtnPlinko.UseVisualStyleBackColor = true;
            this.BtnPlinko.Click += new System.EventHandler(this.BtnPlinko_Click);
            // 
            // BtnShootingGallery
            // 
            this.BtnShootingGallery.Location = new System.Drawing.Point(12, 273);
            this.BtnShootingGallery.Name = "BtnShootingGallery";
            this.BtnShootingGallery.Size = new System.Drawing.Size(75, 51);
            this.BtnShootingGallery.TabIndex = 2;
            this.BtnShootingGallery.Text = "Shooting Gallery";
            this.BtnShootingGallery.UseVisualStyleBackColor = true;
            this.BtnShootingGallery.Click += new System.EventHandler(this.BtnShootingGallery_Click);
            // 
            // numGames
            // 
            this.numGames.Location = new System.Drawing.Point(12, 228);
            this.numGames.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGames.Name = "numGames";
            this.numGames.Size = new System.Drawing.Size(75, 22);
            this.numGames.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Tests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of People";
            // 
            // numPeopleShooting
            // 
            this.numPeopleShooting.Location = new System.Drawing.Point(12, 344);
            this.numPeopleShooting.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPeopleShooting.Name = "numPeopleShooting";
            this.numPeopleShooting.Size = new System.Drawing.Size(75, 22);
            this.numPeopleShooting.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Driving school peoples test";
            // 
            // numDrivingTests
            // 
            this.numDrivingTests.Location = new System.Drawing.Point(12, 464);
            this.numDrivingTests.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDrivingTests.Name = "numDrivingTests";
            this.numDrivingTests.Size = new System.Drawing.Size(75, 22);
            this.numDrivingTests.TabIndex = 8;
            // 
            // BtnDrivingSchool
            // 
            this.BtnDrivingSchool.Location = new System.Drawing.Point(12, 391);
            this.BtnDrivingSchool.Name = "BtnDrivingSchool";
            this.BtnDrivingSchool.Size = new System.Drawing.Size(75, 51);
            this.BtnDrivingSchool.TabIndex = 7;
            this.BtnDrivingSchool.Text = "Driving school";
            this.BtnDrivingSchool.UseVisualStyleBackColor = true;
            this.BtnDrivingSchool.Click += new System.EventHandler(this.BtnDrivingSchool_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Casino Problem";
            // 
            // numWheelSpins
            // 
            this.numWheelSpins.Location = new System.Drawing.Point(279, 231);
            this.numWheelSpins.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numWheelSpins.Name = "numWheelSpins";
            this.numWheelSpins.Size = new System.Drawing.Size(75, 22);
            this.numWheelSpins.TabIndex = 11;
            // 
            // BtnRouletteWheel
            // 
            this.BtnRouletteWheel.Location = new System.Drawing.Point(282, 157);
            this.BtnRouletteWheel.Name = "BtnRouletteWheel";
            this.BtnRouletteWheel.Size = new System.Drawing.Size(75, 51);
            this.BtnRouletteWheel.TabIndex = 10;
            this.BtnRouletteWheel.Text = "Spin the Wheel";
            this.BtnRouletteWheel.UseVisualStyleBackColor = true;
            this.BtnRouletteWheel.Click += new System.EventHandler(this.BtnRouletteWheel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Toy Collectables";
            // 
            // numTimesPaidForToy
            // 
            this.numTimesPaidForToy.Location = new System.Drawing.Point(279, 347);
            this.numTimesPaidForToy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTimesPaidForToy.Name = "numTimesPaidForToy";
            this.numTimesPaidForToy.Size = new System.Drawing.Size(75, 22);
            this.numTimesPaidForToy.TabIndex = 14;
            // 
            // BtnToyCollectables
            // 
            this.BtnToyCollectables.Location = new System.Drawing.Point(279, 273);
            this.BtnToyCollectables.Name = "BtnToyCollectables";
            this.BtnToyCollectables.Size = new System.Drawing.Size(75, 51);
            this.BtnToyCollectables.TabIndex = 13;
            this.BtnToyCollectables.Text = "Collect Toys";
            this.BtnToyCollectables.UseVisualStyleBackColor = true;
            this.BtnToyCollectables.Click += new System.EventHandler(this.BtnToyCollectables_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 508);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numTimesPaidForToy);
            this.Controls.Add(this.BtnToyCollectables);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numWheelSpins);
            this.Controls.Add(this.BtnRouletteWheel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numDrivingTests);
            this.Controls.Add(this.BtnDrivingSchool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numPeopleShooting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numGames);
            this.Controls.Add(this.BtnShootingGallery);
            this.Controls.Add(this.BtnPlinko);
            this.Controls.Add(this.TxtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeopleShooting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrivingTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSpins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimesPaidForToy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnPlinko;
        private System.Windows.Forms.Button BtnShootingGallery;
        private System.Windows.Forms.NumericUpDown numGames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPeopleShooting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDrivingTests;
        private System.Windows.Forms.Button BtnDrivingSchool;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numWheelSpins;
        private System.Windows.Forms.Button BtnRouletteWheel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numTimesPaidForToy;
        private System.Windows.Forms.Button BtnToyCollectables;
    }
}

