using CsvHelper.Configuration.Attributes;
using static System.Net.WebRequestMethods;

namespace Image_CSV_Resizer
{
    //Classe criada para extrair os dados do arquivo CSV
    public class DadosCsv
    {
        private string turma;
        private string nome;
        private string matricula;
        private string numeroDaFoto;

        public DadosCsv(string turma, string nome, string matricula, string numeroDaFoto) 
        {
            this.turma = RemoveEspaco(turma);
            this.nome = RemoveEspaco(nome);
            this.matricula = RemoveEspaco(matricula);
            this.numeroDaFoto = RemoveEspaco(numeroDaFoto);
        }

        public string GetTurma() 
        {
            return turma;
        }

        public void SetTurma(string turma) 
        {
            this.turma = turma;
        }

        public string GetNome() 
        {
            return nome;
        }

        public void SetNome(string nome) 
        {
            this.nome = nome;
        }

        public string GetMatricula() 
        {
            return matricula;
        }

        public void SetMatricula(string matricula) 
        {
            this.matricula = matricula;
        }

        public string GetNumeroDaFoto() 
        {
            return numeroDaFoto;
        }

        public void SetNumeroDaFoto(string numeroDaFoto) 
        {
            this.numeroDaFoto = numeroDaFoto;
        }

        public override string ToString()
        {
            string content = $"Turma: '{turma}'\n" +
                             $"Nome: '{nome}'\n" +
                             $"Matrícula: '{matricula}'\n" +
                             $"Nº da Foto: '{numeroDaFoto}'";
            
            
            return content;
        }

        private string RemoveEspaco(string dado) //Função criada para remover o espaço no inicio e no fim dos dados
        {
            if (dado.IndexOf(" ") >= 0)
            {
                dado = dado.TrimStart();
                dado = dado.TrimEnd();
                return dado;
            }
            else 
            {
                return dado;
            }

        }
    }

    
}
