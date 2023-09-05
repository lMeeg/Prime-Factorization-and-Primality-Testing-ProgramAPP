using System;
using System.Windows.Forms;


namespace Prime_Factorization_and_Primality_Testing_Program
{
    public partial class Form1 : Form
    {
        private Label titleLabel;
        private Label inputLabel;
        private TextBox inputTextBox;
        private Button calculateButton;
        private TextBox resultTextBox;


        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(590, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Prime Factorization and Primality Testing Program";

            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(30, 80);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(370, 24);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Enter a positive integer greater than 1:";

            this.inputTextBox.Location = new System.Drawing.Point(30, 120);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(200, 20);
            this.inputTextBox.TabIndex = 2;

            this.calculateButton.Location = new System.Drawing.Point(250, 120);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(80, 25);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);

            this.resultTextBox.Location = new System.Drawing.Point(34, 159);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(296, 47);
            this.resultTextBox.TabIndex = 4;          
           
            this.ClientSize = new System.Drawing.Size(613, 374);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultTextBox);
            this.Name = "Form1";
            this.Text = "Prime Factorization and Primality Testing Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
