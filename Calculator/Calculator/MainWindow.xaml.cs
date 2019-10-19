using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region DataMembers

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
                default Operation.NO_OP: 
                    break;
            }
        } 
        #endregion
    }
}
