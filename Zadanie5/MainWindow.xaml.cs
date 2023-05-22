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

namespace Zadanie5
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                double a1 = Convert.ToDouble(A1.Text);
                double b1 = Convert.ToDouble(B1.Text);
                double c1 = Convert.ToDouble(C1.Text);
                double a2 = Convert.ToDouble(A2.Text);
                double b2 = Convert.ToDouble(B2.Text);
                double c2 = Convert.ToDouble(C2.Text);
                double d = a1 * b2 - a2 * b1;
                double y = (a1 * c2 - a2 * c1) / d;
                double x = (c1 * b2 - c2 * b1) / d;
                OTV.Text = $"Ответ:\n x = {x}" + $"\n y = {y}";
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
