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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int rastgeleSayi, skor;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int tahmin = int.Parse(textBox1.Text);
                if (tahmin<rastgeleSayi)
                {
                    MessageBox.Show("Daha büyük bir sayı tahmin ediniz");
                    skor -= 10;
                }
                else if(tahmin >rastgeleSayi)
                {
                    MessageBox.Show("Daha küçük bir sayı giriniz");
                    skor -= 10;
                }
                else
                {
                    MessageBox.Show("Tebrikler Doğru Bildiniz");
                    button1.Enabled= true;
                    button2.Enabled = false;
                }

                if (skor==0)
                {
                    MessageBox.Show("Hakkınız Bitti");
                    button1.Enabled = true;
                    button2.Enabled = false;

                }
                lblSkor.Text = "Skor : " + skor;
                textBox1.Clear();
            }
            catch 
            {

                MessageBox.Show("Eksik veya Hatalı Bir Değer Girdiniz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            skor = 100;
            lblSkor.Text = "Skor : " + skor;
            Random rastgele= new Random();
            rastgeleSayi=rastgele.Next(0,101);
            MessageBox.Show("Rastgele Bir Sayı Oluşturuldu");
            button2.Enabled= true;
            button1.Enabled = false;
        }
    }
}
