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
        private StringBuilder mensagemDeErro = new StringBuilder();

        public string[] CarregaFotos() 
        {
            string[] fotos = {"Não foi possível carregar a foto"};

            var openPhotos = new OpenFileDialog();
            openPhotos.Filter = "Somente fotos .jpg | * .jpg";
            openPhotos.Multiselect = true;
            openPhotos.Title = "Selecione a(s) foto(s)";
            openPhotos.InitialDirectory = @$"C:\Users\{ObterNomeDoUser()}\desktop";

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
                mensagemDeErro.Append($"Não foi possível abrir o arquivo {openPhotos.FileNames}");
                mensagemDeErro.Append(ex.Message);
                MessageBox.Show(mensagemDeErro.ToString());
                return fotos;
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

        //Para que a foto permaneca na orientação correta ao ser redimensionada é necessário conferir as propriedades EXIF do arquivo a fim de verificar --
        //-- qual é a orientação original da foto e reposiciona-lá corretamente.
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
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            return retorno; 
        }

        public void SalvarFoto(Image fotoRedimensionada, string caminhoDestino, string nomeDoArquivo) 
        {

            try
            {
                fotoRedimensionada.Save($"{caminhoDestino}/{nomeDoArquivo}.JPG", ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                mensagemDeErro.Append($"Não foi possível salvar o arquivo {nomeDoArquivo}");
                mensagemDeErro.Append(ex.Message);
                MessageBox.Show(mensagemDeErro.ToString());
            }
            
        }

        public string ObterNomeDoUser()
        {
            int index = System.Security.Principal.WindowsIdentity.GetCurrent().Name.LastIndexOf(@"\");
            string caminho = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            caminho = caminho.Remove(0, index + 1);

            return caminho;
        }
    }
}
