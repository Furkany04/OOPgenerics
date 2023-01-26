
using System;
using System.Collections;
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
    public partial class Form3 : Form
    {
       
        Hashtable hh = new Hashtable();
       
        public List<string> dersler = new List<string>();
        public Form3(List<string> ders)
        {
            this.dersler = ders;
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            hh.Add(1, "Math : 2 kredi");
            hh.Add(2, "Turkish : 2 kredi");
            hh.Add(3, "English : 2 kredi");
            hh.Add(4, "Software : 4 kredi");
            hh.Add(5, "Electric : 2kredi");

            foreach (var item in hh.Keys)
            {
                listBox1.Items.Add(hh[item]);
            }

            

        }
        int kredi = 10;
        private void button1_Click(object sender, EventArgs e)
        {

            string a = "";
            if (listBox1.SelectedItem.ToString() == "Software : 4 kredi" && kredi >= 4)
            {

                a = listBox1.SelectedItem.ToString();

                kredi = kredi - 4;
                kredilbl.Text = kredi.ToString();
                dersler.Add(a);
                ListViewItem item = new ListViewItem(a);

                listView1.Items.Add(item);


            }
            else if ((listBox1.SelectedItem.ToString() == "Electric : 2kredi" || listBox1.SelectedItem.ToString() == "English : 2 kredi" || listBox1.SelectedItem.ToString() == "Turkish : 2 kredi" || listBox1.SelectedItem.ToString() == "Math : 2 kredi" && kredi >= 2))


            {

                a = listBox1.SelectedItem.ToString();


                kredi = kredi - 2;
                kredilbl.Text = kredi.ToString();
                dersler.Add(a); // burda dersleri tuttuk listele kısmında yaxırcağız..

                ListViewItem item = new ListViewItem(a);

                listView1.Items.Add(item);


            }




            if (kredi<=1)
            {
                MessageBox.Show("Krediniz bitmiştir");
                button1.Visible= false;
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
