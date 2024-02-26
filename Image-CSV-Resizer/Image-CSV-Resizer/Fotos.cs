using System.Text;
using ExifLib;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace Image_CSV_Resizer
{
    public class Fotos
    {
        private StringBuilder mensagemDeErro = new StringBuilder();

        //Função carrega fotos retorna um array de string com o caminho do arquivo das fotos
        //O mesmo que é exibido no formulário é o que é carregado no array.
        public string[] CarregaFotos() 
        {
            string[] fotos = {""};

            var openPhotos = new OpenFileDialog();
            openPhotos.Filter = "Somente Fotos (*.PNG; *.JPG)| *.PNG; *.JPG";
            openPhotos.FilterIndex = 1;
            openPhotos.Multiselect = true;
            openPhotos.Title = "Selecione a(s) foto(s)";
            openPhotos.InitialDirectory = @$"C:\Users\{ObterNomeDoUser()}\Desktop";

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
                LogDeErros(DateTime.Now.ToString("MMM ddd d HH:mm yyyy"), ex.Message, ex.Source, "CarregaFotos() em Fotos.cs");
                return fotos;
            }
        }


        public string[] CarregaFotos(List <string> caminhoDaFoto) 
        {

            string[] fotos = { "" };

            var openPhotos = new OpenFileDialog();
            openPhotos.Filter = "Somente Fotos (*.PNG; *.JPG)| *.PNG; *.JPG";
            openPhotos.FilterIndex = 1;
            openPhotos.Multiselect = true;
            openPhotos.Title = "Selecione a(s) foto(s)";
            openPhotos.InitialDirectory = @$"C:\Users\{ObterNomeDoUser()}\Desktop";

            try
            {
                if (openPhotos.ShowDialog() == DialogResult.OK)
                {
                    return openPhotos.FileNames;
                }
                else 
                {
                    return caminhoDaFoto.ToArray();
                }
            }
            catch(Exception ex) 
            {
                mensagemDeErro.Append($"Não foi possível abrir o arquivo {openPhotos.FileNames}");
                mensagemDeErro.Append(ex.Message);
                MessageBox.Show(mensagemDeErro.ToString());
                LogDeErros(DateTime.Now.ToString("MMM ddd d HH:mm yyyy"), ex.Message, ex.Source, "CarregaFotos(1 arg) em Fotos.cs");
                return fotos;
            }
        }


        
        public Image RedimensionarFoto(string caminhoDoArquivo, int largura, int altura) 
        {
            try
            {
                Image fotoOriginal = Image.FromFile(caminhoDoArquivo);
                Image fotoRedimensionada;

                //Primeiro é verificado qual a orientação da foto
                if (PropriedadesExif(caminhoDoArquivo) == 6) //O número 6 representa á rotação tirada por alguém canhoto
                {
                    fotoOriginal.RotateFlip(RotateFlipType.Rotate90FlipNone);  
                }
                else
                {
                    fotoOriginal.RotateFlip(RotateFlipType.Rotate90FlipXY);
                }

                //Em seguida será verficado qual o tamanho dela para ser mantida a proporção
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
                LogDeErros(DateTime.Now.ToString("MMM ddd d HH:mm yyyy"), ex.Message, ex.Source, "RedimensionarFoto() em Fotos.cs");
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
                LogDeErros(DateTime.Now.ToString("MMM ddd d HH:mm yyyy"), ex.Message, ex.Source, "PropriedadesExif() em Fotos.cs");
            }

            return retorno; 
        }

        //Função para salvar a foto sem criar pasta da turma
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
                LogDeErros(DateTime.Now.ToString("MMM ddd d HH:mm yyyy"), ex.Message, ex.Source, "SalvarFoto(3 args) em Fotos.cs");

            }           
        }

        //Sobrecarga da função SalvarFoto para caso haja uma turma o programa criar a pasta da mesma
        public void SalvarFoto(Image fotoRedimensionada, string caminhoDestino, string nomeDoArquivo, string turma) 
        {
            try
            {
                string caminhoPastaTurma = @$"{caminhoDestino}\{turma}";

                if (caminhoDestino.Contains(turma)) //Sé o camimho de destino já for uma pasta com o nome da turma o programa só salva ela
                { 
                    fotoRedimensionada.Save(@$"{caminhoDestino}\{nomeDoArquivo}.JPG", ImageFormat.Jpeg);  

                } else if (!Directory.Exists(caminhoPastaTurma)) //Verifica se o diretório NÃO existe e cria ele.
                {
                    Directory.CreateDirectory(caminhoPastaTurma);
                    fotoRedimensionada.Save($@"{caminhoPastaTurma}\{nomeDoArquivo}.JPG", ImageFormat.Jpeg);

                } else if (Directory.Exists(caminhoPastaTurma))
                {
                    fotoRedimensionada.Save($@"{caminhoPastaTurma}\{nomeDoArquivo}.JPG", ImageFormat.Jpeg);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                LogDeErros(DateTime.Now.ToString("MMM ddd d HH:mm yyyy"), ex.Message, ex.Source, "SalvarFoto(4 args) em Fotos.cs");
            }
        }

        //Função para obter o nome do usuário e setar o diretório incial
        public string ObterNomeDoUser()
        {
            int index = System.Security.Principal.WindowsIdentity.GetCurrent().Name.LastIndexOf(@"\");
            string caminho = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            caminho = caminho.Remove(0, index + 1);

            return caminho;
        }

        //Função para inserir dados das fotos redimensionadas pelo "Somente redimensionar"
        public void LogDeFotosRedimensionadas(string hora, string caminhoDaFoto, string nomeDoArquivo)
        {
            string mensagem =  "[Somente redimensionar]\n" +
                              $"{hora}\n" +
                              $"{caminhoDaFoto}";

            string caminho = @$"{Directory.GetCurrentDirectory()}\ResizedPhotosLog.txt";
            using (StreamWriter sw = File.AppendText(caminho)) 
            {
                sw.WriteLine(mensagem + "\n");
            }

        }

        //Sobrecarga da função para inserir os dados das fotos redimensionadas pelo "Redimensionar com arquivo CSV"
        public void LogDeFotosRedimensionadas(string hora, string caminhoDaFoto, DadosCsv dados) 
        {
            string mensagem =  "[Redimensionar com arquivo CSV]\n" +
                              $"{dados}\n" +
                              $"Hora: {hora}\n" +
                              $"Salvo inicialmente em: {caminhoDaFoto}";

            string caminho = @$"{Directory.GetCurrentDirectory()}\ResizedPhotosLog.txt";
            using (StreamWriter sw = File.AppendText(caminho)) 
            {
                sw.WriteLine(mensagem + "\n");
            }
        }

        //Função que carrega o arquivo TXT das fotos redimensionadas.
        public void ExibirLogDeFotos() 
        {
            string caminho = @$"{Directory.GetCurrentDirectory()}\ResizedPhotosLog.txt";

            try
            {
                File.Open(caminho, FileMode.Open);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
        
        //Função criada para armazenar os erros para possíveis soluções
        public void LogDeErros(string hora, string mensagemDeErro, string fonteDoProblema, string nomeDaFuncao) 
        {
            string mensagem = $"Mensgagem de erro: {mensagemDeErro}\n" +
                              $"Nome da Função: {nomeDaFuncao}\n"+
                              $"Fonte do problema: {fonteDoProblema}\n" +
                              $"Hora: {hora}";

            string caminho = @$"{Directory.GetCurrentDirectory()}\ErrorLog.txt";
            using (StreamWriter sw = File.AppendText(caminho)) 
            {
                sw.WriteLine(mensagem + "\n");
            }
        }

    }
}
