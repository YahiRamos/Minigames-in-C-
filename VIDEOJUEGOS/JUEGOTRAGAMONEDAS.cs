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
    public partial class JUEGOTRAGAMONEDAS : Form
    {
        List<PictureBox>
            grupofichasuno = new List<PictureBox>(),
            grupofichasdos = new List<PictureBox>(),
            grupofichastres = new List<PictureBox>();
        int movimientoy = 0, posicionsiguiente, longitudficha, posicionejex = 3;

        private void JUEGOTRAGAMONEDAS_Load(object sender, EventArgs e)
        {
            crearimagenes(grupofichasuno, panel1, "uno");
            crearimagenes(grupofichasdos, panel2, "dos");
            crearimagenes(grupofichastres, panel3, "tres");
        }

        bool indicador1 = false, indicador2 = false, indicador3 = false;

        private void timer3_Tick(object sender, EventArgs e)
        {
            nombreficha3 = girarfichas(grupofichastres, panel3, timer3, indicador3);
            if (nombreficha3 != "")
            {
                btniniciar.Enabled = true;
                if ((numeroficha(nombreficha1) == numeroficha(nombreficha2)) && (numeroficha(nombreficha2) == numeroficha(nombreficha3)))
                {
                    MessageBox.Show("GANASTE :)");
                }
                else
                {
                    MessageBox.Show("PERDISTE :(");
                }
            }
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            indicador1 = false;
            indicador2 = false;
            indicador3 = false;
            timer1.Start();
            btnparar1.Enabled = true;
            btnparar2.Enabled = false;
            btnparar3.Enabled = false;
            btniniciar.Enabled = false;
        }

        private void btnparar2_Click(object sender, EventArgs e)
        {
            indicador2 = true;
            timer3.Start();
            btnparar1.Enabled = false;
            btnparar2.Enabled = false;
            btnparar3.Enabled = true;
        }

        private void btnparar1_Click(object sender, EventArgs e)
        {
            indicador1 = true;
            timer2.Start();
            btnparar1.Enabled = false;
            btnparar2.Enabled = true;
            btnparar3.Enabled = false;
        }

        private void btnparar3_Click(object sender, EventArgs e)
        {
            indicador3 = true;
            btnparar1.Enabled = false;
            btnparar2.Enabled = false;
            btnparar3.Enabled = false;
            btniniciar.Enabled = true;
            if(nombreficha3!="")
            {
                btniniciar.Enabled = true;
                if((numeroficha(nombreficha1)==numeroficha(nombreficha2))&& (numeroficha(nombreficha2)==numeroficha(nombreficha3)))
                {
                    MessageBox.Show("GANASTE :)");
                }
                else
                {
                    MessageBox.Show("PERDISTE :(");
                }
            }
        }

        public int numeroficha(String nombre)
        {
            string[] posicion = nombre.Split("_".ToCharArray());
            return Convert.ToInt32(posicion[1]);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            nombreficha2 = girarfichas(grupofichasdos, panel2, timer2, indicador2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nombreficha1 = girarfichas(grupofichasuno, panel1, timer1, indicador1);
        }

        String nombreficha1 = "", nombreficha2 = "", nombreficha3 = "";
        public JUEGOTRAGAMONEDAS()
        {
            InitializeComponent();
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            btnparar1.Enabled = false;
            btnparar2.Enabled = false;
            btnparar3.Enabled = false;
            MessageBox.Show("OBJETIVO:" + "\n LOGRAR QUE COINCIDAN 3 IMAGENES"+"\n DANDO CLICK EN LOS BOTONES DE PARAR");
            MessageBox.Show("CONTROLES: EL RATON DE LA COMPUTADORA");
        }
        public List<PictureBox> crearimagenes(List<PictureBox> lista, Panel panel, String nombretag)
        {
            longitudficha = 100;
            for (int i = 0; i < 9; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("losflash" + (i + 1));
                pb.Size = new Size(longitudficha, longitudficha);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Name = string.Format("{0}", i + nombretag);
                pb.Tag = nombretag + "_" + i;
                int mov = pb.Location.Y;
                pb.Location = new Point(posicionejex, i * longitudficha);
                lista.Add(pb);
                panel.Controls.Add(lista[i]);
            }
            return lista;
        }
        public String girarfichas(List<PictureBox>lista,Panel panel,Timer timer,bool bandera)
        {
            String fichadeleccionada = "";
            for (int i = 0; i < lista.Count; i++)
            {
                movimientoy = lista[i].Location.Y;
                lista[i].Location = new Point(posicionejex, movimientoy - 10);
                if (lista[i].Location.Y <= -longitudficha)
                {
                    posicionsiguiente = lista[((lista.Count) - 1)].Location.Y;
                    lista[i].Location = new Point(posicionejex, posicionsiguiente + longitudficha);
                    lista.Add(lista[i]);
                    panel.Controls.Add(lista[i]);
                    lista.RemoveAt(i);
                }

                if (bandera)
                {
                    if (lista[i].Location.Y == -10)
                    {
                        timer.Stop();
                        fichadeleccionada = lista[i].Tag.ToString();
                    }
                }
                else
                {
                    fichadeleccionada = "";
                }
                
            }
            return fichadeleccionada;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿DESEA SALIR DEL JUEGO?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
