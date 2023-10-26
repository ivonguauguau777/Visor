using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Muestra el cuadro de diálogo Abrir archivo. Si el usuario hace clic en Aceptar,
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName); // carga la imagen que el usuario eligió.
            }
        }

        private void clearButtony_Click(object sender, EventArgs e)
        {
            // borra la imagen anterior
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            //Muestra el cuadro de diálogo de color. Si el usuario hace clic en Aceptar
            //cambie el fondo del control PictureBox al color que eligió el usuario.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            //Si el usuario selecciona la casilla de verificación Estirar,
            //cambiar el PictureBox Propiedad SizeMode a "Estirar".Si el usuario borra
            //la casilla de verificación, cámbiela a "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // cierra la ventana 
            this.Close();
        }
    }
}
