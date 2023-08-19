using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_CSV_Resizer
{
    public class DadosCsv
    {

        private List<string> caminhoDaFoto = new List<string>(); //Recebe o caminho total do arquivo da foto
        private List<string> numMatriculaCSV = new List<string>(); //Armazena número de matrícula do aluno
        private List<string> numFotoCSV = new List<string>(); //Recebe o número da foto do aluno
        private List<string> numTurmaCSV = new List<string>(); //Recebe o nome da turma 

        public List<string> Get_caminhoDaFoto() 
        {
            return caminhoDaFoto;
        }

        public List<string> Get_numMatriculaCSV() 
        {
            return numMatriculaCSV;
        }

        public List<string> Get_numFotoCSV() 
        {
            return numFotoCSV;
        }

        public List<string> Get_numTurma() 
        {
            return numTurmaCSV;
        }


        //Pega os campos do documento CSV
        [Name("Turma", "turma")]
        public string turma { get; set;}

        [Name("Nome", "Nomes", "nome", "nomes")]
        public string nome { get; set; }

        [Name("Matrícula", "Matricula", "Matriculas", "matriculas", "matrícualas")]
        public string matricula { get; set; }

        [Name("Foto", "Fotos", "foto", "fotos")]
        public string foto { get; set; }






        public void CsvDataRead(string caminhoDoArquivo) {

            string erro = "Não foi possível carregar o arquivo CSV"; //Mensagem de erro exibida na list view do arquivo csv

            try
            {
                var loadCsv = new StreamReader(caminhoDoArquivo);
                var cultureConfig = new CsvConfiguration(CultureInfo.InvariantCulture);

                using (var dados = new CsvReader(loadCsv, cultureConfig))
                {
                    var dadosCsv = dados.GetRecords<DadosCsv>();

                    foreach (var items in dadosCsv)
                    {
                        numFotoCSV.Add(items.foto);
                        numMatriculaCSV.Add(items.matricula);
                        numTurmaCSV.Add(items.turma);
                    }

                }

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(erro);
            }
            
        }

    }
}
