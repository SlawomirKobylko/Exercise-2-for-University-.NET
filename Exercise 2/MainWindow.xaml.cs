using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Exercise_2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double num1 = 0;
        double num2 = 0;
        string operation = "";
            public MainWindow()
        {
            InitializeComponent();
        }
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10);
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10);
                Display.Text=num2.ToString();
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 1;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 1;
                Display.Text = num2.ToString();
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 2;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 2;
                Display.Text = num2.ToString();
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 3;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 3;
                Display.Text = num2.ToString();
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 8;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 8;
                Display.Text = num2.ToString();
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 5;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 5;
                Display.Text = num2.ToString();
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 6;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 6;
                Display.Text = num2.ToString();
            }
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 7;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 7;
                Display.Text = num2.ToString();
            }
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 8;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 8;
                Display.Text = num2.ToString();
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 9;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 9;
                Display.Text = num2.ToString();
            }
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            Display2.Text = "0";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            Display.Text = "0";
        }

        private void ButtonTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            Display.Text = "0";
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            Display.Text = "0";
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    num1 += num2;
                    Display2.Text = num1.ToString();
                    num2 = 0;
                    break;
                case "-":
                    num1 -= num2;
                    Display2.Text = num1.ToString();
                    num2 = 0;
                    break ;
                case "*":
                    num1 *= num2;
                    Display2.Text = num1.ToString();
                    num2 = 0;
                    break;
                case "/":
                    num1 /= num2;
                    Display2.Text= num1.ToString();
                    num2 = 0;
                    break;
                case "mod":
                    num1 %= num2;
                    Display2.Text = num1.ToString();
                    num2 = 0;
                    break;
                case "%":
                    num1 /= 100;
                    Display2.Text=num1.ToString();
                    num2= 0;
                    break;
            }
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operation = "";
            Display.Text = "0";
        }
        private void ButtonPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 *= -1;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 *= -1;
                Display.Text = num2.ToString();
            }
        }

        private void ButtonFactorial_Click(object sender, RoutedEventArgs e)
        {
            double Factorial = 1; 
            for (int i = 1; i <= num1; i++)
            {
                Factorial *= i;
            }
            Display2.Text = Factorial.ToString();
        }
        private void ButtonModulo_Click(object sender, RoutedEventArgs e)
        {
            operation = "mod";
            Display.Text = "0";
        }

        private void ButtonComma_Click(object sender, RoutedEventArgs e)
        {
            operation = ",";
            if (operation == ",")
            {
                num1 = (num1 * 0.1);
                Display.Text = num1.ToString();
            }
        }
        private void ButtonCeiling_Click(object sender, RoutedEventArgs e)
        {
            Display2.Text = Math.Ceiling(num1).ToString(); 
        }

        private void ButtonFloor_Click(object sender, RoutedEventArgs e)
        {
            Display2.Text = Math.Floor(num1).ToString();
        }
        private void Buttonx2_Click(object sender, RoutedEventArgs e)
        {
            Display2.Text = (num1*num1).ToString();
            num1 *= num1;
        }
        private void ButtonElement_Click(object sender, RoutedEventArgs e)
        {
            Display2.Text = Math.Sqrt(num1).ToString();
            num1=Math.Sqrt(num1);
        }
        private void Button1x_Click(object sender, RoutedEventArgs e)
        {
            Display2.Text=(1/num1).ToString();
            num1 = 1 / num1;
        }
        private void ButtonLn_Click(object sender, RoutedEventArgs e)
        {
            Display2.Text=Math.Log(num1).ToString();
        }

        private void ButtonLog_Click(object sender, RoutedEventArgs e)
        {
            Display2.Text = Math.Log10(num1).ToString();
        }
        private void ButtonPercent_Click(object sender, RoutedEventArgs e)
        {
            double percentComplete = Math.Round((double)(num1 / 100) *num2);
            Display2.Text=percentComplete.ToString();
        }
    }
}
