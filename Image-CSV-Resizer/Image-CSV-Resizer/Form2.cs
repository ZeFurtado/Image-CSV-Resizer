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
    public partial class Form2 : Form
    {
        Fotos classeFotos = new Fotos();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] photos = classeFotos.CarregaFotos();

            foreach (var fotos in photos) 
            {
                MessageBox.Show(fotos);
            }
        }
    }
}
