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
        List<string> nomeDoArquivoDaFoto = new List<string>();
        List<string> caminhoDaFoto = new List<string>();
        string pastaDestino;
        int larguraFoto;
        int alturaFoto;

        public Form2()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstPhotos.Items.Clear();
            nomeDoArquivoDaFoto.Clear();
            caminhoDaFoto.Clear();

            string[] photos = classeFotos.CarregaFotos();

            foreach (var fotos in photos)
            {
                lstPhotos.Items.Add(fotos);
                caminhoDaFoto.Add(fotos);
                nomeDoArquivoDaFoto.Add(fotos.Remove(0, fotos.LastIndexOf(@"\") + 1));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHeight.Text) && string.IsNullOrEmpty(txtWidth.Text))//Verifica se foi selecionada opção de redimensionamento
            {
                MessageBox.Show("Não foi selecionada nenhuma opção de redimensionamento!!!", "Redimensionamento não definido", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (lstPhotos.Items.Count == 0)//Verifica se foi selecionada alguma foto
            {
                MessageBox.Show("Não foi selecionada nenhuma foto!!!", "Nenhuma foto selecionada", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (string.IsNullOrEmpty(txtDestinyFolder.Text))// Verifica se foi selecionada a pasta de destino
            {
                MessageBox.Show("O caminho de destino não foi especificado", "Nenhum caminho de destino", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                int index = 0;
                int numeroDeFotosTotal = 0;
                int numeroDeFotosRedimensionadas = 0;

                foreach (var arquivos in nomeDoArquivoDaFoto)
                {
                    Image fotoRedimensionada = classeFotos.RedimensionarFoto(caminhoDaFoto[index], larguraFoto, alturaFoto);
                    numeroDeFotosTotal++;
                    if (nomeDoArquivoDaFoto[index].Contains(".JPG")) 
                    {
                        classeFotos.SalvarFoto(fotoRedimensionada, pastaDestino, nomeDoArquivoDaFoto[index].Replace(".JPG", ""));
                        numeroDeFotosRedimensionadas++;
                    }else if (nomeDoArquivoDaFoto[index].Contains(".PNG")) 
                    {
                        classeFotos.SalvarFoto(fotoRedimensionada, pastaDestino, nomeDoArquivoDaFoto[index].Replace(".PNG", ""));
                        numeroDeFotosRedimensionadas++;
                    }

                    classeFotos.LogDeFotosRedimensionadas(DateTime.Now.ToString("MMM ddd d HH:mm yyyy"), pastaDestino, nomeDoArquivoDaFoto[index]);
                    index++;
                }

                if (numeroDeFotosRedimensionadas == 0)
                {
                    MessageBox.Show("Nenhuma foto foi redimensionada", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (numeroDeFotosRedimensionadas < numeroDeFotosTotal)
                {
                    MessageBox.Show("Algumas fotos não foram redimensionadas", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (numeroDeFotosRedimensionadas == numeroDeFotosTotal)
                {
                    MessageBox.Show("Todas as fotos foram redimensionadas", "", MessageBoxButtons.OK);
                }
       
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Define as dimensões da foto para os Crachás
            alturaFoto = 768;
            larguraFoto = 663;

            txtWidth.Text = larguraFoto.ToString();
            txtHeight.Text = alturaFoto.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Define as dimensões da foto para as Carteirinhas
            larguraFoto = 300;
            alturaFoto = 400;

            txtWidth.Text = larguraFoto.ToString();
            txtHeight.Text = alturaFoto.ToString();
        }

        void LimparCampos()
        {
            //Limpa os campos e as listas onde foi armazenado o caminho das fotos
            nomeDoArquivoDaFoto.Clear();
            lstPhotos.Items.Clear();
            caminhoDaFoto.Clear();
            txtDestinyFolder.Clear();
            pastaDestino = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Seleciona a pasta destino onde vai ser salvo a foto redimensionada
            PastaDestino();
        }

        private void PastaDestino()
        {
            var destinyFolder = new FolderBrowserDialog();
            if (destinyFolder.ShowDialog() == DialogResult.OK)
            {
                txtDestinyFolder.Clear();
                txtDestinyFolder.Text = destinyFolder.SelectedPath;
                pastaDestino = destinyFolder.SelectedPath;
            }
        }
    }
}
