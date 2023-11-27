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
using System.Globalization;

namespace CalculadoraWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal val1 = 0, val2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += "1";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += "2";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += "3";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += "4";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += "5";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += "6";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += "7";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += "8";
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += "9";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text += "0";
        }

        private void Buttonequal_Click(object sender, RoutedEventArgs e)
        {
            val2 = decimal.Parse(ResultBox.Text, CultureInfo.InvariantCulture);

            switch (operation)
            {
                case "Add":
                    ResultBox.Text = Convert.ToString(val1 + val2);
                    break;
                case "Sub":
                    ResultBox.Text = Convert.ToString(val1 - val2);
                    break;
                case "Mult":
                    ResultBox.Text = Convert.ToString(val1 * val2);
                    break;
                case "Div":
                    if (val2 == 0)
                    {
                        MessageBox.Show("Divisão por Zero");
                        ResultBox.Text = "";
                        OperationType.Text = "";
                        val1 = 0;
                        val2 = 0;
                    }
                    else
                    {
                        ResultBox.Text = Convert.ToString(val1 / val2);
                    }
                    break;
                default:
                    MessageBox.Show("Operação invalida");
                    break;

            }
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text = "";
            OperationType.Text = "";
            val1 = 0;
            val2 = 0;
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text = "";
        }

        private void ButtonMult_Click(object sender, RoutedEventArgs e)
        {
            if (ResultBox.Text != "")
            {
                val1 = decimal.Parse(ResultBox.Text, CultureInfo.InvariantCulture);
                ResultBox.Text = "";
                operation = "Mult";
                OperationType.Text = "Operação: Multiplicação (*)";
            }
            else
            {
                MessageBox.Show("Coloque um valor Antes");
            }
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (ResultBox.Text != "")
            {
                val1 = decimal.Parse(ResultBox.Text, CultureInfo.InvariantCulture);
                ResultBox.Text = "";
                operation = "Min";
                OperationType.Text = "Operação: Subtração (-)";
            }
            else
            {
                MessageBox.Show("Coloque um valor Antes");
            }
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            if (ResultBox.Text != "")
            {
                val1 = decimal.Parse(ResultBox.Text, CultureInfo.InvariantCulture);
                ResultBox.Text = "";
                operation = "Div";
                OperationType.Text = "Operação: Divisão (/)";
            }
            else
            {
                MessageBox.Show("Coloque um valor Antes");
            }
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (ResultBox.Text.Length > 0)
            {
                val1 = decimal.Parse(ResultBox.Text, CultureInfo.InvariantCulture);
                ResultBox.Text = "";
                operation = "Add";
                OperationType.Text = "Operação: Adição (+)";
            } else
            {
                MessageBox.Show("Coloque um valor Antes");
            }
        }


       

    }
}
