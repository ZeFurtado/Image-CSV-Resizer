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
    public partial class ExibeLogs : Form
    {
        public Fotos classeFotos = new Fotos();
        public ExibeLogs()
        {
            InitializeComponent();

            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.ReadOnly = true;

            textBox1.Text = classeFotos.ExibirLogDeFotos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
