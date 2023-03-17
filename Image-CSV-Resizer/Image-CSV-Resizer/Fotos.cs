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
            openPhotos.Multiselect = true;
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

                if (PropriedadesExif(caminhoDoArquivo) == 6)
                {
                    fotoRedimensionada.RotateFlip(RotateFlipType.Rotate270FlipXY);
                }
                else 
                {
                    fotoRedimensionada.RotateFlip(RotateFlipType.Rotate90FlipXY);
                }

                return fotoRedimensionada;
            }
            catch(Exception ex) 
            {
                Image erro = new Bitmap(1, 1);
                MessageBox.Show(ex.Message);
                return erro;
            }

        }

        public UInt16 PropriedadesExif(string caminhoImagem) 
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
            catch 
            {
                return retorno;
            }

            return retorno;
        }
    }
}
