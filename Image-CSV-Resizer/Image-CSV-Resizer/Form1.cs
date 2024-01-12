using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using System.Text;


namespace Image_CSV_Resizer
{
    public partial class Form1 : Form
    {
        Fotos classeFotos = new Fotos();
        List<string> caminhoDaFoto = new List<string>(); //Recebe o caminho total do arquivo da foto
        List<DadosCsv> listaDadosCsv = new List<DadosCsv>();//Lista do tipo 'DadosCsv' que armazena todos os dados referente ao aluno da foto
        string caminhoDeDestino;

        public Form1()
        {
            InitializeComponent();
        }
        void ConfiguracaoListViewCSV() //Configuração da tabela dos dados CSV
        {
            lstItemsCsv.View = View.Details;
            lstItemsCsv.LabelEdit = true;
            lstItemsCsv.Scrollable = true;
            lstItemsCsv.Columns.Add("Turma", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
            lstItemsCsv.Columns.Add("Nome", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
            lstItemsCsv.Columns.Add("Matrícula", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
            lstItemsCsv.Columns.Add("Nº da Foto", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
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
                    caminhoDeDestino = txtDestinyFolder.Text;
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

                    ConfiguracaoListViewCSV();

                    txtCsvFile.Text = openFile.FileName;
                    string caminhoDoArquivo = openFile.FileName;

                    var loadCsv = new StreamReader(caminhoDoArquivo);
                    var cultureConfig = new CsvConfiguration(CultureInfo.InvariantCulture);

                    using (var dados = new CsvReader(loadCsv, cultureConfig))
                    {
                        var dadosCsv = dados.GetRecords<CsvFileData>();

                        foreach (var items in dadosCsv)
                        {
                            listaDadosCsv.Add(new DadosCsv(items.turma, items.nome, items.matricula, items.numeroDaFoto));

                            string[] linha = { items.turma, items.nome, items.matricula, items.numeroDaFoto };
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

                    foreach (var arquivoFoto in caminhoDaFoto)
                    {
                        string nomeDaFoto = ObterNomeDaFoto(arquivoFoto);

                        foreach (var dados in listaDadosCsv)
                        {
                            if (arquivoFoto.Contains(dados.GetNumeroDaFoto()))
                            {
                                string[] linha = { dados.GetTurma(), nomeDaFoto, dados.GetMatricula() };
                                ListViewItem listViewItem = new ListViewItem(linha);

                                classeFotos.SalvarFoto(classeFotos.RedimensionarFoto(arquivoFoto, 300, 400), caminhoDeDestino, dados.GetMatricula(), dados.GetTurma());
                                classeFotos.LogDeFotosRedimensionadas(DateTime.Now.ToString("MMM ddd d HH:mm yyyy"), @$"{caminhoDeDestino}\{dados.GetTurma()}", dados);
                            }
                        }
                    }

                    MessageBox.Show("Fotos redimensionadas com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        void LimparCampos() //Limpeza dos campos do formulário e das variaveis
        {
            txtCsvFile.Clear();
            txtDestinyFolder.Clear();
            caminhoDeDestino = null;

            lstItemsCsv.Items.Clear();
            lstPhotos.Items.Clear();


            listaDadosCsv.Clear();
            caminhoDaFoto.Clear();
        }


        //Criei essa função para tirar o caminho inteiro da foto e deixar somente o nome do Arquivo.
        string ObterNomeDaFoto(string caminhoFoto)
        {
            int DSCstringIndex = caminhoFoto.LastIndexOf("DSC");
            string foto = caminhoFoto.Remove(0, DSCstringIndex);
            foto = foto.Replace(".JPG", "");//Tira o JPG do nome da foto

            return foto;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            classeFotos.ExibirLogDeFotos(listaDadosCsv[0]);

        }
    }

    class CsvFileData
    {
        [Name("Turma", "turma")]
        public string turma { get; set; }

        [Name("Nome", "Nomes", "nome", "nomes")]
        public string nome { get; set; }

        [Name("Matrícula", "Matricula", "Matriculas", "matriculas", "matrículas")]
        public string matricula { get; set; }

        [Name("Foto", "Fotos", "foto", "fotos")]
        public string numeroDaFoto { get; set; }
    }

}