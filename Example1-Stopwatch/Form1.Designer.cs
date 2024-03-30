namespace Stopwatch
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
            components = new System.ComponentModel.Container();
            ElapsedTimeLabel = new Label();
            ElapsedTimeValueLabel = new Label();
            StopwatchTimer = new System.Windows.Forms.Timer(components);
            StartButton = new Button();
            StopButton = new Button();
            SuspendLayout();
            // 
            // ElapsedTimeLabel
            // 
            ElapsedTimeLabel.AutoSize = true;
            ElapsedTimeLabel.Location = new Point(128, 40);
            ElapsedTimeLabel.Name = "ElapsedTimeLabel";
            ElapsedTimeLabel.Size = new Size(116, 25);
            ElapsedTimeLabel.TabIndex = 1;
            ElapsedTimeLabel.Text = "Elapsed Time";
            ElapsedTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ElapsedTimeValueLabel
            // 
            ElapsedTimeValueLabel.AutoSize = true;
            ElapsedTimeValueLabel.Location = new Point(148, 94);
            ElapsedTimeValueLabel.Name = "ElapsedTimeValueLabel";
            ElapsedTimeValueLabel.Size = new Size(80, 25);
            ElapsedTimeValueLabel.TabIndex = 2;
            ElapsedTimeValueLabel.Text = "00:00:00";
            ElapsedTimeValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StopwatchTimer
            // 
            StopwatchTimer.Interval = 1000;
            StopwatchTimer.Tick += StopwatchTimer_Tick;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(64, 156);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(112, 34);
            StartButton.TabIndex = 3;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Enabled = false;
            StopButton.Location = new Point(197, 156);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(112, 34);
            StopButton.TabIndex = 4;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 244);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Controls.Add(ElapsedTimeValueLabel);
            Controls.Add(ElapsedTimeLabel);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stopwatch";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ElapsedTimeLabel;
        private Label ElapsedTimeValueLabel;
        private System.Windows.Forms.Timer StopwatchTimer;
        private Button StartButton;
        private Button StopButton;
    }
}
