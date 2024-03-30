namespace FormSwitch
{
    public partial class Form2 : Form
    {
        public int GuessValue { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GuessValueLabel.Text = GuessValue.ToString();
        }
    }
}
