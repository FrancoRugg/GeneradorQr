using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Rendering;

namespace PruebaQr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmdGenerarQr_Click(object sender, EventArgs e)
        {
            string contenido =txtQr.Text;
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.QR_CODE;

            var matrizBirts = barcodeWriter.Encode(contenido);

            var render = new BitmapRenderer();
            var image = render.Render(matrizBirts, BarcodeFormat.QR_CODE, contenido);
            pictureBox1.Image = image;
        }

        private void cmdLeerQr_Click(object sender, EventArgs e)
        {
            BarcodeReader barcodeReader = new BarcodeReader();//captura la imagen del picture box, lo decodifica y muestra lo que tiene dentro;
            Bitmap image = (Bitmap)pictureBox1.Image;
            Result result = barcodeReader.Decode(image);

            if(result != null)
            {
                MessageBox.Show(result.Text);
            }

        }

        private void cmdGenerarBarras_Click(object sender, EventArgs e)
        {
            string contenido = txtBarras.Text;
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.CODE_128;

            var matrizBirts = barcodeWriter.Encode(contenido);

            var render = new BitmapRenderer();
            var image = render.Render(matrizBirts, BarcodeFormat.CODE_128, contenido);
            pictureBox2.Image = image;
        }

        private void cmdLeerBarras_Click(object sender, EventArgs e)
        {
            BarcodeReader barcodeReader = new BarcodeReader();//captura la imagen del picture box, lo decodifica y muestra lo que tiene dentro;
            Bitmap image = (Bitmap)pictureBox2.Image;
            Result result = barcodeReader.Decode(image);

            if (result != null)
            {
                MessageBox.Show(result.Text);
            }
        }
    }
}
