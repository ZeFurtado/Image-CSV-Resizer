using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_CSV_Resizer
{
    public class Fotos
    {
        public string[] CarregaFotos() 
        {
            string[] fotos = {"Não", "Bombou"};

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
    }
}
