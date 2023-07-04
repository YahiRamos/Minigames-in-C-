using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIDEOJUEGOS
{
    public partial class JUEGODESNAKE : Form
    {
        List<PictureBox> lista = new List<PictureBox>();
        int tamañopiezaprincipal = 26, tiempo = 10;
        PictureBox comida = new PictureBox();
        string direccion = "Right";//direccion del snake

        public JUEGODESNAKE()
        {
            InitializeComponent();
            IJ();
            MessageBox.Show("OBJETIVO:" + "\n HACER QUE EL SNAKE COMA LA FRUTA PARA LOGRAR EL MAYOR PUNTAJE");
        }
        public void IJ()
        {
            tiempo = 10;
            direccion = "Right";
            timer1.Interval = 200;
            LBLPUNTOS.Text = "0";
            lista = new List<PictureBox>();
            //piezas iniciales
            for (int i = 2; 0 <= i; i--) 
            {
                crearsnake(lista, this, (i * tamañopiezaprincipal) + 70, 80);

            }
            crearcomida();
        }
        private void crearsnake(List<PictureBox> listapelota,Form formulario,int posicionx,int posiciony)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(posicionx, posiciony);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("cuerposnake");
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            listapelota.Add(pb);
            formulario.Controls.Add(pb);
        }
        private void crearcomida()
        {
            Random rnd = new Random();
            int enterox = rnd.Next(1, this.Width - tamañopiezaprincipal - 10);
            int enteroy = rnd.Next(1, this.Height - tamañopiezaprincipal - 40);
            PictureBox pb = new PictureBox();
            pb.Location = new Point(enterox, enteroy);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("comidasnake");
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            comida = pb;
            this.Controls.Add(pb);
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {

            int nx = lista[0].Location.X;
            int ny = lista[0].Location.Y;
            //colocar la cabeza
            lista[0].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("cuerposnake" + direccion);
            for (int i = lista.Count - 1; i >= 0; i--) 
            {
                if(i==0)
                {
                    if (direccion == "Right") nx = nx + tamañopiezaprincipal;
                    else if (direccion == "Left") nx = nx - tamañopiezaprincipal;
                    else if (direccion == "Up") ny = ny - tamañopiezaprincipal;
                    else if (direccion == "Down") ny = ny + tamañopiezaprincipal;
                    lista[0].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("cuerposnake" + direccion);
                    lista[0].Location = new Point(nx, ny);
                }
                else
                {
                    //intercambio de seguimiento
                    lista[i].Location = new Point((lista[i - 1].Location.X), (lista[i].Location.Y));
                    lista[i].Location = new Point(lista[i].Location.X, lista[i - 1].Location.Y);
                }
            }



            //detectar coalicion
            for (int contarpiezas = 1; contarpiezas < lista.Count; contarpiezas++) 
                {
                    if(lista[contarpiezas].Bounds.IntersectsWith(comida.Bounds))
                    {
                        this.Controls.Remove(comida);//remueve comida
                        tiempo = Convert.ToInt32(timer1.Interval);//aumenta el tiempo
                        if (tiempo > 10)
                    {
                        timer1.Interval = tiempo - 10;
                    }
                        LBLPUNTOS.Text = (Convert.ToInt32(LBLPUNTOS.Text) + 1).ToString();
                        crearcomida();//crea nueva comida
                        crearsnake(lista, this, lista[lista.Count - 1].Location.X * tamañopiezaprincipal, 0);//aumentar tamaño snake
                    }
                }
            //detectar colicion con paredes
           if ((lista[0].Location.X >= this.Width - 15) || (lista[0].Location.Y >= this.Height - 50) || (lista[0]. Location.Y < -10) || (lista[0].Location.X < -30)) 
            {
                reiniciarjuego();
            }
            for(int contarpiezas=1;contarpiezas<lista.Count;contarpiezas++)
            {
                if (lista[0].Bounds.IntersectsWith(lista[contarpiezas].Bounds)) { reiniciarjuego(); }
            }
        }

        public void reiniciarjuego()
        {
            foreach (PictureBox serpiente in lista) { this.Controls.Remove(serpiente); }
            this.Controls.Remove(comida);
            IJ();
        }
       

        

        private void JUEGODESNAKE_KeyUp(object sender, KeyEventArgs e)
        {
            direccion = ((e.KeyCode & Keys.Up) == Keys.Up) ? "Up" : direccion;
            direccion = ((e.KeyCode & Keys.Down) == Keys.Down) ? "Down" : direccion;
            direccion = ((e.KeyCode & Keys.Left) == Keys.Left) ? "Left" : direccion;
            direccion = ((e.KeyCode & Keys.Right) == Keys.Right) ? "Right" : direccion;
        }

        private void JUEGODESNAKE_Load(object sender, EventArgs e)
        {

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
