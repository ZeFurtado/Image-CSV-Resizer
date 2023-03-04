using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using ExifLib;
using System.Drawing.Imaging;
using System.Drawing;


namespace Image_CSV_Resizer
{
    public partial class Form1 : Form
    {
        List<string> caminhoFotos = new List<string>();
        List<string> numMatriculaCSV = new List<string>();
        List<string> numFotoCSV = new List<string>();
        List<string> numTurmaCSV = new List<string>();

        
        public Form1()
        {
            InitializeComponent();
            ConfiguracaoListViewCSV();
            ConfiguracaoListViewResizedPhotos();

            this.WindowState = FormWindowState.Maximized;

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
            CarregaFotos();
        }
        void CarregaFotos() 
        {
            lstPhotos.ScrollAlwaysVisible = true;
            lstPhotos.HorizontalScrollbar = true;

            var openPhotos = new OpenFileDialog();
            openPhotos.Filter = "Somente fotos .jpg | * .jpg";
            openPhotos.Multiselect = true;
            openPhotos.Title = "Selecione a(s) foto(s)";
            openPhotos.InitialDirectory = @$"C:\Users\{ObterNomeDoUser()}\desktop";

            
            try
            {
                if (openPhotos.ShowDialog() == DialogResult.OK)
                {
                    lstPhotos.Items.Clear();
                    caminhoFotos.Clear();

                    foreach (var fotos in openPhotos.FileNames)
                    {
                        lstPhotos.Items.Add(fotos);
                        caminhoFotos.Add(fotos);
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
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
                openDir.InitialDirectory = @$"C:\Users\{ObterNomeDoUser()}\pictures";

                if (openDir.ShowDialog() == DialogResult.OK)
                {
                    txtDestinyFolder.Clear();
                    txtDestinyFolder.Text = openDir.SelectedPath; 
                }
            }
            catch(Exception ex) 
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
                openFile.InitialDirectory = @$"C:\Users\{ObterNomeDoUser()}\documents";
                

                txtCsvFile.Enabled = false;

                if (openFile.ShowDialog() == DialogResult.OK) 
                {
                    lstItemsCsv.Items.Clear();
                    numFotoCSV.Clear(); 
                    numMatriculaCSV.Clear();
                    numTurmaCSV.Clear();
                    

                    txtCsvFile.Text = openFile.FileName;
                   
                    var loadCsv = new StreamReader(txtCsvFile.Text);
                    var cultureConfig = new CsvConfiguration(CultureInfo.InvariantCulture);

                    using (var dados = new CsvReader(loadCsv, cultureConfig)) 
                    {
                        var dadosCsv = dados.GetRecords<DadosCsv>();

                        foreach (var items in dadosCsv) 
                        {
                            numFotoCSV.Add(items.foto);
                            numMatriculaCSV.Add(items.matricula);
                            numTurmaCSV.Add(items.turma);

                            string[] linha = { items.turma, items.nome, items.matricula, items.foto };
                            var lstViewLine = new ListViewItem(linha);
                            lstItemsCsv.Items.Add(lstViewLine);
                        }
                    }
                }

            }
            catch(Exception ex) 
            {
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
                        foreach (var arquivoFoto in caminhoFotos)
                        {
                            string arquivoFotoFiltrada = FiltrarCaminhoFoto(arquivoFoto);

                            if (arquivoFoto.Contains(fotoCSV))
                            {
                                string[] linha = { numTurmaCSV[index], arquivoFotoFiltrada, numMatriculaCSV[index] };
                                var lstViewLine = new ListViewItem(linha);
                                lstResizedPhotos.Items.Add(lstViewLine);

                                CriarNovaImagem(numTurmaCSV[index], arquivoFoto, numMatriculaCSV[index], PropriedadesExif(arquivoFoto));
                            }
                          

                        }
                        index++;
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        void CriarNovaImagem(string turma,string caminhoImagem, string matricula, UInt16 orientacao)
        {

            try
            {
                Image imagemOriginal = Image.FromFile(caminhoImagem);
                Image novaImagemRedimensionada = new Bitmap(imagemOriginal, new Size(400, 300));

                if (orientacao == 6)
                {
                    novaImagemRedimensionada.RotateFlip(RotateFlipType.Rotate270FlipXY);
                }
                else
                {
                    novaImagemRedimensionada.RotateFlip(RotateFlipType.Rotate90FlipXY);
                }

                SalvarArquivo(novaImagemRedimensionada, turma, matricula,txtDestinyFolder.Text);
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        UInt16 PropriedadesExif(string caminhoImagem)
        {
            UInt16 orientation;
            UInt16 retorno = 0;

            try
            {
                using (ExifReader leitorExif = new ExifReader(caminhoImagem))
                {
                    if (leitorExif.GetTagValue<UInt16>(ExifTags.Orientation, out orientation))
                    {
                        return orientation;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return retorno;
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
            caminhoFotos.Clear();
        }



        string FiltrarCaminhoFoto(string caminhoFoto)
        {
            int DSCstringIndex = caminhoFoto.LastIndexOf("DSC");
            string foto = caminhoFoto.Remove(0, DSCstringIndex);
            foto = foto.Replace(".JPG","");

            return foto;
        }
        string ObterNomeDoUser() 
        {
            int index = System.Security.Principal.WindowsIdentity.GetCurrent().Name.LastIndexOf(@"\");
            string caminho = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            caminho = caminho.Remove(0, index + 1);

            return caminho;
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
                else if (Directory.Exists(pastaDaTurma))//Verifica se o diretório existe
                {
                    imagemRedimensionada.Save(@$"{pastaDaTurma}\{matricula}.JPG", ImageFormat.Jpeg);
                }
                else 
                {
                    MessageBox.Show("Não foi possível salvar o arquivo", "Arquivo Foto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

    public class DadosCsv
    {
        [Name("Turma")]
        public string turma { get; set; }
        
        [Name("Nome")]
        public string nome { get; set; }

        [Name("Matrícula")]
        public string matricula { get; set; }

        [Name("Foto")]
        public string foto { get; set; }
    }

}