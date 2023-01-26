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
    
    public partial class biletForm : Form
    {
        public List<int> para = new List<int>();
        public biletForm(List<int> para)
        {
            this.para = para;
            InitializeComponent();
        }
        
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
           if(checkBox1.Checked ==true)
            {
                
                checkBox1.Visible= false;
                sayac++;
                
            }
            if (checkBox2.Checked == true)
            {
                checkBox2.Visible = false;
                sayac++;
            }
            if (checkBox3.Checked == true)
            {
                checkBox3.Visible = false;
                sayac++;
            }
            if (checkBox4.Checked == true)
            {
                checkBox4.Visible = false;
                sayac++;
            }
            if (checkBox5.Checked == true)
            {
                checkBox5.Visible = false;
                sayac++;
            }
            int toplam = 0;
            int sonuc = sayac * 2;
            for (int i = 0; i < para.Count; i++)
            {
                toplam += para[i];
            }
            
            if(toplam < sonuc )
            {
                MessageBox.Show("paranız yeterli değil");
                parayukleForm ffpara = new parayukleForm(para);
                this.Close();
                ffpara.Show();
            }
            else
            {
                MessageBox.Show("başarıyla satın alındı");
                toplam = toplam - sonuc;

            }
            

            paralbl.Text = toplam.ToString() + "tl niz bulunmaktadır!";
        }
    }
}
