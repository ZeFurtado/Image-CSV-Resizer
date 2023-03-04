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
        List<string> arquivoFotos = new List<string>();

        public Form2()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] photos = classeFotos.CarregaFotos();

            arquivoFotos.Clear();

            foreach (var fotos in photos) 
            {
                lstPhotos.Items.Add(fotos);
                arquivoFotos.Add(fotos);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            void LimparCampos()
            {
                lstPhotos.Items.Clear();
                arquivoFotos.Clear();
            }
        }
    }
}
