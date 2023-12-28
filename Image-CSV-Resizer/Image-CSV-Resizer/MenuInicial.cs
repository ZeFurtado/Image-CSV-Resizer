using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_CSV_Resizer
{
    public partial class MenuInicial : Form
    {
        Form form1 = new Form1();
        Form form2 = new Form2();
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }
    }
}
