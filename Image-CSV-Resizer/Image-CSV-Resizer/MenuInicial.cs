using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_CSV_Resizer
{
    public partial class MenuInicial : Form
    {
        Form form1 = new Form1();
        Form form2 = new Form2();
        public MenuInicial()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Show();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            form2.ShowDialog();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExibeLogs exibeLogs = new ExibeLogs();

            exibeLogs.Show();

        }
    }
}
