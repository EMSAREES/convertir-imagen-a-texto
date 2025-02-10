using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Tesseract;
//using IronOcr;

namespace image_to_text_converter
{
    public partial class cONVERT : Form
    {

        public cONVERT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // Crear una instancia de OpenFileDialog
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                // Configurar filtro de archivo para OpenFileDialog
                openFileDialog1.Filter = "Archivos de imagen (*.jpg; *.png; *.jpeg)|*.jpg;*.png;*.jpeg";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //richTxtImge.Text = " ";
                    
                    string imagePath = openFileDialog1.FileName;

                    pictureBox.Image = Image.FromFile(imagePath);
                    txtRuta.Text = imagePath;

                    converte(imagePath);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }

          
      
        }

        void converte(string path)
        {
            try
            {
                //var ocrTesseract = new IronTesseract();

                //using (var ocrInput = new OcrInput())
                //{
                //    ocrInput.TargetDPI = 300;

                //    ocrInput.LoadImage(path);

                //    var ocrResult = ocrTesseract.Read(ocrInput);
                //    richTxtImge.Text = ocrResult.Text;
                //};


                //descarr https://github.com/tesseract-ocr/tessdata/ y ponerlo en \bin\Debug del pruyecto

                richTxtImge.Enabled = true;

                //creamos una istancia de la ruta 
                using (var engine = new TesseractEngine(@"C:.\tessdata", "eng", EngineMode.Default))
                {
                    using (var image = Pix.LoadFromFile(path)) //cargamos la imagen desde la ruta
                    {
                        using (var page = engine.Process(image))// Procesar la imagen utilizando Tesseract para obtener el text
                        {
                            richTxtImge.Text = page.GetText();//imprimimos el texto aqui 
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
    
}
