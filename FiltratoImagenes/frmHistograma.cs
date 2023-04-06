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
    public partial class frmHistograma : Form
    {
        Bitmap img;
        Graphics g;
        public frmHistograma(Bitmap image)
        {
            InitializeComponent();
            g = panelHistograma.CreateGraphics();
            img = image;
        }
        public void DibujarHistograma(Bitmap imagen, Graphics graphics)
        {
            // Obtener los valores de intensidad de cada pixel de la imagen
            int[] intensidades = new int[256];
            int _x=10, _y=10;
            for (int y = 0; y < imagen.Height; y++)
            {
                for (int x = 0; x < imagen.Width; x++)
                {
                    Color color = imagen.GetPixel(x, y);
                    int intensidad = (int)(color.GetBrightness() * 255);
                    intensidades[intensidad]++;
                }
            }

            // Obtener el valor máximo de intensidad para normalizar el histograma
            int maxIntensidad = intensidades.Max();

            // Dibujar los ejes del histograma
            Pen penEjes = new Pen(Color.Black);
            graphics.DrawLine(penEjes, _x, _y, _x, 255);
            graphics.DrawLine(penEjes, _x, 255, 255, 255);

            // Dibujar las líneas del histograma
            Pen penLineas = new Pen(Color.Red);
            for (int i = 0; i < 256; i++)
            {
                int altura = (int)(intensidades[i] * 255.0 / maxIntensidad);
                graphics.DrawLine(penLineas, i+_x, 255, i+_x, 255 - altura);
            }
        }
        private async void frmHistograma_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                DibujarHistograma(img, g);
                pictureBox1.Image = img;
            });
        }
    }
    
}
