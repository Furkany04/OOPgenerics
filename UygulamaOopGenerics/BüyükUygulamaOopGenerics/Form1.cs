using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BüyükUygulamaOopGenerics
{
    public partial class Form1 : Form
    {
        string[,] kullanıcılar = new string[2, 2];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kullanıcılar[0, 0] = "123";
            kullanıcılar[0, 1] = "admin";
            kullanıcılar[1, 0] = "1327";
            kullanıcılar[1, 1] = "furkan";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool dogrumu = false;
            int uzunluk = kullanıcılar.GetLength(0);
            for (int i = 0; i < uzunluk; i++)
            {
                if (kullanıcılar[i, 0] == textBox1.Text && (kullanıcılar[i, 1] == textBox2.Text))
                {
                    dogrumu = true;
                    this.Hide();
                    Form2 ff = new Form2(this);
                    ff.WindowState = FormWindowState.Maximized;
                    ff.Show();
                    break;
                }
            }
            if (!dogrumu)
            {
                MessageBox.Show("Yanlış kullanıcı girdiniz! Lütfen tekrar deneyiniz..");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Select();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible= true;
            groupBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            bool dogrumu = false;
            int uzunluk = kullanıcılar.GetLength(0);
            for (int i = 0; i < uzunluk; i++)
            {
                if (kullanıcılar[i, 0] == textBox4.Text && (kullanıcılar[i, 1] == textBox3.Text))
                {
                    dogrumu = true;
                    this.Hide();
                    Ogretmen ff = new Ogretmen(this);
                    ff.WindowState = FormWindowState.Maximized;
                    ff.Show();
                    break;
                }
            }
            if (!dogrumu)
            {
                MessageBox.Show("Yanlış kullanıcı girdiniz! Lütfen tekrar deneyiniz..");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Select();
            }

        }
    }
}
