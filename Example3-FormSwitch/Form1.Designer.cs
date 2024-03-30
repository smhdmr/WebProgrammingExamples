namespace FormSwitch
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
            TypeLabel = new Label();
            SwitchButton = new Button();
            TypeValueTextbox = new TextBox();
            SuspendLayout();
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(63, 42);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(253, 50);
            TypeLabel.TabIndex = 0;
            TypeLabel.Text = "Type a number here. \r\nI'll guess it at the next form xD";
            TypeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SwitchButton
            // 
            SwitchButton.Location = new Point(93, 188);
            SwitchButton.Name = "SwitchButton";
            SwitchButton.Size = new Size(186, 34);
            SwitchButton.TabIndex = 2;
            SwitchButton.Text = "Beam me up Scotty!";
            SwitchButton.UseVisualStyleBackColor = true;
            SwitchButton.Click += SwitchButton_Click;
            // 
            // TypeValueTextbox
            // 
            TypeValueTextbox.Location = new Point(113, 117);
            TypeValueTextbox.Name = "TypeValueTextbox";
            TypeValueTextbox.Size = new Size(150, 31);
            TypeValueTextbox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 244);
            Controls.Add(TypeValueTextbox);
            Controls.Add(SwitchButton);
            Controls.Add(TypeLabel);
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Switch Between Forms";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TypeLabel;
        private Button SwitchButton;
        private TextBox TypeValueTextbox;
    }
}
