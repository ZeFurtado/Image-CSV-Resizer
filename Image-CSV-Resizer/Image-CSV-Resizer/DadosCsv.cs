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
      
        public ListView csvDataView = new ListView();

        //Pega os campos do documento CSV
        [Name("Turma", "turma")]
        public string turma { get; set;}

        [Name("Nome", "Nomes", "nome", "nomes")]
        public string nome { get; set; }

        [Name("Matrícula", "Matricula", "Matriculas", "matriculas", "matrículas")]
        public string matricula { get; set; }

        [Name("Foto", "Fotos", "foto", "fotos")]
        public string foto { get; set; }

    }
}
