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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi1=double.Parse(textBox1.Text);
                double sayi2=double.Parse(textBox2.Text);
                double sonuc = (sayi2 + sayi1) / 2;
                label3.Text = "Ortalama : " + sonuc.ToString();
            }
            catch 
            {
                MessageBox.Show("Doğru Bir Değer Giriniz");
                
            }
        }
    }
}
