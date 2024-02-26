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

            StartPosition = FormStartPosition.CenterScreen;
        }
        void ConfiguracaoListViewCSV() //Configura��o da tabela dos dados CSV
        {
            lstItemsCsv.View = View.Details;
            lstItemsCsv.LabelEdit = true;
            lstItemsCsv.Scrollable = true;
            lstItemsCsv.Columns.Add("Turma", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
            lstItemsCsv.Columns.Add("Nome", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
            lstItemsCsv.Columns.Add("Matr�cula", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
            lstItemsCsv.Columns.Add("N� da Foto", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
        }

        private void btnPhotos_Click(object sender, EventArgs e)
        {
            lstPhotos.Items.Clear();
            caminhoDaFoto.Clear();
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
                classeFotos.LogDeErros(DateTime.Now.ToString("MMM ddd d HH:mm yyyy"), ex.Message, ex.Source, "PastaDestino() em Form1.cs");
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

                openFile.Filter = "Arquivo separado por v�rgula .csv | * .csv";
                openFile.Title = "Selecione o arquivo CSV";
                openFile.InitialDirectory = @$"C:\Users\{classeFotos.ObterNomeDoUser()}\documents";

                txtCsvFile.Enabled = false;

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    lstItemsCsv.Items.Clear();
                    listaDadosCsv.Clear();

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
                erro.Append("N�o foi poss�vel realizar a leitura do Arquivo CSV\n" +
                            "Certifique-se de o conte�do do documento possu� cabe�alhos escritos corretamente\n" +
                            "[Nome, Turma, Matr�cula, Foto]");
                MessageBox.Show(erro.ToString());
                MessageBox.Show(ex.Message);
                classeFotos.LogDeErros(DateTime.Now.ToString("MMM ddd d HH:mm yyyy"), ex.Message, ex.Source, "DadosCsv() em Form1.cs");
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
                MessageBox.Show("N�o foi selecionada nenhuma foto!!!", "Sem foto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(txtDestinyFolder.Text))
            {
                MessageBox.Show("N�o foi selecionada nenhuma pasta destino!!!", "Sem pasta destino", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(txtCsvFile.Text) || lstItemsCsv.Items.Count == 0)
            {
                MessageBox.Show("N�o foi selecionado arquivo CSV!!!", "N�o encontrado arquivo CSV", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int numeroDeFotosTotal = 0;
                int numeroDeFotosRedimensionadas = 0;
                try
                {
                    foreach (var arquivoFoto in caminhoDaFoto)
                    {
                        string nomeDaFoto = ObterNomeDaFoto(arquivoFoto);
                        numeroDeFotosTotal++;
                        foreach (var dados in listaDadosCsv)
                        {
                            if (nomeDaFoto == dados.GetNumeroDaFoto())
                            {
                                string[] linha = { dados.GetTurma(), nomeDaFoto, dados.GetMatricula() };
                                ListViewItem listViewItem = new ListViewItem(linha);

                                classeFotos.SalvarFoto(classeFotos.RedimensionarFoto(arquivoFoto, 300, 400), caminhoDeDestino, dados.GetMatricula(), dados.GetTurma());
                                classeFotos.LogDeFotosRedimensionadas(DateTime.Now.ToString("MMM ddd d HH:mm yyyy"), @$"{caminhoDeDestino}\{dados.GetTurma()}", dados);
                                numeroDeFotosRedimensionadas++;
                            }
                        }
                    }


                    if (numeroDeFotosRedimensionadas == 0)
                    {                   
                        MessageBox.Show("Nenhuma foto foi redimensionada", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } 
                    else if (numeroDeFotosRedimensionadas < numeroDeFotosTotal)
                    {
                        MessageBox.Show("Algumas fotos n�o foram redimensionadas", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(numeroDeFotosRedimensionadas == numeroDeFotosTotal)
                    {
                        MessageBox.Show("Todas as fotos foram redimensionadas", "", MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    classeFotos.LogDeErros(DateTime.Now.ToString("MMM ddd d HH:mm yyyy"), ex.Message, ex.Source, "Redimensionar() em Form1.cs");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        void LimparCampos() //Limpeza dos campos do formul�rio e das variaveis
        {
            txtCsvFile.Clear();
            txtDestinyFolder.Clear();
            caminhoDeDestino = null;
            listaDadosCsv.Clear();

            lstItemsCsv.Items.Clear();
            lstPhotos.Items.Clear();

            listaDadosCsv.Clear();
            caminhoDaFoto.Clear();
        }


        //Criei essa fun��o para tirar o caminho inteiro da foto e deixar somente o nome do Arquivo da foto.
        string ObterNomeDaFoto(string caminhoFoto)
        {
            int DSCstringIndex = caminhoFoto.LastIndexOf("DSC");//Obt�m a localiza��o do DSC
            string foto = caminhoFoto.Remove(0, DSCstringIndex);//Remove tudo antes do DSC
            StringBuilder sb = new StringBuilder();//StringBuilder para armazenar os n�meros da string foto

            foreach (var c in foto) 
            {
                string l = c.ToString(); //Transforma a var 'c' em string para que possa chamar a fun��o "IsDigit"

                if (l.All(char.IsDigit)) //Verifica se a string � um n�mero e carrega ela para o Stringbuilder
                {
                    sb.Append(l);
                } 
            }

            foto = sb.ToString();//Converter o StringBuilder para string para ser armazenado na vari�vel fotos
            
            return foto;//Retorna a string com o n�mero da foto
        }

    }

    class CsvFileData
    {
        [Name("Turma", "turma")]
        public string turma { get; set; }

        [Name("Nome", "Nomes", "nome", "nomes")]
        public string nome { get; set; }

        [Name("Matr�cula", "Matricula", "Matriculas", "matriculas", "matr�culas")]
        public string matricula { get; set; }

        [Name("Foto", "Fotos", "foto", "fotos")]
        public string numeroDaFoto { get; set; }
    }

}