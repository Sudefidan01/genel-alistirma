﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Bir Değer Giriniz");
                textBox1.Focus();
            }
            else
            {
                try
                {
                    int sayi = int.Parse(textBox1.Text);
                    if (sayi % 2 == 0 )
                    {
                        MessageBox.Show("Girilen Sayı Çifttir");
                    }
                    else 
                    {
                        MessageBox.Show("Girilen Sayı Tektir");

                    }
                }
                catch 
                {
                    MessageBox.Show("Doğru Bir Değer Giriniz");
                    textBox1.Clear();
                    textBox1.Focus();
                   
                }
            }
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                try
                {
                    int sayi = int.Parse(textBox1.Text);
                    if (sayi % 2 == 0)
                    {
                        MessageBox.Show("Girilen Sayı Çifttir");
                    }
                    else
                    {
                        MessageBox.Show("Girilen Sayı Tektir");

                    }
                }
                catch
                {
                    MessageBox.Show("Doğru Bir Değer Giriniz");
                    textBox1.Clear();
                    textBox1.Focus();

                }
            }
        }
    }
}
