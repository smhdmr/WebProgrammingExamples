namespace FormSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            // Do nothing if textbox value is not a number
            var isTypeValueNumber = int.TryParse(TypeValueTextbox.Text, out var typeValue);
            if (!isTypeValueNumber)
            {
                return;
            }

            // Hide the current form
            this.Hide();

            // Create second form, pass data and show
            var form2 = new Form2();
            form2.GuessValue = typeValue;
            form2.Show();

            // Close application when user closes form2
            form2.FormClosed += (_, _) => Application.Exit();
        }
    }
}