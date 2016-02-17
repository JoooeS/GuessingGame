namespace GuessingGame
{
    partial class Results
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
            this.congratulationLabel = new System.Windows.Forms.Label();
            this.numberOfGuessesLabel = new System.Windows.Forms.Label();
            this.guessesLabel = new System.Windows.Forms.Label();
            this.sortedOrderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // congratulationLabel
            // 
            this.congratulationLabel.Location = new System.Drawing.Point(13, 13);
            this.congratulationLabel.Name = "congratulationLabel";
            this.congratulationLabel.Size = new System.Drawing.Size(259, 23);
            this.congratulationLabel.TabIndex = 0;
            this.congratulationLabel.Text = "Congrats! You won!";
            this.congratulationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfGuessesLabel
            // 
            this.numberOfGuessesLabel.Location = new System.Drawing.Point(13, 153);
            this.numberOfGuessesLabel.Name = "numberOfGuessesLabel";
            this.numberOfGuessesLabel.Size = new System.Drawing.Size(259, 23);
            this.numberOfGuessesLabel.TabIndex = 1;
            this.numberOfGuessesLabel.Text = "Correct Number: ";
            this.numberOfGuessesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guessesLabel
            // 
            this.guessesLabel.Location = new System.Drawing.Point(13, 197);
            this.guessesLabel.Name = "guessesLabel";
            this.guessesLabel.Size = new System.Drawing.Size(259, 23);
            this.guessesLabel.TabIndex = 2;
            this.guessesLabel.Text = "Guesses: ";
            this.guessesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortedOrderLabel
            // 
            this.sortedOrderLabel.Location = new System.Drawing.Point(12, 229);
            this.sortedOrderLabel.Name = "sortedOrderLabel";
            this.sortedOrderLabel.Size = new System.Drawing.Size(259, 23);
            this.sortedOrderLabel.TabIndex = 3;
            this.sortedOrderLabel.Text = "Sorted Order:";
            this.sortedOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sortedOrderLabel);
            this.Controls.Add(this.guessesLabel);
            this.Controls.Add(this.numberOfGuessesLabel);
            this.Controls.Add(this.congratulationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Results";
            this.Text = "Results";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label congratulationLabel;
        private System.Windows.Forms.Label numberOfGuessesLabel;
        private System.Windows.Forms.Label guessesLabel;
        private System.Windows.Forms.Label sortedOrderLabel;
    }
}