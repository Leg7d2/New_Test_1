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

namespace WpfApp1
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
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            double y = 0, x = 0, z = 0, r, m, n;

            try { x = Convert.ToDouble(x1.Text); }
            catch
            {
                MessageBox.Show("Помилка введення значення x!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            try { y = Convert.ToDouble(y1.Text); }
            catch
            {
                MessageBox.Show("Помилка введення значення y!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            try { z = Convert.ToDouble(z1.Text); }
            catch
            {
                MessageBox.Show("Помилка введення значення z!", "Помилка", MessageBoxButton.OK,MessageBoxImage.Error);
            }

            m = Math.Pow(y + Math.Pow(x - 1, 1.0 / 3), 1.0 / 4);
            n = Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2) + Math.Tan(z));
            r = m / n;
            r1.Text = r.ToString("F2");

        }
    }
}
