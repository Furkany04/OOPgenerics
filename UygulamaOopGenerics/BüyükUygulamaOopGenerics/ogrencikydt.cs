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
    public partial class ogrencikydt : Form
    {
        public List<string> ogrenciler = new List<string>();
        public ogrencikydt(List<string> ogrenci)
        {
            this.ogrenciler = ogrenci;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciler.Add(textBox1.Text);
            ogrenciler.Add(textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
