using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExifLib;

namespace Image_CSV_Resizer
{
    public class Fotos
    {
        public string[] CarregaFotos() 
        {
            string[] fotos = {""};

            var openPhotos = new OpenFileDialog();
            openPhotos.Filter = "Somente fotos .jpg | * .jpg";
            openPhotos.Multiselect = false;
            openPhotos.Title = "Selecione as fotos";

            try
            {
                if (openPhotos.ShowDialog() == DialogResult.OK)
                {
                    return openPhotos.FileNames;
                }
                else 
                {
                    return fotos;
                }

            }
            catch (Exception ex) 
            {
                return fotos;
                MessageBox.Show(ex.Message);
            }
        }

        public Image RedimensionarFoto(string caminhoDoArquivo, int altura, int largura) 
        {
            try
            {
                Image fotoOriginal = Image.FromFile(caminhoDoArquivo);
                Image fotoRedimensionada = new Bitmap(fotoOriginal, largura, altura);

                return fotoRedimensionada;
            }
            catch(Exception ex) 
            {
                Image erro = new Bitmap(1, 1);
                MessageBox.Show(ex.Message);
                return erro;
            }

        }
    }
}
