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
    public partial class Form4 : Form
    {
        public List<string> dersler = new List<string>();
        public Form4(List<string> ders)
        {
            this.dersler = ders;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            
            
            foreach (var item in dersler)
            {
                listView1.Items.Add(item);
            }

            dersler.Clear();
            

        }
    }
}
