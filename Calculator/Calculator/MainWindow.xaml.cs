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

        decimal num1 = 0;
        decimal num2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 1;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 1;
                txtDisplay.Text = num2.ToString();
            }

        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 2;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 2;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 3;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 3;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 4;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 4;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 5;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 5;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 6;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 6;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 7;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 7;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 8;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 8;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 9;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 9;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10);
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10);
                txtDisplay.Text = num2.ToString();
            }
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "0";
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "x";
            txtDisplay.Text = "0";
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "0";
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "/")
            {
                txtDisplay.Text = (num1 / num2).ToString();
            } 
            else if (operation == "x")
            {
                txtDisplay.Text = (num1 * num2).ToString();
            }
            else if (operation == "-")
            {
                txtDisplay.Text = (num1 - num2).ToString();
            } 
            else
            {
                txtDisplay.Text = (num1 + num2).ToString();
            }
        }

        private void BtnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = 0;
            } 
            else
            {
                num2 = 0;
            }

            txtDisplay.Text = "0";
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operation = "";
            txtDisplay.Text = "0";
        }
    }
}
