namespace Stopwatch
{
    public partial class Form1 : Form
    {
        // Set initial elapsed time as 0
        private TimeSpan elapsedTime = TimeSpan.Zero;

        public Form1()
        {
            InitializeComponent();
        }

        // Executes on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set initial screen value
            ElapsedTimeValueLabel.Text = elapsedTime.ToString();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ResetStopwatch();

            // Start stopwatch
            StopwatchTimer.Start();

            // Switch buttons
            StartButton.Enabled = false;
            StopButton.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            // Stop stopwatch
            StopwatchTimer.Stop();

            // Switch buttons
            StartButton.Enabled = true;
            StopButton.Enabled = false;
        }
            
        /// <summary>
        /// Resets elapsed time and screen value
        /// </summary>
        private void ResetStopwatch()
        {
            elapsedTime = TimeSpan.Zero;
            ElapsedTimeValueLabel.Text = elapsedTime.ToString();
        }

        // Executes on each stopwatch tick
        // Can be edited from form designer
        // In this example tick is set to 1000 (1 second)
        private void StopwatchTimer_Tick(object sender, EventArgs e)
        {
            // Increase remaining time 1 second
            elapsedTime += TimeSpan.FromSeconds(1);

            // Update screen value
            ElapsedTimeValueLabel.Text = elapsedTime.ToString();
        }
    }
}
