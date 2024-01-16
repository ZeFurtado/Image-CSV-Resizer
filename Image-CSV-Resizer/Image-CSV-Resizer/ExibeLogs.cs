using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_CSV_Resizer
{
    public partial class ExibeLogs : Form
    {
        public Fotos classeFotos = new Fotos();
        public ExibeLogs()
        {
            InitializeComponent();

            FormStartPosition formStartPosition = new FormStartPosition();
            StartPosition = formStartPosition;

            ExibirLogDeFotos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ExibirLogDeFotos()
        {
            string caminho = @$"{Directory.GetCurrentDirectory()}\ResizedPhotosLog.txt";

            try
            {
                richTextBox1.Text = File.ReadAllText(caminho);

            } catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        
    }
}
