using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region DataMembers
        enum Operation
        {
            ADD,
            SUBSTRACT,
            MULTIPLY,
            DEVIDE,
            NO_OP
        }

        double input = 0, result = 0;
        double number1 = 0, number2 = 0;
        Operation operation = Operation.NO_OP;
        #endregion
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Utilities
        private void TypeDigit(string digit)
        {
            if (txtInput.Text.Equals("0"))
            {
                txtInput.Text = digit;
            }
            else
            {
                txtInput.Text += digit;
            }
        }

        private void SaveOperation(string opCode)
        {
            input = Double.Parse(txtInput.Text);
            switch (opCode)
            {
                case "+": operation = Operation.ADD; break;
                case "-": operation = Operation.SUBSTRACT; break;
                case "*": operation = Operation.MULTIPLY; break;
                case "/": operation = Operation.DEVIDE; break;
                default:
                    operation = Operation.NO_OP;
                    break;
            }
            txtInput.Text = "0";
        }
        #endregion

        #region Operations
        private void Digit_Click(object sender, RoutedEventArgs e)
        {
            TypeDigit((string)((Button)sender).Content);
        }

        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            SaveOperation((string)((Button)sender).Content);
        }

        private void Compute_Click(object sender, RoutedEventArgs e)
        {
            result = Double.Parse(txtInput.Text);
            switch (operation)
            {
                case Operation.ADD: result = input + result; break;
                case Operation.SUBSTRACT: result = input - result; break;
                case Operation.MULTIPLY: result = input * result; break;
                case Operation.DEVIDE: result = input / result; break;
                case Operation.NO_OP: break;
                default: break;
            }
        } 
        #endregion
    }
}
