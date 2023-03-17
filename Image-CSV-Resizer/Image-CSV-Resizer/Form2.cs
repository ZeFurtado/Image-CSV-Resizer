using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Image_CSV_Resizer
{
    public partial class Form2 : Form
    {
        Fotos classeFotos = new Fotos();
        List<string> arquivoFotos = new List<string>();
        List<string> caminhoDaFoto = new List<string>();

        public Form2()
        {
            InitializeComponent();

            //Desabilita edição da altura e largura das fotos
            txtHeight.Enabled = false;
            txtWidth.Enabled = false;

            //Configuração das barras de rolagem da listagem das fotos
            lstPhotos.ScrollAlwaysVisible = true;
            lstPhotos.HorizontalScrollbar = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] photos = classeFotos.CarregaFotos();

            arquivoFotos.Clear();
            lstPhotos.Items.Clear();

            foreach (var fotos in photos) 
            {
                lstPhotos.Items.Add(fotos);
                arquivoFotos.Add(fotos.Remove(0,fotos.LastIndexOf("/")));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHeight.Text) && string.IsNullOrEmpty(txtWidth.Text))
            {
                MessageBox.Show("Não foi selecionada nenhuma opção de redimensionamento!!!", "Redimensionamento não definido", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (lstPhotos.Items.Count == 0)
            {
                MessageBox.Show("Não foi selecionada nenhuma foto!!!", "Nenhuma foto selecionada", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (string.IsNullOrEmpty(txtDestinyFolder.Text))
            {
                MessageBox.Show("O caminho de destino não foi especificado", "Nenhum caminho de destino", MessageBoxButtons.OK, MessageBoxIcon.Question);
            } else
            {
                int index = 0;
                foreach (var arquivos in arquivoFotos)
                {
                    Image fotoRedimensionada = classeFotos.RedimensionarFoto(arquivoFotos[index], int.Parse(txtWidth.Text), int.Parse(txtHeight.Text));
                    fotoRedimensionada.Save($"{txtDestinyFolder.Text}/fotoRedimensionada{index}.JPG", ImageFormat.Tiff);
                    index++;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Define as dimensões da foto para os Crachás
            int alturaFoto = 768;
            int larguraFoto = 663;

            txtWidth.Text = larguraFoto.ToString();
            txtHeight.Text = alturaFoto.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Define as dimensões da foto para as Carteirinhas
            int larguraFoto = 300;
            int alturaFoto = 400;

            txtWidth.Text = larguraFoto.ToString();
            txtHeight.Text = alturaFoto.ToString();
        }

        void LimparCampos()
        {
            lstPhotos.Items.Clear();
            arquivoFotos.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pastaDestino = new FolderBrowserDialog();
            if (pastaDestino.ShowDialog() == DialogResult.OK) 
            {
                txtDestinyFolder.Clear();
                txtDestinyFolder.Text = pastaDestino.SelectedPath;
            }
        }
    }
}
