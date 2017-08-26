namespace Games
{
    partial class Crazy_Eights
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
            this.playerLabel = new System.Windows.Forms.Label();
            this.computerLabel = new System.Windows.Forms.Label();
            this.dealButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.cTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.drawPile = new System.Windows.Forms.PictureBox();
            this.discardPile = new System.Windows.Forms.PictureBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawPile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discardPile)).BeginInit();
            this.SuspendLayout();
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.playerLabel.Location = new System.Drawing.Point(436, 565);
            this.playerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(106, 37);
            this.playerLabel.TabIndex = 0;
            this.playerLabel.Text = "Player";
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.725F);
            this.computerLabel.Location = new System.Drawing.Point(405, 14);
            this.computerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(158, 37);
            this.computerLabel.TabIndex = 1;
            this.computerLabel.Text = "Computer";
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(108, 614);
            this.dealButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(112, 35);
            this.dealButton.TabIndex = 2;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(366, 635);
            this.sortButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(228, 35);
            this.sortButton.TabIndex = 3;
            this.sortButton.Text = "Sort Player\'s Hand";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(716, 614);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 35);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel Game";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // cTableLayoutPanel
            // 
            this.cTableLayoutPanel.AutoSize = true;
            this.cTableLayoutPanel.ColumnCount = 13;
            this.cTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.cTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.cTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.cTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.cTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.cTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.cTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.cTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.cTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.cTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.cTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.cTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.cTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.cTableLayoutPanel.Location = new System.Drawing.Point(33, 57);
            this.cTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cTableLayoutPanel.Name = "cTableLayoutPanel";
            this.cTableLayoutPanel.RowCount = 1;
            this.cTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.cTableLayoutPanel.Size = new System.Drawing.Size(855, 146);
            this.cTableLayoutPanel.TabIndex = 5;
            // 
            // pTableLayoutPanel
            // 
            this.pTableLayoutPanel.AutoSize = true;
            this.pTableLayoutPanel.ColumnCount = 13;
            this.pTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.pTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.pTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.pTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.pTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.pTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.pTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.pTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.pTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.pTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.pTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.pTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.pTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.pTableLayoutPanel.Location = new System.Drawing.Point(33, 414);
            this.pTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pTableLayoutPanel.Name = "pTableLayoutPanel";
            this.pTableLayoutPanel.RowCount = 1;
            this.pTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.pTableLayoutPanel.Size = new System.Drawing.Size(855, 146);
            this.pTableLayoutPanel.TabIndex = 6;
            // 
            // drawPile
            // 
            this.drawPile.Location = new System.Drawing.Point(366, 237);
            this.drawPile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drawPile.Name = "drawPile";
            this.drawPile.Size = new System.Drawing.Size(105, 146);
            this.drawPile.TabIndex = 7;
            this.drawPile.TabStop = false;
            // 
            // discardPile
            // 
            this.discardPile.Location = new System.Drawing.Point(504, 237);
            this.discardPile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.discardPile.Name = "discardPile";
            this.discardPile.Size = new System.Drawing.Size(105, 146);
            this.discardPile.TabIndex = 8;
            this.discardPile.TabStop = false;
            // 
            // instructionLabel
            // 
            this.instructionLabel.BackColor = System.Drawing.Color.White;
            this.instructionLabel.Location = new System.Drawing.Point(618, 289);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(270, 62);
            this.instructionLabel.TabIndex = 9;
            this.instructionLabel.Text = "                                        ";
            // 
            // Crazy_Eights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(897, 683);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.discardPile);
            this.Controls.Add(this.drawPile);
            this.Controls.Add(this.pTableLayoutPanel);
            this.Controls.Add(this.cTableLayoutPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.playerLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Crazy_Eights";
            this.Text = "Crazy_Eights";
            ((System.ComponentModel.ISupportInitialize)(this.drawPile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discardPile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel cTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel pTableLayoutPanel;
        private System.Windows.Forms.PictureBox drawPile;
        private System.Windows.Forms.PictureBox discardPile;
        private System.Windows.Forms.Label instructionLabel;
    }
}