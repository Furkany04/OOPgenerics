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
    public partial class ogrencilstle : Form
    {
        public List<string> ogrenciler = new List<string>();
        public ogrencilstle(List<string> ogrenci)
        {
            this.ogrenciler= ogrenci;
            InitializeComponent();
        }

        private void ogrencilstle_Load(object sender, EventArgs e)
        {
            string ad = "";
            string sifre = "";
            int y = 0;
            for (int i = 0; i < ogrenciler.Count/2; i++)
            {
                ad = ogrenciler[i + y];
                sifre = ogrenciler[i + 1 + y];
                string[] dizi = {ad, sifre};
                y += 1;

                ListViewItem item = new ListViewItem(dizi);
                listView1.Items.Add(item);
            }
            
        }
    }
}
