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
    public partial class parayukleForm : Form
    {
        public List<int> para = new List<int>();
        public parayukleForm(List<int> para)
        {
            this.para = para;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            para.Add(int.Parse(textBox1.Text));
            MessageBox.Show("Para başarıyla yüklendi");
        }
    }
}
