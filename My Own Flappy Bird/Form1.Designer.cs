
namespace My_Own_Flappy_Bird {
    partial class FlappyBird {
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
            this.components = new System.ComponentModel.Container();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.groundBox = new System.Windows.Forms.PictureBox();
            this.scoreBox = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.startBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.Image = global::My_Own_Flappy_Bird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(51, 85);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(60, 47);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::My_Own_Flappy_Bird.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(343, 354);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(100, 207);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 1;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::My_Own_Flappy_Bird.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(376, 1);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 171);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // groundBox
            // 
            this.groundBox.Image = global::My_Own_Flappy_Bird.Properties.Resources.ground;
            this.groundBox.Location = new System.Drawing.Point(-1, 531);
            this.groundBox.Name = "groundBox";
            this.groundBox.Size = new System.Drawing.Size(508, 65);
            this.groundBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundBox.TabIndex = 3;
            this.groundBox.TabStop = false;
            // 
            // scoreBox
            // 
            this.scoreBox.AutoSize = true;
            this.scoreBox.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBox.Location = new System.Drawing.Point(70, 552);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(87, 25);
            this.scoreBox.TabIndex = 4;
            this.scoreBox.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(343, 552);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(509, 598);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.groundBox);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.bird);
            this.Name = "FlappyBird";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox groundBox;
        private System.Windows.Forms.Label scoreBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button startBtn;
    }
}

