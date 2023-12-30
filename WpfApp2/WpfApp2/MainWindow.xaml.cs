using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                 System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            nan.Visibility = Visibility.Collapsed;

            label_x11.Visibility = Visibility.Collapsed;
            x11.Visibility = Visibility.Collapsed;

            label_x22.Visibility = Visibility.Collapsed;
            x22.Visibility = Visibility.Collapsed;

            label_xx.Visibility = Visibility.Collapsed;
            xx.Visibility = Visibility.Collapsed;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            nan.Visibility = Visibility.Visible;

            label_x11.Visibility = Visibility.Visible;
            x11.Visibility = Visibility.Visible;

            label_x22.Visibility = Visibility.Visible;
            x22.Visibility = Visibility.Visible;

            label_xx.Visibility = Visibility.Visible;
            xx.Visibility = Visibility.Visible;

            double a = 0, b = 0, c = 0;

            try { a = Convert.ToDouble(a1.Text); }
            catch
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButton.OK,MessageBoxImage.Error);
            }

            try { b = Convert.ToDouble(b1.Text); }
            catch
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            try { c = Convert.ToDouble(c1.Text); }
            catch
            {
                MessageBox.Show("Помилка введення значення c!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            double discriminant = b * b - 4 * a * c;
            D.Text = discriminant.ToString("F2");

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                x11.Text = x1.ToString("F2");
                x22.Text = x2.ToString("F2");

                nan.Visibility = Visibility.Collapsed;

                label_x11.Visibility = Visibility.Visible;
                x11.Visibility = Visibility.Visible;

                label_x22.Visibility = Visibility.Visible;
                x22.Visibility = Visibility.Visible;

                label_xx.Visibility = Visibility.Collapsed;
                xx.Visibility = Visibility.Collapsed;
            }

            if (discriminant == 0)
            {
                double x = -b / (2 * a);
                xx.Text = x.ToString("F2");
                nan.Visibility = Visibility.Collapsed;

                label_x11.Visibility = Visibility.Collapsed;
                x11.Visibility = Visibility.Collapsed;

                label_x22.Visibility = Visibility.Collapsed;
                x22.Visibility = Visibility.Collapsed;

                label_xx.Visibility = Visibility.Visible;
                xx.Visibility = Visibility.Visible;
            }

            if (discriminant < 0)
            {
                nan.Visibility = Visibility.Visible;

                label_x11.Visibility = Visibility.Collapsed;
                x11.Visibility = Visibility.Collapsed;

                label_x22.Visibility = Visibility.Collapsed;
                x22.Visibility = Visibility.Collapsed;

                label_xx.Visibility = Visibility.Collapsed;
                xx.Visibility = Visibility.Collapsed;
            }
        }
    }
}
