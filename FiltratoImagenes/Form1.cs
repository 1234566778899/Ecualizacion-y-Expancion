using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltratoImagenes
{
    public partial class imgOriginal : Form
    {
        public imgOriginal()
        {
            InitializeComponent();
        }

        private void abrirImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            openFileDialog1.Title = "Seleccionar imagen";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string imagePath = openFileDialog1.FileName;
                imgOriginal2.ImageLocation = imagePath;
                imgOriginal2.SizeMode = PictureBoxSizeMode.StretchImage;
                lblseleccione.Visible = false;
            }
        }
        private void ConvertirAEscaladeGrises(Bitmap imagenOriginal)
        {
            int promedio;
            Color pixelColor;
            int ancho = imagenOriginal.Width;
            int alto = imagenOriginal.Height;
            Bitmap imagenGrises = new Bitmap(ancho, alto);

            for (int y = 0; y < alto; y++)
            {
                for (int x = 0; x < ancho; x++)
                {
                    pixelColor = imagenOriginal.GetPixel(x, y);
                    promedio = (int)((pixelColor.R * 0.3) + (pixelColor.G * 0.59) + (pixelColor.B * 0.11));
                    imagenGrises.SetPixel(x, y, Color.FromArgb(promedio, promedio, promedio));
                }
            }
            imgOriginal2.Image = imagenGrises;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var frmCarga = new frmCarga();
            frmCarga.Show();

            // Ejecutar la función en segundo plano
            await Task.Run(() => {
                ConvertirAEscaladeGrises((Bitmap)imgOriginal2.Image);
            });

            frmCarga.Close();
        }

        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
         
                var frmCarga = new frmCarga();
                frmCarga.Show();

                // Ejecutar la función en segundo plano
                await Task.Run(() => {
                    imgResultado.Image = HistogramEqualization((Bitmap)imgOriginal2.Image);
                    
                });
                 frmCarga.Close();
            lbltipo.Text = "Imagen ecualizado";

        }

        private void imgOriginal_Click(object sender, EventArgs e)
        {

        }
        public static Bitmap HistogramExpansion(Bitmap image, int a, int b)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);

            int[] histogram = new int[256];
            float[] cdf = new float[256];

            // Calculate histogram
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int gray = (int)(pixel.R * 0.299 + pixel.G * 0.587 + pixel.B * 0.114);
                    histogram[gray]++;
                }
            }

            // Calculate cumulative distribution function
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += histogram[i];
                cdf[i] = (float)sum / (image.Width * image.Height);
            }

            // Expand histogram
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int gray = (int)(pixel.R * 0.299 + pixel.G * 0.587 + pixel.B * 0.114);
                    int value = (int)((cdf[gray] - cdf[a]) / (cdf[b] - cdf[a]) * 255);
                    value = Math.Min(Math.Max(value, 0), 255);
                    result.SetPixel(x, y, Color.FromArgb(value, value, value));
                }
            }

            return result;
        }
        public static Bitmap HistogramEqualization(Bitmap image)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);

            int[] histogram = new int[256];
            float[] cdf = new float[256];

            // Calculate histogram
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int gray = (int)(pixel.R * 0.299 + pixel.G * 0.587 + pixel.B * 0.114);
                    histogram[gray]++;
                }
            }

            // Calculate cumulative distribution function
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += histogram[i];
                cdf[i] = (float)sum / (image.Width * image.Height);
            }

            // Equalize histogram
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int gray = (int)(pixel.R * 0.299 + pixel.G * 0.587 + pixel.B * 0.114);
                    int value = (int)(cdf[gray] * 255);
                    result.SetPixel(x, y, Color.FromArgb(value, value, value));
                }
            }

            return result;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (txtmax.Text != "" && textmin.Text != "")
            {
                int min = Convert.ToInt16(textmin.Text);
                int max = Convert.ToInt16(txtmax.Text);
                if (min >= 0 && min <= max && max >= 0 && max <= 255 && max > min)
                {
                    frmCarga f = new frmCarga();
                    f.Show();
                    await Task.Run(() =>
                    {
                       imgResultado.Image = HistogramExpansion((Bitmap)imgOriginal2.Image, min, max);
                        
                    });
                    f.Close();
                    lbltipo.Text = "Imagen expandido (" + min + " a " + max + ")";
                }        
                else
                    MessageBox.Show("Debe completar todos los campos correctamente");
            }
            else MessageBox.Show("Debe completar los campos min y max");
        }

        private void originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistograma f = new frmHistograma((Bitmap)imgOriginal2.Image);
            f.Show();
        }

        private void resultanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistograma f = new frmHistograma((Bitmap)imgResultado.Image);
            f.Show();
        }
    }
}
