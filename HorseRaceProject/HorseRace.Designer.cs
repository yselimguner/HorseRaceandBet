
namespace HorseRaceProject
{
    partial class HorseRace
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HorseRace));
            this.pcBox1 = new System.Windows.Forms.PictureBox();
            this.pcBox2 = new System.Windows.Forms.PictureBox();
            this.pcbox3 = new System.Windows.Forms.PictureBox();
            this.startBTN = new System.Windows.Forms.Button();
            this.resetBTN = new System.Windows.Forms.Button();
            this.finishBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.InfoText = new System.Windows.Forms.Label();
            this.betBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBox1
            // 
            this.pcBox1.Image = ((System.Drawing.Image)(resources.GetObject("pcBox1.Image")));
            this.pcBox1.Location = new System.Drawing.Point(29, 30);
            this.pcBox1.Name = "pcBox1";
            this.pcBox1.Size = new System.Drawing.Size(100, 50);
            this.pcBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBox1.TabIndex = 0;
            this.pcBox1.TabStop = false;
            // 
            // pcBox2
            // 
            this.pcBox2.Image = ((System.Drawing.Image)(resources.GetObject("pcBox2.Image")));
            this.pcBox2.Location = new System.Drawing.Point(29, 98);
            this.pcBox2.Name = "pcBox2";
            this.pcBox2.Size = new System.Drawing.Size(100, 50);
            this.pcBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBox2.TabIndex = 1;
            this.pcBox2.TabStop = false;
            // 
            // pcbox3
            // 
            this.pcbox3.Image = ((System.Drawing.Image)(resources.GetObject("pcbox3.Image")));
            this.pcbox3.Location = new System.Drawing.Point(29, 169);
            this.pcbox3.Name = "pcbox3";
            this.pcbox3.Size = new System.Drawing.Size(100, 50);
            this.pcbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbox3.TabIndex = 2;
            this.pcbox3.TabStop = false;
            // 
            // startBTN
            // 
            this.startBTN.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.startBTN.Location = new System.Drawing.Point(132, 264);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(79, 33);
            this.startBTN.TabIndex = 3;
            this.startBTN.Text = "START";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // resetBTN
            // 
            this.resetBTN.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.resetBTN.Location = new System.Drawing.Point(250, 264);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(81, 33);
            this.resetBTN.TabIndex = 4;
            this.resetBTN.Text = "RESET";
            this.resetBTN.UseVisualStyleBackColor = true;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // finishBTN
            // 
            this.finishBTN.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.finishBTN.Location = new System.Drawing.Point(610, 12);
            this.finishBTN.Name = "finishBTN";
            this.finishBTN.Size = new System.Drawing.Size(15, 275);
            this.finishBTN.TabIndex = 5;
            this.finishBTN.Text = "FINISH";
            this.finishBTN.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.InfoText.Location = new System.Drawing.Point(228, 9);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(41, 19);
            this.InfoText.TabIndex = 6;
            this.InfoText.Text = "label1";
            // 
            // betBTN
            // 
            this.betBTN.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.betBTN.Location = new System.Drawing.Point(456, 295);
            this.betBTN.Name = "betBTN";
            this.betBTN.Size = new System.Drawing.Size(108, 37);
            this.betBTN.TabIndex = 7;
            this.betBTN.Text = "TAKE BET";
            this.betBTN.UseVisualStyleBackColor = true;
            this.betBTN.Click += new System.EventHandler(this.betBTN_Click);
            // 
            // HorseRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 332);
            this.Controls.Add(this.betBTN);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.finishBTN);
            this.Controls.Add(this.resetBTN);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.pcbox3);
            this.Controls.Add(this.pcBox2);
            this.Controls.Add(this.pcBox1);
            this.Name = "HorseRace";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBox1;
        private System.Windows.Forms.PictureBox pcBox2;
        private System.Windows.Forms.PictureBox pcbox3;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button resetBTN;
        private System.Windows.Forms.Button finishBTN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Button betBTN;
    }
}

