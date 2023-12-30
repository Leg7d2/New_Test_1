using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y = 0, x = 0, z = 0, r, m, n;

            try { x = Convert.ToDouble(x1.Text); }
            catch 
            {
                MessageBox.Show("Помилка введення значення x!", "Помилка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            try { y = Convert.ToDouble(y1.Text); }
            catch
            {
                MessageBox.Show("Помилка введення значення y!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try { z = Convert.ToDouble(z1.Text); }
            catch
            {
                MessageBox.Show("Помилка введення значення z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            m = Math.Pow(y + Math.Pow(x - 1, 1.0 / 3), 1.0 / 4);
            n = Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2) + Math.Tan(z));
            r = m / n;
            r1.Text = r.ToString("F2");
        }
    }
}
