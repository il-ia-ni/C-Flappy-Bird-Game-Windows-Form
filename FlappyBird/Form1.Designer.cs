namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.birdFigure = new System.Windows.Forms.PictureBox();
            this.columnTop = new System.Windows.Forms.PictureBox();
            this.columnBottom = new System.Windows.Forms.PictureBox();
            this.groundObj = new System.Windows.Forms.PictureBox();
            this.scoreCounterLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.birdFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundObj)).BeginInit();
            this.SuspendLayout();
            // 
            // birdFigure
            // 
            this.birdFigure.Image = global::FlappyBird.Properties.Resources.bird;
            this.birdFigure.Location = new System.Drawing.Point(191, 261);
            this.birdFigure.Name = "birdFigure";
            this.birdFigure.Size = new System.Drawing.Size(79, 62);
            this.birdFigure.TabIndex = 0;
            this.birdFigure.TabStop = false;
            // 
            // columnTop
            // 
            this.columnTop.BackgroundImage = global::FlappyBird.Properties.Resources.pipedown;
            this.columnTop.Location = new System.Drawing.Point(342, -377);
            this.columnTop.Name = "columnTop";
            this.columnTop.Size = new System.Drawing.Size(187, 551);
            this.columnTop.TabIndex = 1;
            this.columnTop.TabStop = false;
            // 
            // columnBottom
            // 
            this.columnBottom.Image = global::FlappyBird.Properties.Resources.pipe;
            this.columnBottom.Location = new System.Drawing.Point(622, 407);
            this.columnBottom.Name = "columnBottom";
            this.columnBottom.Size = new System.Drawing.Size(186, 489);
            this.columnBottom.TabIndex = 2;
            this.columnBottom.TabStop = false;
            // 
            // groundObj
            // 
            this.groundObj.BackgroundImage = global::FlappyBird.Properties.Resources.ground;
            this.groundObj.Location = new System.Drawing.Point(-3, 607);
            this.groundObj.Name = "groundObj";
            this.groundObj.Size = new System.Drawing.Size(1438, 115);
            this.groundObj.TabIndex = 3;
            this.groundObj.TabStop = false;
            // 
            // scoreCounterLabel
            // 
            this.scoreCounterLabel.AutoSize = true;
            this.scoreCounterLabel.BackColor = System.Drawing.Color.NavajoWhite;
            this.scoreCounterLabel.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreCounterLabel.Location = new System.Drawing.Point(121, 634);
            this.scoreCounterLabel.Name = "scoreCounterLabel";
            this.scoreCounterLabel.Size = new System.Drawing.Size(237, 66);
            this.scoreCounterLabel.TabIndex = 4;
            this.scoreCounterLabel.Text = "Score:";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1431, 723);
            this.Controls.Add(this.birdFigure);
            this.Controls.Add(this.scoreCounterLabel);
            this.Controls.Add(this.groundObj);
            this.Controls.Add(this.columnBottom);
            this.Controls.Add(this.columnTop);
            this.Name = "Form1";
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gravity_descrease_on_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gravity_increase_on_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.birdFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundObj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox birdFigure;
        private PictureBox columnTop;
        private PictureBox columnBottom;
        private PictureBox groundObj;
        private Label scoreCounterLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}