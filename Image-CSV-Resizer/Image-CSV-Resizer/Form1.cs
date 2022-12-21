namespace Image_CSV_Resizer
{
    public partial class btnCSV : Form
    {
        List<string> caminhoFotos = new List<string>();
        List<string> numMatricula = new List<string>();

        public btnCSV()
        {
            InitializeComponent();
            
            BackColor = Color.FromArgb(80, 80, 80);
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
            openPhotos.InitialDirectory = @"C:\Users\Lukhas Furtado\Desktop\Repositório\Image-CSV-Resizer\Fotos";

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

    }

}