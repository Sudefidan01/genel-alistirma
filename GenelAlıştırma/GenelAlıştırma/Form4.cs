using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenelAlıştırma
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi1, sayi2;
                sayi1 = double.Parse(textBox1.Text);
                sayi2= double.Parse(textBox2.Text);
                if (radioButton1.Checked)
                {
                    double alan = sayi1 * sayi2;
                    MessageBox.Show("Alan = "+alan);
                }
                else  if (radioButton2.Checked)
                {
                    double cevre = 2 * (sayi1+sayi2);
                    MessageBox.Show("Çevre = "+cevre);
                }
                else
                {

                    MessageBox.Show("Yapmak İstediğiniz İşlemi Seçiniz");
                }
            }
            catch 
            {

                MessageBox.Show("Eksik veya Hatalı Değer Girdiniz");
            }
        }
    }
}
