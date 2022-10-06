using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         public int  sonuc,sayi1,sayi2;
         public int oprt;
         public bool oprtvarmı=false;
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text="0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sayi1=int.Parse(textBox1.Text);
            textBox1.Text="";
            oprt=1;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayi1=int.Parse(textBox1.Text);
            textBox1.Text="";
            oprt=2;
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayi1=int.Parse(textBox1.Text);
            textBox1.Text="";
            oprt=3;
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi1=int.Parse(textBox1.Text);
            textBox1.Text="";
            oprt=4;
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayi2=int.Parse(textBox1.Text);
            switch (oprt)
            {
                case 1:
                    {
                        sonuc=sayi1+sayi2;
                        textBox1.Text=sonuc.ToString();
                        break;
                    }
                case 2: 
                    {
                        sonuc=sayi1-sayi2;
                        textBox1.Text=sonuc.ToString();
                        break;
                    }
                case 3:
                    {
                        sonuc=sayi1*sayi2;
                        textBox1.Text=sonuc.ToString();
                        break;
                    }
                case 4:
                    {
                        sonuc=sayi1/sayi2;
                        textBox1.Text=sonuc.ToString();
                        break;
                    }

                default:
                    break;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text="0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            {
                textBox1.Clear();
            }
            Button buton = sender as Button;
            textBox1.Text+=buton.Text;
            

        }

        

        

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.Substring(0,textBox1.Text.Length-1);
            if (textBox1.Text=="")
            {
                textBox1.Text="0";
            }
        }
    }
}
