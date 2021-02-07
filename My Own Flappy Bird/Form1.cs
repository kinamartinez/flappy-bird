using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Own_Flappy_Bird {
    public partial class FlappyBird : Form {

        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;

        public FlappyBird() {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e) {
            bird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreBox.Text = "Score:"+ " " + score.ToString();

            if (pipeBottom.Left < -150) {
                pipeBottom.Left = 400;
                score++;
            }
            if (pipeTop.Left < -180) {
                pipeTop.Left = 650;
                score++;
            }
            if (bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                bird.Bounds.IntersectsWith(pipeTop.Bounds) || 
                bird.Bounds.IntersectsWith(groundBox.Bounds) || bird.Top < -25) {
                endGame();
            }
            if(score > 5) {
                pipeSpeed = 15;
            }

        }

        private void gameKeyIsDown(object sender, KeyEventArgs e) {

            if(e.KeyCode == Keys.Space) {
                gravity = -5;
            }

        }

        private void gameKeyIsUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                gravity = 15;
            }
        }

        private void endGame() {
            gameTimer.Stop();
            scoreBox.Text += " Game Over!";
            startBtn.Enabled = true;

        }

        private void startBtn_Click(object sender, EventArgs e) {
            gameTimer.Enabled = true;
            startBtn.Enabled = false;
            score = 0;
            bird.Top = 15;
        }
    }
}
