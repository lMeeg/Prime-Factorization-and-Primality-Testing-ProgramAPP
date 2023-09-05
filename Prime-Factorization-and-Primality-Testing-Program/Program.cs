using System;
using System.Windows.Forms;

namespace Prime_Factorization_and_Primality_Testing_Program
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

