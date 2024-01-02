using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using System.Drawing.Imaging;
using System.Drawing;
using System.Text;


namespace Image_CSV_Resizer
{
    public partial class Form1 : Form
    {
        Fotos classeFotos = new Fotos();
        List<string> caminhoDaFoto = new List<string>(); //Recebe o caminho total do arquivo da foto
        List<string> numMatriculaCSV = new List<string>(); //Armazena número de matrícula do aluno.
        List<string> numFotoCSV = new List<string>(); //Armazena o número da foto
        List<string> numTurmaCSV = new List<string>();//Armazena o número da foto


        public Form1()
        {
            InitializeComponent();
            ConfiguracaoListViewCSV();
            ConfiguracaoListViewResizedPhotos();


            BackColor = Color.FromArgb(80, 80, 80);
        }
        void ConfiguracaoListViewCSV()
        {
            lstItemsCsv.View = View.Details;
            lstItemsCsv.LabelEdit = true;
            lstItemsCsv.Scrollable = true;
            lstItemsCsv.Columns.Add("Turma", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
            lstItemsCsv.Columns.Add("Nome", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
            lstItemsCsv.Columns.Add("Matrícula", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
            lstItemsCsv.Columns.Add("Nº da Foto", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
        }
        void ConfiguracaoListViewResizedPhotos()
        {
            lstResizedPhotos.View = View.Details;
            lstResizedPhotos.LabelEdit = true;
            lstResizedPhotos.Scrollable = true;
            lstResizedPhotos.Columns.Add("Nome da Turma", lstResizedPhotos.Size.Width / 3, HorizontalAlignment.Left);
            lstResizedPhotos.Columns.Add("Númera da Foto", lstResizedPhotos.Width / 3, HorizontalAlignment.Left);
            lstResizedPhotos.Columns.Add("Matrícula do aluno", lstResizedPhotos.Width / 3, HorizontalAlignment.Left);
        }


        private void btnPhotos_Click(object sender, EventArgs e)
        {
            lstPhotos.Items.Clear();
            string[] photos = classeFotos.CarregaFotos();

            foreach (var fotos in photos)
            {
                lstPhotos.Items.Add(fotos);
                caminhoDaFoto.Add(fotos);
            }
        }

        private void btnDestinyFolder_Click(object sender, EventArgs e)
        {
            PastaDestino();
        }
        void PastaDestino()
        {
            try
            {
                var openDir = new FolderBrowserDialog();
                openDir.InitialDirectory = @$"C:\Users\{classeFotos.ObterNomeDoUser()}\pictures";

                if (openDir.ShowDialog() == DialogResult.OK)
                {
                    txtDestinyFolder.Clear();
                    txtDestinyFolder.Text = openDir.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnCSVRead_Click(object sender, EventArgs e)
        {
            DadosCsv();
        }
        void DadosCsv()
        {
            try
            {
                var openFile = new OpenFileDialog();

                openFile.Filter = "Arquivo separado por vírgula .csv | * .csv";
                openFile.Title = "Selecione o arquivo CSV";
                openFile.InitialDirectory = @$"C:\Users\{classeFotos.ObterNomeDoUser()}\documents";


                txtCsvFile.Enabled = false;

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    lstItemsCsv.Items.Clear();
                    numFotoCSV.Clear();
                    numMatriculaCSV.Clear();
                    numTurmaCSV.Clear();


                    txtCsvFile.Text = openFile.FileName;
                    String caminhoDoArquivo = openFile.FileName;

                    var loadCsv = new StreamReader(caminhoDoArquivo);
                    var cultureConfig = new CsvConfiguration(CultureInfo.InvariantCulture);

                    using (var dados = new CsvReader(loadCsv, cultureConfig))
                    {
                        var dadosCsv = dados.GetRecords<DadosCsv>();

                        foreach (var items in dadosCsv)
                        {
                            numFotoCSV.Add(items.foto);
                            numMatriculaCSV.Add(items.matricula);
                            numTurmaCSV.Add(items.turma);

                            string[] linha = {items.turma, items.nome, items.matricula, items.foto};
                            var listViewLine = new ListViewItem(linha);
                            lstItemsCsv.Items.Add(listViewLine);
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                StringBuilder erro = new StringBuilder();
                erro.Append("Não foi possível realizar a leitura do Arquivo CSV\n" +
                            "Certifique-se de o conteúdo do documento possuí cabeçalhos escritos corretamente\n" +
                            "[Nome, Turma, Matrícula, Foto]");
                MessageBox.Show(erro.ToString());
                MessageBox.Show(ex.Message);

                
                
            }

        }



        private void btnResize_Click(object sender, EventArgs e)
        {
            Redimensionar();
        }
        void Redimensionar()
        {
            if (lstPhotos.Items.Count <= 0)
            {
                MessageBox.Show("Não foi selecionada nenhuma foto!!!", "Sem foto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(txtDestinyFolder.Text))
            {
                MessageBox.Show("Não foi selecionada nenhuma pasta destino!!!", "Sem pasta destino", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(txtCsvFile.Text) || lstItemsCsv.Items.Count == 0)
            {
                MessageBox.Show("Não foi selecionado arquivo CSV!!!", "Não encontrado arquivo CSV", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                try
                {
                    int index = 0;
                    foreach (var fotoCSV in numFotoCSV)
                    {
                        foreach (var arquivoFoto in caminhoDaFoto)
                        {
                            string arquivoFotoFiltrada = FiltrarCaminhoFoto(arquivoFoto);

                            if (arquivoFoto.Contains(fotoCSV))
                            {
                                string[] linha = { numTurmaCSV[index], arquivoFotoFiltrada, numMatriculaCSV[index] };
                                var lstViewLine = new ListViewItem(linha);
                                lstResizedPhotos.Items.Add(lstViewLine);

                                CriarNovaImagem(numTurmaCSV[index], arquivoFoto, numMatriculaCSV[index], classeFotos.PropriedadesExif(arquivoFoto));
                            }


                        }
                        index++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        void CriarNovaImagem(string turma, string caminhoImagem, string matricula, UInt16 orientacao)
        {

            try
            {
                Image imagemOriginal = Image.FromFile(caminhoImagem);
                Image novaImagemRedimensionada = new Bitmap(imagemOriginal, new Size(400, 300));

                if (orientacao == 6)
                {
                    novaImagemRedimensionada.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                else
                {
                    novaImagemRedimensionada.RotateFlip(RotateFlipType.Rotate90FlipXY);
                }

                SalvarArquivo(novaImagemRedimensionada, turma, matricula, txtDestinyFolder.Text);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        void LimparCampos()
        {
            txtCsvFile.Clear();
            txtDestinyFolder.Clear();

            lstItemsCsv.Items.Clear();
            lstPhotos.Items.Clear();


            numMatriculaCSV.Clear();
            numFotoCSV.Clear();
            numTurmaCSV.Clear();
            caminhoDaFoto.Clear();
        }



        string FiltrarCaminhoFoto(string caminhoFoto)
        {
            int DSCstringIndex = caminhoFoto.LastIndexOf("DSC");
            string foto = caminhoFoto.Remove(0, DSCstringIndex);
            foto = foto.Replace(".JPG", "");

            return foto;
        }

        void SalvarArquivo(Image imagemRedimensionada, string nomeDaTurma, string matricula, string pastaDestino)//Cria a pasta da turma do aluno e salva o arquivo.
        {
            try
            {
                string pastaDaTurma = @$"{pastaDestino}\{nomeDaTurma}";

                if (pastaDestino.Contains(nomeDaTurma))
                {
                    imagemRedimensionada.Save(@$"{pastaDestino}\{matricula}.JPG", ImageFormat.Jpeg);
                }
                else if (!Directory.Exists(pastaDaTurma))//Verifica se o diretório NÃO existe e cria ele.
                {
                    Directory.CreateDirectory(pastaDaTurma);
                    imagemRedimensionada.Save(@$"{pastaDaTurma}\{matricula}.JPG", ImageFormat.Jpeg);
                }
                else if (Directory.Exists(pastaDaTurma))//Verifica se o diretório existe e salva a foto nele. 
                {
                    imagemRedimensionada.Save(@$"{pastaDaTurma}\{matricula}.JPG", ImageFormat.Jpeg);
                }
                else
                {
                    MessageBox.Show("Não foi possível salvar o arquivo", "Arquivo Foto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}