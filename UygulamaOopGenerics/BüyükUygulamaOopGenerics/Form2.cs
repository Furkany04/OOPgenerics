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
    public partial class Form2 : Form
    {
        Form1 nf = new Form1();
        public List<string> dersler = new List<string>();
        public List<string> ogrenciler = new List<string>();
        public Form2(Form1 ff)
        {
            nf = ff;
            InitializeComponent();
        }
        

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            nf.Close();
        }
        

        private void öğrenciGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Form3 ff3 = new Form3(dersler);
            ff3.MdiParent = this;

            int goster = Application.OpenForms.Count;

            if (goster == 2)
            {
                ff3.Show();
            }
            else
            {
                ff3.BringToFront();
            }

        }

        private void dersleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form4 ff4 = new Form4(dersler);
            ff4.MdiParent = this;

            int goster = Application.OpenForms.Count;

            if (goster == 2)
            {
                ff4.Show();
                
            }
            else
            {
                ff4.BringToFront();
            }
        }
        public List<int> para = new List<int>();
        private void paraYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parayukleForm ffpara = new parayukleForm(para);
            ffpara.MdiParent = this;

            int goster = Application.OpenForms.Count;

            if (goster == 2)
            {
                ffpara.Show();

            }
            else
            {
                ffpara.BringToFront();
            }
        }

        private void biletAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            biletForm ffbilet = new biletForm(para);
            ffbilet.MdiParent = this;

            int goster = Application.OpenForms.Count;

            if (goster == 2)
            {
                ffbilet.Show();

            }
            else
            {
                ffbilet.BringToFront();
            }
        }
    }
}
