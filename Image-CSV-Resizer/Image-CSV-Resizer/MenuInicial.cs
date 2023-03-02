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
        Form form = new Form1();
        public MenuInicial()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.ShowDialog();
        }
    }
}
