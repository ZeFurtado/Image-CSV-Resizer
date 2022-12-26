using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using System.Drawing.Imaging;
using System.Drawing;


namespace Image_CSV_Resizer
{
    public partial class Form1 : Form
    {
        List<string> caminhoFotos = new List<string>();
        List<string> numMatriculaCSV = new List<string>();
        List<string> numFotoCSV = new List<string>();

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
            lstItemsCsv.Columns.Add("Nome", lstItemsCsv.Size.Width / 2, HorizontalAlignment.Left);
            lstItemsCsv.Columns.Add("Matr�cula", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
            lstItemsCsv.Columns.Add("N� da Foto", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
        }
        void ConfiguracaoListViewResizedPhotos() 
        {
            lstResizedPhotos.View = View.Details;
            lstResizedPhotos.LabelEdit = true;
            lstResizedPhotos.Scrollable = true;
            lstResizedPhotos.Columns.Add("N�mero da foto", lstResizedPhotos.Width / 6, HorizontalAlignment.Left);
            lstResizedPhotos.Columns.Add("Matr�cula do aluno", lstResizedPhotos.Width / 6, HorizontalAlignment.Left);
            lstResizedPhotos.Columns.Add("Caminho do arquivo", lstResizedPhotos.Width / 1, HorizontalAlignment.Left);
        }


        private void btnPhotos_Click(object sender, EventArgs e)
        {
            CarregaFotos();
        }

        void CarregaFotos() 
        {
            
            var openPhotos = new OpenFileDialog();
            openPhotos.Filter = "Somente fotos .jpg | * .jpg";
            openPhotos.Multiselect = true;
            openPhotos.Title = "Selecione a(s) foto(s)";
            openPhotos.InitialDirectory = @"C:\Users\lukhas.furtado\source\repos\Image-CSV-Resizer\Fotos";

            lstPhotos.ScrollAlwaysVisible = true;
            lstPhotos.HorizontalScrollbar = true;
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
                openDir.InitialDirectory = @"C:\Users\lukhas.furtado\source\repos\Image-CSV-Resizer\Destino";

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
                
                openFile.Filter = "Arquivo separado por v�rgula .csv | * .csv";
                openFile.Title = "Selecione o arquivo CSV";
                openFile.InitialDirectory = @"C:\Users\lukhas.furtado\source\repos\Image-CSV-Resizer\";
                

                txtCsvFile.Enabled = false;

                if (openFile.ShowDialog() == DialogResult.OK) 
                {
                    numFotoCSV.Clear(); 
                    numMatriculaCSV.Clear();

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

                            string[] linha = { items.nome, items.matricula, items.foto };
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

                try
                {
                    int matriculaIndex = 0;
                    foreach (var fotoCSV in numFotoCSV)
                    {
                        foreach (var arquivoFoto in caminhoFotos)
                        {
                            string arquivoFotoFiltrada = FiltrarCaminhoFoto(arquivoFoto);

                            if (arquivoFoto.Contains(fotoCSV)) 
                            {
                                string[] linha = { arquivoFotoFiltrada, numMatriculaCSV[matriculaIndex], arquivoFoto };
                                var lstViewLine = new ListViewItem(linha);
                                lstResizedPhotos.Items.Add(lstViewLine);
                            } 
                        }
                        matriculaIndex++;
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
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
            lstResizedPhotos.Items.Clear();
            
            numMatriculaCSV.Clear();
            numFotoCSV.Clear();
            caminhoFotos.Clear();
        }



        string FiltrarCaminhoFoto(string caminhoFoto)
        {
            int DSCstringIndex = caminhoFoto.LastIndexOf("DSC");
            string foto = caminhoFoto.Remove(0, DSCstringIndex);

            return foto;
        }
    }

    public class DadosCsv 
    {
        [Name("Nome")]
        public string nome { get; set; }

        [Name("Matricula")]
        public string matricula { get; set; }

        [Name("Foto")]
        public string foto { get; set; }
    }

}