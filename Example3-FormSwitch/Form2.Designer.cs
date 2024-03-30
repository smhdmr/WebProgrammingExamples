namespace FormSwitch
{
    partial class Form2
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
            GuessLabel = new Label();
            GuessValueLabel = new Label();
            SuspendLayout();
            // 
            // GuessLabel
            // 
            GuessLabel.AutoSize = true;
            GuessLabel.Location = new Point(91, 70);
            GuessLabel.Name = "GuessLabel";
            GuessLabel.Size = new Size(187, 25);
            GuessLabel.TabIndex = 0;
            GuessLabel.Text = "Did i guess it right? :D";
            GuessLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GuessValueLabel
            // 
            GuessValueLabel.AutoSize = true;
            GuessValueLabel.Location = new Point(171, 138);
            GuessValueLabel.Name = "GuessValueLabel";
            GuessValueLabel.Size = new Size(32, 25);
            GuessValueLabel.TabIndex = 1;
            GuessValueLabel.Text = "13";
            GuessValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 244);
            Controls.Add(GuessValueLabel);
            Controls.Add(GuessLabel);
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GuessLabel;
        private Label GuessValueLabel;
    }
}