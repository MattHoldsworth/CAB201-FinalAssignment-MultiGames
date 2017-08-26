namespace Games
{
    partial class Snake_Eyes
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
            this.playButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.rollButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.firstRollLabel = new System.Windows.Forms.Label();
            this.dummyTextLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playersScoreLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.houseScoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(105, 235);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 38);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Continue Playing";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(256, 235);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 38);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel Game";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(178, 90);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 2;
            this.rollButton.Text = "Roll Dice";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(287, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // firstRollLabel
            // 
            this.firstRollLabel.AutoSize = true;
            this.firstRollLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstRollLabel.Location = new System.Drawing.Point(133, 23);
            this.firstRollLabel.Name = "firstRollLabel";
            this.firstRollLabel.Size = new System.Drawing.Size(81, 20);
            this.firstRollLabel.TabIndex = 5;
            this.firstRollLabel.Text = "First Roll";
            // 
            // dummyTextLabel
            // 
            this.dummyTextLabel.AutoSize = true;
            this.dummyTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dummyTextLabel.Location = new System.Drawing.Point(92, 148);
            this.dummyTextLabel.Name = "dummyTextLabel";
            this.dummyTextLabel.Size = new System.Drawing.Size(100, 20);
            this.dummyTextLabel.TabIndex = 6;
            this.dummyTextLabel.Text = "dummy text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Player\'s Score";
            // 
            // playersScoreLabel
            // 
            this.playersScoreLabel.AutoSize = true;
            this.playersScoreLabel.BackColor = System.Drawing.Color.White;
            this.playersScoreLabel.Location = new System.Drawing.Point(152, 196);
            this.playersScoreLabel.Name = "playersScoreLabel";
            this.playersScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.playersScoreLabel.TabIndex = 8;
            this.playersScoreLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(205, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "House Score";
            // 
            // houseScoreLabel
            // 
            this.houseScoreLabel.AutoSize = true;
            this.houseScoreLabel.BackColor = System.Drawing.Color.White;
            this.houseScoreLabel.Location = new System.Drawing.Point(334, 193);
            this.houseScoreLabel.Name = "houseScoreLabel";
            this.houseScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.houseScoreLabel.TabIndex = 10;
            this.houseScoreLabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Snake_Eyes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 353);
            this.Controls.Add(this.houseScoreLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.playersScoreLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dummyTextLabel);
            this.Controls.Add(this.firstRollLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.playButton);
            this.Name = "Snake_Eyes";
            this.Text = "Snake_Eyes";
            this.Load += new System.EventHandler(this.Snake_Eyes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label firstRollLabel;
        private System.Windows.Forms.Label dummyTextLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playersScoreLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label houseScoreLabel;
        private System.Windows.Forms.Timer timer1;
    }
}