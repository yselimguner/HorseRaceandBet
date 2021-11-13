
namespace HorseRaceProject
{
    partial class BetForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnFirstHorse = new System.Windows.Forms.RadioButton();
            this.rdBtnSecondHorse = new System.Windows.Forms.RadioButton();
            this.rdBtnThirdHorse = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.confirmBTN = new System.Windows.Forms.Button();
            this.racePageBTN = new System.Windows.Forms.Button();
            this.EstimatedLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EstimatedLbl);
            this.groupBox1.Controls.Add(this.confirmBTN);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdBtnThirdHorse);
            this.groupBox1.Controls.Add(this.rdBtnSecondHorse);
            this.groupBox1.Controls.Add(this.rdBtnFirstHorse);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(38, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BET BOARD";
            // 
            // rdBtnFirstHorse
            // 
            this.rdBtnFirstHorse.AutoSize = true;
            this.rdBtnFirstHorse.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.rdBtnFirstHorse.Location = new System.Drawing.Point(6, 64);
            this.rdBtnFirstHorse.Name = "rdBtnFirstHorse";
            this.rdBtnFirstHorse.Size = new System.Drawing.Size(89, 23);
            this.rdBtnFirstHorse.TabIndex = 0;
            this.rdBtnFirstHorse.TabStop = true;
            this.rdBtnFirstHorse.Text = "First Horse";
            this.rdBtnFirstHorse.UseVisualStyleBackColor = true;
            // 
            // rdBtnSecondHorse
            // 
            this.rdBtnSecondHorse.AutoSize = true;
            this.rdBtnSecondHorse.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.rdBtnSecondHorse.Location = new System.Drawing.Point(6, 87);
            this.rdBtnSecondHorse.Name = "rdBtnSecondHorse";
            this.rdBtnSecondHorse.Size = new System.Drawing.Size(102, 23);
            this.rdBtnSecondHorse.TabIndex = 1;
            this.rdBtnSecondHorse.TabStop = true;
            this.rdBtnSecondHorse.Text = "Second Horse";
            this.rdBtnSecondHorse.UseVisualStyleBackColor = true;
            // 
            // rdBtnThirdHorse
            // 
            this.rdBtnThirdHorse.AutoSize = true;
            this.rdBtnThirdHorse.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.rdBtnThirdHorse.Location = new System.Drawing.Point(6, 111);
            this.rdBtnThirdHorse.Name = "rdBtnThirdHorse";
            this.rdBtnThirdHorse.Size = new System.Drawing.Size(93, 23);
            this.rdBtnThirdHorse.TabIndex = 2;
            this.rdBtnThirdHorse.TabStop = true;
            this.rdBtnThirdHorse.Text = "Third Horse";
            this.rdBtnThirdHorse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "PICK HORSE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(246, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "BET AMOUNT";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(228, 64);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(127, 31);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // confirmBTN
            // 
            this.confirmBTN.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.confirmBTN.Location = new System.Drawing.Point(250, 170);
            this.confirmBTN.Name = "confirmBTN";
            this.confirmBTN.Size = new System.Drawing.Size(101, 41);
            this.confirmBTN.TabIndex = 6;
            this.confirmBTN.Text = "CONFIRM BET";
            this.confirmBTN.UseVisualStyleBackColor = true;
            this.confirmBTN.Click += new System.EventHandler(this.confirmBTN_Click);
            // 
            // racePageBTN
            // 
            this.racePageBTN.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold);
            this.racePageBTN.Location = new System.Drawing.Point(359, 259);
            this.racePageBTN.Name = "racePageBTN";
            this.racePageBTN.Size = new System.Drawing.Size(114, 62);
            this.racePageBTN.TabIndex = 1;
            this.racePageBTN.Text = "GO TO RACE";
            this.racePageBTN.UseVisualStyleBackColor = true;
            this.racePageBTN.Click += new System.EventHandler(this.racePageBTN_Click);
            // 
            // EstimatedLbl
            // 
            this.EstimatedLbl.AutoSize = true;
            this.EstimatedLbl.Location = new System.Drawing.Point(228, 111);
            this.EstimatedLbl.Name = "EstimatedLbl";
            this.EstimatedLbl.Size = new System.Drawing.Size(0, 24);
            this.EstimatedLbl.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.label3.Location = new System.Drawing.Point(44, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 76);
            this.label3.TabIndex = 2;
            this.label3.Text = "Participation must be at least 5$.\r\nFirst Horse Rate 1.5 \r\nSecond Horse Rate 1.9\r" +
    "\nThird Horse Rate 2.4\r\n";
            // 
            // BetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.racePageBTN);
            this.Controls.Add(this.groupBox1);
            this.Name = "BetForm";
            this.Text = "BetForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button confirmBTN;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBtnThirdHorse;
        private System.Windows.Forms.RadioButton rdBtnSecondHorse;
        private System.Windows.Forms.RadioButton rdBtnFirstHorse;
        private System.Windows.Forms.Button racePageBTN;
        private System.Windows.Forms.Label EstimatedLbl;
        private System.Windows.Forms.Label label3;
    }
}