namespace Games
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cardGameButton = new System.Windows.Forms.RadioButton();
            this.diceGameButton = new System.Windows.Forms.RadioButton();
            this.coinGameButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Games World";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cardGameButton);
            this.groupBox1.Controls.Add(this.diceGameButton);
            this.groupBox1.Controls.Add(this.coinGameButton);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox1.Location = new System.Drawing.Point(33, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Game Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cardGameButton
            // 
            this.cardGameButton.AutoSize = true;
            this.cardGameButton.Location = new System.Drawing.Point(42, 77);
            this.cardGameButton.Name = "cardGameButton";
            this.cardGameButton.Size = new System.Drawing.Size(78, 17);
            this.cardGameButton.TabIndex = 2;
            this.cardGameButton.Text = "Card Game";
            this.cardGameButton.UseVisualStyleBackColor = true;
            this.cardGameButton.CheckedChanged += new System.EventHandler(this.cardGameButton_CheckedChanged);
            // 
            // diceGameButton
            // 
            this.diceGameButton.AutoSize = true;
            this.diceGameButton.Location = new System.Drawing.Point(42, 54);
            this.diceGameButton.Name = "diceGameButton";
            this.diceGameButton.Size = new System.Drawing.Size(78, 17);
            this.diceGameButton.TabIndex = 1;
            this.diceGameButton.Text = "Dice Game";
            this.diceGameButton.UseVisualStyleBackColor = true;
            this.diceGameButton.CheckedChanged += new System.EventHandler(this.diceGameButton_CheckedChanged);
            // 
            // coinGameButton
            // 
            this.coinGameButton.AutoSize = true;
            this.coinGameButton.Location = new System.Drawing.Point(42, 30);
            this.coinGameButton.Name = "coinGameButton";
            this.coinGameButton.Size = new System.Drawing.Size(77, 17);
            this.coinGameButton.TabIndex = 0;
            this.coinGameButton.Text = "Coin Game";
            this.coinGameButton.UseVisualStyleBackColor = true;
            this.coinGameButton.CheckedChanged += new System.EventHandler(this.coinGameButton_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(93, 233);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(93, 293);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 369);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Games";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cardGameButton;
        private System.Windows.Forms.RadioButton diceGameButton;
        private System.Windows.Forms.RadioButton coinGameButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
    }
}

