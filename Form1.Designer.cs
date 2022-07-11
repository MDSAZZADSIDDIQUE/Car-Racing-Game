namespace Car_Racing_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pBTile2 = new System.Windows.Forms.PictureBox();
            this.pBTile1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pBCar = new System.Windows.Forms.PictureBox();
            this.pBTruck = new System.Windows.Forms.PictureBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txtGameOver = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTruck)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 529);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(760, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 529);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pBTile2
            // 
            this.pBTile2.BackColor = System.Drawing.SystemColors.Control;
            this.pBTile2.Location = new System.Drawing.Point(368, 351);
            this.pBTile2.Name = "pBTile2";
            this.pBTile2.Size = new System.Drawing.Size(10, 190);
            this.pBTile2.TabIndex = 0;
            this.pBTile2.TabStop = false;
            this.pBTile2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pBTile1
            // 
            this.pBTile1.BackColor = System.Drawing.SystemColors.Control;
            this.pBTile1.Location = new System.Drawing.Point(368, 12);
            this.pBTile1.Name = "pBTile1";
            this.pBTile1.Size = new System.Drawing.Size(10, 190);
            this.pBTile1.TabIndex = 0;
            this.pBTile1.TabStop = false;
            this.pBTile1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pBCar
            // 
            this.pBCar.Image = ((System.Drawing.Image)(resources.GetObject("pBCar.Image")));
            this.pBCar.Location = new System.Drawing.Point(658, 349);
            this.pBCar.Name = "pBCar";
            this.pBCar.Size = new System.Drawing.Size(96, 192);
            this.pBCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBCar.TabIndex = 1;
            this.pBCar.TabStop = false;
            this.pBCar.Click += new System.EventHandler(this.pBCar_Click);
            // 
            // pBTruck
            // 
            this.pBTruck.Image = ((System.Drawing.Image)(resources.GetObject("pBTruck.Image")));
            this.pBTruck.Location = new System.Drawing.Point(28, 57);
            this.pBTruck.Name = "pBTruck";
            this.pBTruck.Size = new System.Drawing.Size(160, 160);
            this.pBTruck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBTruck.TabIndex = 1;
            this.pBTruck.TabStop = false;
            this.pBTruck.Click += new System.EventHandler(this.pBCar_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(9, 12);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(267, 42);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "Speed: 0 km/h";
            // 
            // txtGameOver
            // 
            this.txtGameOver.AutoSize = true;
            this.txtGameOver.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtGameOver.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameOver.Location = new System.Drawing.Point(-4, 206);
            this.txtGameOver.Name = "txtGameOver";
            this.txtGameOver.Size = new System.Drawing.Size(728, 149);
            this.txtGameOver.TabIndex = 3;
            this.txtGameOver.Text = "Game Over";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(578, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(164, 42);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.txtGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.pBTruck);
            this.Controls.Add(this.pBCar);
            this.Controls.Add(this.pBTile1);
            this.Controls.Add(this.pBTile2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTruck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pBTile2;
        private System.Windows.Forms.PictureBox pBTile1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pBCar;
        private System.Windows.Forms.PictureBox pBTruck;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label txtGameOver;
        private System.Windows.Forms.Label lblScore;
    }
}

