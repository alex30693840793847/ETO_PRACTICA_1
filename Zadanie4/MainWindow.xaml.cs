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
using static System.Math;

namespace Zadanie4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(A.Text);
                double x = Convert.ToDouble(X.Text);
                double p = (1 / Cos(x)) + Log(Abs(Tan(x / 2))) + (x / (1 + (x / 1 + x)));
                double alf = Pow(p, 5) * Sqrt(a * Pow(x, 3) + 2) / 2 * Cos(x);
                OTV.Text = $"Ответ:\n{alf:N2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}