using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExifLib;
using System.Drawing;
using System.Drawing.Imaging;

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

        public Image RedimensionarFoto(string caminhoDoArquivo, int largura, int altura) 
        {
    
            try
            {
                Image fotoOriginal = Image.FromFile(caminhoDoArquivo);
                Image fotoRedimensionada;

                if (PropriedadesExif(caminhoDoArquivo) == 6) //O número 6 representa á rotação tirada por alguém canhoto
                {
                    fotoOriginal.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                else
                {
                    fotoOriginal.RotateFlip(RotateFlipType.Rotate90FlipXY);
                }

                if (altura == 768 && largura == 663)
                {
                    Bitmap fotoCortada = new Bitmap(fotoOriginal, largura, 884); //Ele primeiro redimensionada a foto com Altura de 884 para manter a proporção.
                    Rectangle cropArea = new Rectangle(0, 0, 663, 768);//Cria um retângulo de corte com o valor correto para a altura.
                    fotoRedimensionada = fotoCortada.Clone(cropArea, fotoOriginal.PixelFormat);//Realize o corte e deixa a imagem com a Altura correta.
                }
                else {
                    fotoRedimensionada = new Bitmap(fotoOriginal, largura, altura);
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

        public UInt16 PropriedadesExif(string caminhoImagem) //Verifica as propriedades EXIF da imagem para extrair a orientação
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

        public void SalvarFoto(Image fotoRedimensionada, string caminhoImagem, string nomeDoArquivo)
        {
            try
            {
                fotoRedimensionada.Save($"{caminhoImagem}/{nomeDoArquivo}", ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
