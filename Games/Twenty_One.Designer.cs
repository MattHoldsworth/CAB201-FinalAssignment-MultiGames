namespace Games
{
    partial class Twenty_One
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
            this.dealerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.userTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dealButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.dBust = new System.Windows.Forms.Label();
            this.pBust = new System.Windows.Forms.Label();
            this.dealerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.dPointsLabel = new System.Windows.Forms.Label();
            this.pPointsLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dGamesLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pGamesLabel = new System.Windows.Forms.Label();
            this.aceLabel = new System.Windows.Forms.Label();
            this.aceTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dealerTableLayoutPanel
            // 
            this.dealerTableLayoutPanel.ColumnCount = 8;
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.Location = new System.Drawing.Point(12, 55);
            this.dealerTableLayoutPanel.Name = "dealerTableLayoutPanel";
            this.dealerTableLayoutPanel.RowCount = 1;
            this.dealerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dealerTableLayoutPanel.Size = new System.Drawing.Size(575, 95);
            this.dealerTableLayoutPanel.TabIndex = 0;
            // 
            // userTableLayoutPanel
            // 
            this.userTableLayoutPanel.ColumnCount = 8;
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userTableLayoutPanel.Location = new System.Drawing.Point(12, 168);
            this.userTableLayoutPanel.Name = "userTableLayoutPanel";
            this.userTableLayoutPanel.RowCount = 1;
            this.userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userTableLayoutPanel.Size = new System.Drawing.Size(575, 95);
            this.userTableLayoutPanel.TabIndex = 1;
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(63, 305);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(75, 23);
            this.dealButton.TabIndex = 2;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(153, 305);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 23);
            this.hitButton.TabIndex = 3;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(245, 305);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(75, 23);
            this.standButton.TabIndex = 4;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(336, 305);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            /*/ testButton
            // 
            this.testButton.Location = new System.Drawing.Point(482, 305);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 6;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            /*/ 
            // dBust
            // 
            this.dBust.AutoSize = true;
            this.dBust.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dBust.ForeColor = System.Drawing.Color.Red;
            this.dBust.Location = new System.Drawing.Point(127, 9);
            this.dBust.Name = "dBust";
            this.dBust.Size = new System.Drawing.Size(85, 24);
            this.dBust.TabIndex = 7;
            this.dBust.Text = "BUSTED";
            // 
            // pBust
            // 
            this.pBust.AutoSize = true;
            this.pBust.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBust.ForeColor = System.Drawing.Color.Red;
            this.pBust.Location = new System.Drawing.Point(127, 269);
            this.pBust.Name = "pBust";
            this.pBust.Size = new System.Drawing.Size(85, 24);
            this.pBust.TabIndex = 8;
            this.pBust.Text = "BUSTED";
            // 
            // dealerLabel
            // 
            this.dealerLabel.AutoSize = true;
            this.dealerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerLabel.Location = new System.Drawing.Point(233, 9);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(71, 24);
            this.dealerLabel.TabIndex = 9;
            this.dealerLabel.Text = "Dealer";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(233, 269);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(68, 24);
            this.playerLabel.TabIndex = 10;
            this.playerLabel.Text = "Player";
            // 
            // dPointsLabel
            // 
            this.dPointsLabel.AutoSize = true;
            this.dPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dPointsLabel.Location = new System.Drawing.Point(317, 9);
            this.dPointsLabel.Name = "dPointsLabel";
            this.dPointsLabel.Size = new System.Drawing.Size(79, 24);
            this.dPointsLabel.TabIndex = 11;
            this.dPointsLabel.Text = "POINTS";
            // 
            // pPointsLabel
            // 
            this.pPointsLabel.AutoSize = true;
            this.pPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPointsLabel.Location = new System.Drawing.Point(317, 269);
            this.pPointsLabel.Name = "pPointsLabel";
            this.pPointsLabel.Size = new System.Drawing.Size(79, 24);
            this.pPointsLabel.TabIndex = 12;
            this.pPointsLabel.Text = "POINTS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Games won";
            // 
            // dGamesLabel
            // 
            this.dGamesLabel.AutoSize = true;
            this.dGamesLabel.BackColor = System.Drawing.Color.White;
            this.dGamesLabel.Location = new System.Drawing.Point(514, 20);
            this.dGamesLabel.Name = "dGamesLabel";
            this.dGamesLabel.Size = new System.Drawing.Size(13, 13);
            this.dGamesLabel.TabIndex = 14;
            this.dGamesLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Games won";
            // 
            // pGamesLabel
            // 
            this.pGamesLabel.AutoSize = true;
            this.pGamesLabel.BackColor = System.Drawing.Color.White;
            this.pGamesLabel.Location = new System.Drawing.Point(516, 277);
            this.pGamesLabel.Name = "pGamesLabel";
            this.pGamesLabel.Size = new System.Drawing.Size(13, 13);
            this.pGamesLabel.TabIndex = 16;
            this.pGamesLabel.Text = "0";
            // 
            // aceLabel
            // 
            this.aceLabel.AutoSize = true;
            this.aceLabel.BackColor = System.Drawing.Color.White;
            this.aceLabel.Location = new System.Drawing.Point(245, 360);
            this.aceLabel.Name = "aceLabel";
            this.aceLabel.Size = new System.Drawing.Size(13, 13);
            this.aceLabel.TabIndex = 17;
            this.aceLabel.Text = "0";
            // 
            // aceTextLabel
            // 
            this.aceTextLabel.AutoSize = true;
            this.aceTextLabel.Location = new System.Drawing.Point(264, 360);
            this.aceTextLabel.Name = "aceTextLabel";
            this.aceTextLabel.Size = new System.Drawing.Size(91, 13);
            this.aceTextLabel.TabIndex = 18;
            this.aceTextLabel.Text = "Aces with value 1";
            // 
            // Twenty_One
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 422);
            this.Controls.Add(this.aceTextLabel);
            this.Controls.Add(this.aceLabel);
            this.Controls.Add(this.pGamesLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dGamesLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pPointsLabel);
            this.Controls.Add(this.dPointsLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.dealerLabel);
            this.Controls.Add(this.pBust);
            this.Controls.Add(this.dBust);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.userTableLayoutPanel);
            this.Controls.Add(this.dealerTableLayoutPanel);
            this.Name = "Twenty_One";
            this.Text = "Twenty_One";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel dealerTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel userTableLayoutPanel;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label dBust;
        private System.Windows.Forms.Label pBust;
        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label dPointsLabel;
        private System.Windows.Forms.Label pPointsLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dGamesLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label pGamesLabel;
        private System.Windows.Forms.Label aceLabel;
        private System.Windows.Forms.Label aceTextLabel;
    }
}