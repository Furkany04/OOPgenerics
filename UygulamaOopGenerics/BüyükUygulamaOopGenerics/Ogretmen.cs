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
    public partial class Ogretmen : Form
    {
        Form1 nf = new Form1();
        public List<string> ogrenciler = new List<string>();
        public Ogretmen(Form1 nf)
        {
            InitializeComponent();
            this.nf = nf;
        }

        private void Ogretmen_FormClosing(object sender, FormClosingEventArgs e)
        {
            nf.Close();
        }

        private void öğrenciKaydetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ogrencikydt oo = new ogrencikydt(ogrenciler);
            oo.MdiParent = this;

            int goster = Application.OpenForms.Count;

            if (goster == 2)
            {
                oo.Show();
            }
            else
            {
                oo.BringToFront();
            }
        }

        private void öğrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrencilstle oo1 = new ogrencilstle(ogrenciler);
            oo1.MdiParent = this;

            int goster = Application.OpenForms.Count;

            if (goster == 2)
            {
                oo1.Show();

            }
            else
            {
                oo1.BringToFront();
            }

        }
    }
}
