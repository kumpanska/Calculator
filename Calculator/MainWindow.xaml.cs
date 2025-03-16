using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public MainWindow()
        {
            InitializeComponent();
        }
        double first;
        double second;
        char operation;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Result.Text += btn.Content.ToString();
            second = Convert.ToDouble(Result.Text);
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            first = Convert.ToDouble(Result.Text);
            operation = '÷';
            Result.Clear();
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            first = Convert.ToDouble(Result.Text);
            operation = '×';
            Result.Clear();
        }

        private void SubstractButton_Click(object sender, RoutedEventArgs e)
        {
            first = Convert.ToDouble(Result.Text);
            operation = '-';
            Result.Clear();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            first = Convert.ToDouble(Result.Text);
            operation = '+';
            Result.Clear();
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            second = Convert.ToDouble(Result.Text);
            double res = 0;
            switch (operation)
            {
                case '+':
                    res = first + second;
                    break;
                case '-':
                    res = first - second;
                    break;
                case '×':
                    res = first * second;
                    break;
                case '÷':
                    if (second != 0)
                    {
                        res = first / second;
                    }
                    else
                    {
                        Result.Text = "Error";
                        return;
                    }
                    break;
            }
            Result.Text = res.ToString();

        }

        private void ClearElementButton_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.Length > 0)
            {
                Result.Text = Result.Text.Remove(Result.Text.Length-1);
            }
        }
    }
}
