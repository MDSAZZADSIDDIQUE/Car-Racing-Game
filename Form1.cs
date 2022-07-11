using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        int carSpeed = 0;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            txtGameOver.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movingRoad();
            movingTruck();
            gameOver();
        }

        public void movingRoad()
        {
            if (pBTile1.Top <= 510)
                pBTile1.Top += carSpeed;
            else
                pBTile1.Top = 0;
            if (pBTile2.Top <= 5100)
                pBTile2.Top += carSpeed;
            else
                pBTile2.Top = 0;
        }

        public void movingTruck()
        {
            if (pBTruck.Top <= 600)
                pBTruck.Top += carSpeed;
            else
            {
                pBTruck.Top = 0;
                pBTruck.Location = new Point(random.Next(0, 800), 0);
            }
        }

        public void gameOver()
        {
            if (pBCar.Bounds.IntersectsWith(pBTruck.Bounds))
            {
                timer1.Enabled = false;
                txtGameOver.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pBCar.Left >= 25)
                    pBCar.Left += -10;
            }    
            if (e.KeyCode == Keys.Right)
            {
                if (pBCar.Left <= 492)
                    pBCar.Left += 10;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (carSpeed <= 20)
                    carSpeed++;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (carSpeed > 0)
                    carSpeed--;
            }
            if (carSpeed > 0)
                score += carSpeed;
            lblSpeed.Text = "Speed: " + carSpeed + " km/h";
            lblScore.Text = "Score: " + score;
        }

        private void pBCar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
