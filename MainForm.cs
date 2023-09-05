using System;
using System.Windows.Forms;

namespace PrimeFactorizationApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();

            if (input.ToLower() == "exit")
            {
                Application.Exit();
                return;
            }

            if (int.TryParse(input, out int n) && n > 1)
            {
                string result = PrimeFactorization.Factorize(n);
                lblResult.Text = result;
            }
            else
            {
                lblResult.Text = "Invalid input. You should enter a positive integer greater than 1.";
            }
        }
    }
}
