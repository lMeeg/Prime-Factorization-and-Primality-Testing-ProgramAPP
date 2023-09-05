using System.Windows.Forms;
using System;

namespace Prime_Factorization_and_Primality_Testing_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
       

            try
            {
                string input = inputTextBox.Text.Trim();

                if (input.ToLower() == "exit")
                {
                    Close();
                    return;
                }

                if (int.TryParse(input, out int number) && number > 1)
                {
                    string result = PrimeFactorization.Factorize(number);
                    resultTextBox.Text = result;
                }
                else
                {
                    resultTextBox.Text = "Invalid input. You should enter a positive integer greater than 1.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
