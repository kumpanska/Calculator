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
        int first;
        int second;
        char operation;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Result.Text += btn.Content.ToString();
            second = Convert.ToInt32(Result.Text);
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            first = Convert.ToInt32(Result.Text);
            operation = '÷';
            Result.Clear();
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            first = Convert.ToInt32(Result.Text);
            operation = '×';
            Result.Clear();
        }

        private void SubstractButton_Click(object sender, RoutedEventArgs e)
        {
            first = Convert.ToInt32(Result.Text);
            operation = '-';
            Result.Clear();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            first = Convert.ToInt32(Result.Text);
            operation = '+';
            Result.Clear();
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            second = Convert.ToInt32(Result.Text);
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
                    res = first / second;
                    break;
            }
            Result.Text = res.ToString();

        }
    }
}
