namespace AnilistAnalyzer
{
    partial class HelpWindow
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
            this.howToUseLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.howToUseSubLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // howToUseLabel
            // 
            this.howToUseLabel.AutoSize = true;
            this.howToUseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToUseLabel.Location = new System.Drawing.Point(12, 9);
            this.howToUseLabel.Name = "howToUseLabel";
            this.howToUseLabel.Size = new System.Drawing.Size(153, 29);
            this.howToUseLabel.TabIndex = 0;
            this.howToUseLabel.Text = "How To Use:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(411, 134);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // howToUseSubLabel
            // 
            this.howToUseSubLabel.AutoSize = true;
            this.howToUseSubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToUseSubLabel.Location = new System.Drawing.Point(13, 38);
            this.howToUseSubLabel.Name = "howToUseSubLabel";
            this.howToUseSubLabel.Size = new System.Drawing.Size(411, 88);
            this.howToUseSubLabel.TabIndex = 2;
            this.howToUseSubLabel.Text = "1. Log in to anilist.co\r\n2. Go to Settings>Account>GDPR Data Download\r\n3. Click t" +
    "he Download button\r\n4. Select the file with this app";
            // 
            // HelpWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 210);
            this.ControlBox = false;
            this.Controls.Add(this.howToUseSubLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.howToUseLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HelpWindow";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label howToUseLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label howToUseSubLabel;
    }
}