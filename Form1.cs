/*
 * Project: FibonacciSynchronous
 * Filename: Form1.cs
 * Author: R. Snell
 * Date Dec. 3, 2020
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciSynchronous
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Start sequential calls to Fibonacci
        private void startButton_Click(object sender, EventArgs e)
        {
            // calculate Fibonacci(46)
            outputTextBox.Text = "Calculating Fibonacci(46)\r\n";
            outputTextBox.Refresh();    // force outputTextBox to repaint
            DateTime startTime1 = DateTime.Now; // time before calculation
            long result1 = Fibonacci(46);
            DateTime endTime1 = DateTime.Now;   // time after calculation

            // display results for Fibonacci(46)
            outputTextBox.AppendText($"Fibonacci(46) = {result1}\r\n");
            double minutes = (endTime1 - startTime1).TotalMinutes;
            outputTextBox.AppendText(
                $"Calculation time = {minutes:F6} minutes\r\n\r\n");

            // calculate Fibonacci(45)
            outputTextBox.AppendText("Calculating Fibonacci(45)\r\n");
            outputTextBox.Refresh();
            DateTime startTime2 = DateTime.Now;
            long result2 = Fibonacci(45);
            DateTime endTime2 = DateTime.Now;

            // display results for Fibonacci(45)
            outputTextBox.AppendText($"Fibonacci(45) = {result2}\r\n");
            minutes = (endTime2 - startTime1).TotalMinutes;
            outputTextBox.AppendText(
                $"Calculation time = {minutes:F6} minutes\r\n\r\n");

            // show total calculation time
            double totalMinutes = (endTime2 - startTime2).TotalMinutes;
            outputTextBox.AppendText(
                $"Total calculation time = {totalMinutes:F6} minutes\r\n");
        }

        // Recursively calculates Fibonacci Numbers
        public long Fibonacci(long n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
