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
            this.turma = turma;
            this.nome = nome;
            this.matricula = matricula;
            this.numeroDaFoto = numeroDaFoto;
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
            string content = $"Turma: {turma}\n" +
                             $"Nome: {nome}\n" +
                             $"Matrícula: {matricula}\n" +
                             $"Nº da Foto: {numeroDaFoto}";
            
            
            return content;
        }
    }

    
}
