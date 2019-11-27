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
            EXP,
            SIN,
            COS,
            SQRT,
            LOG,
            RECIPROCALLI,
            NO_OP
        }

        double input = 0, result = 0;
        bool isReal = false;
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
            else if ((digit.Equals(".")) && (!isReal))
            {
                isReal = true;
                txtInput.Text += digit;
            }
            else if ((digit.Equals(".")) && (isReal))
            {
                txtInput.Text = txtInput.Text;
            }
            else
            {
                txtInput.Text += digit;
            }
        }

        private void SaveOperation(string opCode)
        {
            input = double.Parse(txtInput.Text, System.Globalization.CultureInfo.InvariantCulture);
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
            isReal = false;
        }

        private void SaveOperationOP(string opCode)
        {
            switch (opCode)
            {
                case "EXP": operation = Operation.EXP; break;
                case "SIN": operation = Operation.SIN; break;
                case "COS": operation = Operation.COS; break;
                case "SQRT": operation = Operation.SQRT; break;
                case "LOG": operation = Operation.LOG; break;
                case "1/x": operation = Operation.RECIPROCALLI; break;
                default: operation = Operation.NO_OP; break;
            }
        }

        private void Clean(string bttnCode)
        {
            input = Double.Parse(txtInput.Text);
            switch (bttnCode)
            {
                case "CE": input = 0; txtInput.Text = "0"; break;
                case "C": input = 0; result = 0; txtInput.Text = "0"; break;
                default: break;
            }
            isReal = false;
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
            result = double.Parse(txtInput.Text, System.Globalization.CultureInfo.InvariantCulture);
            switch (operation)
            {
                case Operation.ADD: result = input + result; break;
                case Operation.SUBSTRACT: result = input - result; break;
                case Operation.MULTIPLY: result = input * result; break;
                case Operation.DEVIDE: result = input / result; break;
                case Operation.NO_OP: break;
                default: break;
            }
            txtInput.Text = result.ToString();
            isReal = false;
        }

        private void ComputeOP_Click(object sender, RoutedEventArgs e)
        {
            result = double.Parse(txtInput.Text, System.Globalization.CultureInfo.InvariantCulture);
            SaveOperationOP((string)((Button)sender).Content);
                        
            switch (operation)
            {
                case Operation.EXP: result = Math.Exp(result); break;
                case Operation.SIN: result = Math.Sin(result); break;
                case Operation.COS: result = Math.Cos(result); break;
                case Operation.SQRT: result = Math.Sqrt(result); break;
                case Operation.LOG: result = Math.Log(result); break;
                case Operation.RECIPROCALLI: result = 1.0 / result; break;
                case Operation.NO_OP: break;
                default: break;
            }
            txtInput.Text = result.ToString();
            isReal = false;
        }

        private void MemOp_Click(object sender, RoutedEventArgs e)
        {
            Clean((string)((Button)sender).Content);
        }

        private void Power_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        #endregion
    }
}
