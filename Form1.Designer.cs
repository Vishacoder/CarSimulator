namespace CarSimulator
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.won1 = new System.Windows.Forms.PictureBox();
            this.ai1 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.won1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.won1);
            this.panel1.Controls.Add(this.ai1);
            this.panel1.Controls.Add(this.car1);
            this.panel1.Controls.Add(this.car3);
            this.panel1.Controls.Add(this.car2);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 582);
            this.panel1.TabIndex = 0;
            // 
            // won1
            // 
            this.won1.BackColor = System.Drawing.Color.Transparent;
            this.won1.BackgroundImage = global::CarSimulator.Properties.Resources.ChatGPT_Image_Jul_16__2025__08_33_40_PM;
            this.won1.Image = global::CarSimulator.Properties.Resources.ChatGPT_Image_Jul_20__2025__12_17_30_AM;
            this.won1.Location = new System.Drawing.Point(156, 179);
            this.won1.Name = "won1";
            this.won1.Size = new System.Drawing.Size(246, 198);
            this.won1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.won1.TabIndex = 8;
            this.won1.TabStop = false;
            this.won1.Click += new System.EventHandler(this.won1_Click);
            // 
            // ai1
            // 
            this.ai1.BackColor = System.Drawing.Color.Transparent;
            this.ai1.BackgroundImage = global::CarSimulator.Properties.Resources.ChatGPT_Image_Jul_16__2025__08_33_40_PM;
            this.ai1.Image = global::CarSimulator.Properties.Resources.ChatGPT_Image_Jul_19__2025__10_15_00_PM;
            this.ai1.Location = new System.Drawing.Point(102, 383);
            this.ai1.Name = "ai1";
            this.ai1.Size = new System.Drawing.Size(109, 100);
            this.ai1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ai1.TabIndex = 7;
            this.ai1.TabStop = false;
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.BackgroundImage = global::CarSimulator.Properties.Resources.ChatGPT_Image_Jul_16__2025__08_33_40_PM;
            this.car1.Image = global::CarSimulator.Properties.Resources.ChatGPT_Image_Jul_16__2025__09_34_12_PM;
            this.car1.Location = new System.Drawing.Point(405, 489);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(85, 84);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 6;
            this.car1.TabStop = false;
            // 
            // car3
            // 
            this.car3.BackColor = System.Drawing.Color.Transparent;
            this.car3.BackgroundImage = global::CarSimulator.Properties.Resources.ChatGPT_Image_Jul_16__2025__08_33_40_PM;
            this.car3.Image = global::CarSimulator.Properties.Resources.ChatGPT_Image_Jul_18__2025__07_35_36_PM;
            this.car3.Location = new System.Drawing.Point(426, 58);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(64, 72);
            this.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car3.TabIndex = 4;
            this.car3.TabStop = false;
            this.car3.Tag = "carRight";
            // 
            // car2
            // 
            this.car2.BackColor = System.Drawing.Color.Transparent;
            this.car2.BackgroundImage = global::CarSimulator.Properties.Resources.ChatGPT_Image_Jul_16__2025__08_33_40_PM;
            this.car2.Image = global::CarSimulator.Properties.Resources.ChatGPT_Image_Jul_19__2025__08_02_32_PM;
            this.car2.Location = new System.Drawing.Point(219, 36);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(91, 94);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 3;
            this.car2.TabStop = false;
            this.car2.Tag = "carLeft";
            // 
            // roadTrack2
            // 
            this.roadTrack2.BackColor = System.Drawing.Color.Transparent;
            this.roadTrack2.Image = global::CarSimulator.Properties.Resources.Road_2;
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(566, 596);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 1;
            this.roadTrack2.TabStop = false;
            this.roadTrack2.Click += new System.EventHandler(this.roadTrack2_Click);
            // 
            // roadTrack1
            // 
            this.roadTrack1.Image = global::CarSimulator.Properties.Resources.Road_2;
            this.roadTrack1.Location = new System.Drawing.Point(0, -800);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(560, 821);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            this.roadTrack1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(243, 642);
            this.btnStart.Name = "btnStart";
            this.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnStart.Size = new System.Drawing.Size(92, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 711);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.won1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car3;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox ai1;
        private System.Windows.Forms.PictureBox won1;
        private System.Windows.Forms.Timer gameTimer;
    }
}

