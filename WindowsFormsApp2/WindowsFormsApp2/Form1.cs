using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;


            nan.Visible = false;
            label_x11.Visible = false;
            x11.Visible = false;
            label_x22.Visible = false;
            x22.Visible = false;
            label_xx.Visible = false;
            xx.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            double a = 0, b = 0, c = 0;

            try { a = Convert.ToDouble(a1.Text); }
            catch
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try { b = Convert.ToDouble(b1.Text); }
            catch
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try { c = Convert.ToDouble(c1.Text); }
            catch
            {
                MessageBox.Show("Помилка введення значення c!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            double discriminant = b * b - 4 * a * c;
            D.Text = discriminant.ToString("F2");

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                x11.Text = x1.ToString("F2");
                x22.Text = x2.ToString("F2");

                nan.Visible = false;
                label_x11.Visible = true;
                x11.Visible = true;
                label_x22.Visible = true;
                x22.Visible = true;
                label_xx.Visible = false;
                xx.Visible = false;
            }

            if (discriminant == 0)
            {
                double x = -b / (2 * a);
                xx.Text = x.ToString("F2");
                label_xx.Visible = true;
                xx.Visible = true;
                nan.Visible = false;
                label_x11.Visible = false;
                x11.Visible = false;
                label_x22.Visible = false;
                x22.Visible = false;
            }

            if (discriminant < 0)
            {
                nan.Visible = true;
                label_x11.Visible = false;
                x11.Visible = false;
                label_x22.Visible = false;
                x22.Visible = false;
                label_xx.Visible = false;
                xx.Visible = false;
            }
        }

        
    }
}
