# Prime-Factorization-and-Primality-Testing-Program

# Introduction
The Prime Factorization and Primality Testing Program is a Windows Forms application that allows users to perform prime factorization and primality testing on a given positive integer greater than 1. This program is designed to help users understand the fundamental concepts of prime numbers and factorization while providing a user-friendly interface for performing these operations.

## Technical Details
This program is written in C# and utilizes basic mathematical concepts and control structures to achieve its objectives. Here are some key technical details:

• Language: C#.<br />
• Development Environment: Visual Studio (or any C# IDE).<br />
• Platform: Windows Forms Application.<br />

## How It Works
The program consists of three main components: the user interface (Form1), the PrimeFactorization class for performing the calculations, and the Program class to run the application.

## User Interface(Form1)
The user interface provides an input field for entering a positive integer greater than 1, a "Calculate" button to trigger the calculations, and a text box for displaying the results. It also has labels to provide instructions and a title for the program.

# Functions and Classes
## PrimeFactorization Class
Factorize(int n): string: This static method takes an integer n as input and returns a string containing the prime factorization and a primality test result for the input number. If the input is invalid or less than 2, it returns an error message.
The PrimeFactorization class contains the logic for prime factorization and primality testing. Here's how it works:

1. The user enters a positive integer greater than 1 in the input field.

2. Clicking the "Calculate" button triggers the calculateButton_Click event handler.

3. The input is validated, and if it's a valid positive integer, the Factorize method from the 'PrimeFactorization' class is called.

4. The 'Factorize' method calculates the prime factors of the entered number and checks if the number itself is prime.

5. The results are displayed in the result text box.

## Form1 Class (User Interface)
• 'calculateButton_Click(object sender, EventArgs e)' : Event handler for the "Calculate" button. It reads the user input, calls PrimeFactorization. Factorize to perform the calculations, and displays the result in the text box.
• 'InitializeComponent()' : Initializes the user interface components and their properties.

## Program Class
Main(): The entry point of the application. It initializes and runs the main form.
The Program class contains the Main method that initializes and runs the application by creating an instance of Form1 and displaying it.

# Installation and Usage
1. Ensure you have a C# development environment installed (e.g., Visual Studio).

2. Clone or download the source code of the Prime Factorization and Primality Testing Program.

3. Open the project in your C# IDE.

4. Build and run the application.

5. Enter a positive integer greater than 1 in the input field and click the "Calculate" button.

6. View the prime factorization and primality test results in the text box.

# Conclusion
The Prime Factorization and Primality Testing Program provides an educational and practical tool for understanding prime numbers, factorization, and primality testing. Users can input positive integers greater than 1 to explore these mathematical concepts. This program serves as a simple and interactive way to learn and apply fundamental principles of number theory.
