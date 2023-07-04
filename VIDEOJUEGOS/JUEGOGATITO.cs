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
    public partial class JUEGOGATITO : Form
    {
        int turno = 1;
        int[,] gato;
        int pp1=0;
        int pp2 = 0;
        bool yahayganador;

        public JUEGOGATITO()
        {
            InitializeComponent();
            IJ();
            MessageBox.Show("OBJETIVO:" + "\n CONECTAR 3 FICHAS DE TU PERSONAJE CREANDO UNA RAYA");
            MessageBox.Show("CONTROLES: EL RATON DE LA COMPUTADORA");
        }
        public void IJ()
        {
            //INICIAR VALORES DEL JUEGO
            turno = 1;
            gato = new int[3,3];
            yahayganador = false;
            PICGANADOR.Image = Properties.Resources.Espada_Maestra_TWW;
            fichasgato.Controls.Clear();
            //arreglos para meter las fichas
            for (var i = 0; i < 3; i++)
            {
                for(var j =0 ; j < 3;j++)
                {
                    var fichadejuego = new PictureBox();
                    fichadejuego.Image = Properties.Resources.Espada_Maestra_TWW;
                    fichadejuego.Name = string.Format("{0}", i + "_" + j);
                    fichadejuego.Dock = DockStyle.Fill;
                    fichadejuego.Cursor = Cursors.Hand;
                    fichadejuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    fichadejuego.Click += jugar;
                    fichasgato.Controls.Add(fichadejuego, j, i);
                    gato[i, j] = 0;
                }
            }
        }
        private void jugar(object sender,EventArgs e)
        {
            var fichaseleccionadausuario = (PictureBox)sender;
            fichaseleccionadausuario.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turno);
            string[] posicion = fichaseleccionadausuario.Name.Split("_".ToCharArray());
            int fila = Convert.ToInt32(posicion[0]);
            int columna = Convert.ToInt32(posicion[1]);
            gato[fila, columna] = turno;
            verificarjuego(fila, columna);
            turno = (turno == 1) ? 2 : 1;
        }
        private void verificarjuego(int fila,int columna)
        {
            //contador de fichas en filas y columnas
            int ganofilas = 0;
            int ganocolumnas = 0;
            int diagonalprincipal = 0;
            int diagonalineversa = 0;
            int tamañogato = 3;
            for(var i=0;i<tamañogato;i++)
            {
                for (var j = 0; j < tamañogato; j++)
                {
                    if(i==fila)//fila
                    {
                        if(gato[i,j]==turno)
                        {
                            ganofilas++;
                        }
                    }
                    if(j==columna)//columnas
                    {
                        if(gato[i,j]==turno)
                        {
                            ganocolumnas++;
                        }
                    }
                    if(i==j)//diagonal principal
                    {
                        if(gato[i,j]==turno)
                        {
                            diagonalprincipal++;
                        }
                    }
                    if((i+j)==(tamañogato-1))//diagonal inversa
                    {
                        if(gato[i,j]==turno)
                        {
                            diagonalineversa++;
                        }
                    }
                }
            }
            if((ganofilas==tamañogato)||(ganocolumnas==tamañogato)||(diagonalineversa==tamañogato)||(diagonalprincipal==tamañogato))
            {
                yahayganador = true;
            }
           
            if(yahayganador==true)
            {
                MessageBox.Show("YA HAY GANADOR");
                PICGANADOR.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turno);
                if(turno==1)
                {
                    pp1++;
                    LBLJ1.Text = pp1.ToString();
                }
                else
                {
                    pp2++;
                    LBLJ2.Text = pp2.ToString();
                }
            }
            
        }
        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿DESEA SALIR DEL JUEGO?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BTNREINICIAR_Click(object sender, EventArgs e)
        {
            IJ();
        }
    }
}
