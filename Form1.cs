
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text; // Get the name entered in the textbox
            MessageBox.Show($"Hello, {name}! Welcome to the WinForms App!"); // Show a greeting message
        }
    }
}