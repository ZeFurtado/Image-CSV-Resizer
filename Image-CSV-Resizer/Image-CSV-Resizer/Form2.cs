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
        int larguraFoto;
        int alturaFoto;

        public Form2()
        {
            InitializeComponent();

            //Desabilita edição dos campos altura e largura das fotos no Windows Forms
            txtHeight.Enabled = false;
            txtWidth.Enabled = false;

            //Configuração das barras de rolagem da listagem das fotos
            lstPhotos.ScrollAlwaysVisible = true;
            lstPhotos.HorizontalScrollbar = true;
            lstFotosRedimensionadas.View = View.Details;
            lstFotosRedimensionadas.Columns.Add("Foto redimensionada", lstFotosRedimensionadas.Width, HorizontalAlignment.Left);

            //Cor do Fundo
            BackColor = Color.FromArgb(80, 80, 80);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nomeDoArquivoDaFoto.Clear();
            lstPhotos.Items.Clear();
            caminhoDaFoto.Clear();

            string[] photos = classeFotos.CarregaFotos();

            foreach (var fotos in photos) 
            {
                lstPhotos.Items.Add(fotos);
                caminhoDaFoto.Add(fotos);
                nomeDoArquivoDaFoto.Add(fotos.Remove(0,fotos.LastIndexOf(@"\") + 1));
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
            } else
            {
                int index = 0;
                foreach (var arquivos in nomeDoArquivoDaFoto)
                {
                    Image fotoRedimensionada = classeFotos.RedimensionarFoto(caminhoDaFoto[index], larguraFoto, alturaFoto);
                    classeFotos.SalvarFoto(fotoRedimensionada, txtDestinyFolder.Text, nomeDoArquivoDaFoto[index]);
                    lstFotosRedimensionadas.Items.Add(nomeDoArquivoDaFoto[index]);
                    index++;
                }

                MessageBox.Show("Redimensionamento concluído","Mensagem de Conclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            lstFotosRedimensionadas.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Seleciona a pasta destino onde vai ser salvo a foto redimensionada
            PastaDestino();
        }

        private void PastaDestino()
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
