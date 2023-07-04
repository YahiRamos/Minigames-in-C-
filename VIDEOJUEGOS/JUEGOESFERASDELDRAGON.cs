using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIDEOJUEGOS
{
    public partial class JUEGOESFERASDELDRAGON : Form
    {
        List<PictureBox> lista = new List<PictureBox>();
        int velocidad = 1, colorpong = 1;
        Random colorbalon = new Random();
        SoundPlayer sonido = new SoundPlayer();
        public JUEGOESFERASDELDRAGON()
        {
            InitializeComponent();
            IJ();
            MessageBox.Show("OBJETIVO:" + "\n CAMBIAR EL COLOR DE LA BARRA AL DE LAS POKEBOLAS PARA LOGRAR EL MAYOR PUNYAJE POSIBLE");
            MessageBox.Show("CONTROLES: LA BARRA ESPACIADORA");
        }
        public void IJ()
        {
            velocidad = 1;
            pictureBox1.Tag = 1;
            this.KeyPreview = true;
            lblrecord.Text = "0";
            crearpelota(lista,this);
            timer1.Start();
            timer2.Start();
            sonido.Stream = Properties.Resources.normal;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < lista.Count; i++) 
            {
                int movimientoy;
                movimientoy = lista[i].Location.Y;
                movimientoy = movimientoy + velocidad;
                lista[i].Location = new Point(lista[i].Location.X, movimientoy);
            }
            if(lista.Count>0)
            {
                //crea otra pelota
                if (lista[(lista.Count) - 1].Location.Y > 5) 
                {
                    crearpelota(lista,this);
                }
            }
        }
        public void crearpelota(List<PictureBox>listapelota,Form formulario)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(135, -80);
            int numerocolor = colorbalon.Next(1,4);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("pkb" + (numerocolor));
            pb.Tag = numerocolor;
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            listapelota.Add(pb);
            formulario.Controls.Add(pb);
        }

        private void cambiardecolor(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Space))
            {
                colorpong++;
                if (colorpong == 4)
                {
                    colorpong = 1;
                }
                pictureBox1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("pong" + colorpong);
                pictureBox1.Tag = colorpong;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < lista.Count; i++) 
            {
                if (lista[i].Bounds.IntersectsWith(pictureBox1.Bounds)) 
                {//compara color de barra y pokeballs
                    if (lista[i].Tag.ToString() == pictureBox1.Tag.ToString()) 
                    {
                        int puntos = Convert.ToInt32(lblrecord.Text);
                        puntos++;
                        if (puntos % 5 == 0) 
                        {
                            velocidad++;
                        }
                        lblrecord.Text = puntos.ToString();
                        sonido.Play();
                    }
                    else
                    {
                        limpiarlistas();
                    }
                    this.Controls.Remove(lista[i]);
                    lista.RemoveAt(i);
                }
            }
        }
        public void limpiarlistas()
        {
            timer1.Stop();
            timer2.Stop();
            for (int i = 0; i <= lista.Count; i++)
            {//eliminar todo para iniciar de nuevo
                this.Controls.Remove(lista[i]);
                lista.RemoveAt(i);
            }
            sonido.Stream = Properties.Resources.perdedor;
            sonido.Play();
            MessageBox.Show("PERDISTE :(", "GAME OVER");
            IJ();
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿DESEA SALIR DEL JUEGO?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

       
    }
}
