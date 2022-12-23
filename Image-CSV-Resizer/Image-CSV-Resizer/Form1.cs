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
            
            BackColor = Color.FromArgb(80, 80, 80);


            lstItemsCsv.View = View.Details;
            lstItemsCsv.LabelEdit = true;
            lstItemsCsv.Columns.Add("Nome", lstItemsCsv.Size.Width / 2, HorizontalAlignment.Left);
            lstItemsCsv.Columns.Add("Matrícula", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
            lstItemsCsv.Columns.Add("Nº da Foto", lstItemsCsv.Size.Width / 4, HorizontalAlignment.Left);
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

                if (openDir.ShowDialog() == DialogResult.OK)
                {
                    txtDestinyFolder.Clear();
                    txtDestinyFolder.Text = openDir.SelectedPath;
                    openDir.InitialDirectory = @"C:\Users\Lukhas Furtado\Desktop\Repositório\Image-CSV-Resizer";
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
                openFile.InitialDirectory = @"C:\Users\Lukhas Furtado\Desktop\Repositório\Image-CSV-Resizer";
                

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

                foreach (var itens in numFotoCSV) 
                {
                    MessageBox.Show(itens);
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
            
            numMatriculaCSV.Clear();
            numFotoCSV.Clear();
            caminhoFotos.Clear();
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