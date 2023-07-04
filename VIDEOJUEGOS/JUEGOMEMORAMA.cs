using System;
using System.Collections;
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
    public partial class JUEGOMEMORAMA : Form
    {
        int tamañodecolumnasfilas = 4;
        int movimientos = 0;
        int cantidadcartasvolteadas = 0;
        List<string> cartasenumeradas;
        List<string> cartasrevueltas;
        ArrayList cartasseleccionadas;
        PictureBox cartatemporal1;
        PictureBox cartatemporal2;
        int cartaactual=0;

        public JUEGOMEMORAMA()
        {
            InitializeComponent();
            IJ();
            MessageBox.Show("OBJETIVO:" + "\n ENCONTRAR EL PAR DE TODAS LAS CARTAS");
            MessageBox.Show("CONTROLES: EL RATON DE LA COMPUTADORA");
        }

        //funcion para iniciar juego
        public void IJ()
        {
            timer1.Enabled = false;
            timer1.Stop();
            NUMERODERECORD.Text = "0";
            cantidadcartasvolteadas = 0;
            movimientos = 0;
            paneljuego.Controls.Clear();
            cartasenumeradas = new List<string>();
            cartasrevueltas = new List<string>();
            cartasseleccionadas = new ArrayList();
            for (int i = 0; i < 8; i++)
            {
                cartasenumeradas.Add(i.ToString());
                cartasenumeradas.Add(i.ToString());
            }
            var numeroaleatorio = new Random();
            var resultado = cartasenumeradas.OrderBy(item => numeroaleatorio.Next());
            foreach(string valorcarta in resultado)
            {
                cartasrevueltas.Add(valorcarta);
            }
            var tablapanel = new TableLayoutPanel();
            tablapanel.RowCount = tamañodecolumnasfilas;
            tablapanel.ColumnCount = tamañodecolumnasfilas;
            for (int i = 0; i < tamañodecolumnasfilas; i++) 
            {
                var porcentaje = 150f / (float)tamañodecolumnasfilas - 10;
                tablapanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,porcentaje));
                tablapanel.RowStyles.Add(new RowStyle(SizeType.Percent, porcentaje));
            }
            int contadordefichas = 1;
            for (var i = 0; i < tamañodecolumnasfilas; i++)
            {
                for (var j = 0; j < tamañodecolumnasfilas; j++)
                {
                    var cartasjuego = new PictureBox();
                    cartasjuego.Name = string.Format("{0}", contadordefichas);
                    cartasjuego.Dock = DockStyle.Fill;
                    cartasjuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    cartasjuego.Image = Properties.Resources.fireemblem;
                    cartasjuego.Cursor = Cursors.Hand;
                    cartasjuego.Click += BTNCARTA_Click;
                    tablapanel.Controls.Add(cartasjuego, j, i);
                    contadordefichas++;
                }
            }
            tablapanel.Dock = DockStyle.Fill;
            paneljuego.Controls.Add(tablapanel);
        }
        //funcion para iniciar el juego(termina aqui)
        private void BTNCARTA_Click(object sender, EventArgs e)
        {
            if (cartasseleccionadas.Count < 2)
            {
                  
                movimientos++;
                NUMERODERECORD.Text = Convert.ToString(movimientos);
                var cartaseleccionadausuario = (PictureBox)sender;
                cartaactual = Convert.ToInt32(cartasrevueltas[Convert.ToInt32(cartaseleccionadausuario.Name) - 1]);
                cartaseleccionadausuario.Image = recuperarimagen(cartaactual);
                cartasseleccionadas.Add(cartaseleccionadausuario);
                //ya se realizo el evento click 2 veces
                if(cartasseleccionadas.Count==2)
                {
                    cartatemporal1 = (PictureBox)cartasseleccionadas[0];
                    cartatemporal2 = (PictureBox)cartasseleccionadas[1];
                    int carta1 = Convert.ToInt32(cartasrevueltas[Convert.ToInt32(cartatemporal1.Name) - 1]);
                    int carta2 = Convert.ToInt32(cartasrevueltas[Convert.ToInt32(cartatemporal2.Name) - 1]);
                    if(carta1!=carta2)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        cantidadcartasvolteadas++;
                        if(cantidadcartasvolteadas>7)
                        {
                            MessageBox.Show("EL JUEGO TERMINÓ");
                        }
                        cartatemporal1.Enabled = false;
                        cartatemporal2.Enabled = false;
                        cartasseleccionadas.Clear();
                    }
                }
            }
        }
        public Bitmap recuperarimagen(int numeroimagen)
        {
            Bitmap tmpimg = new Bitmap(200, 100);
            switch (numeroimagen)
            {
                case 0:tmpimg = Properties.Resources.img11;
                    break;
                default:tmpimg = (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + numeroimagen);
                    break;
            }
            return tmpimg;
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
            IJ();//funcion para iniciar el juego
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            int tiempovirarcarta = 1;
            if(tiempovirarcarta==1)
            {
                cartatemporal1.Image = Properties.Resources.fireemblem;
                cartatemporal2.Image = Properties.Resources.fireemblem;
                cartasseleccionadas.Clear();
                tiempovirarcarta = 0;
                timer1.Stop();
            }
        }
    }
}
