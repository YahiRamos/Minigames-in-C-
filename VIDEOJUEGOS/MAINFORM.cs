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
    public partial class MAINFORM : Form
    {
        public MAINFORM()
        {
            InitializeComponent();
            timer.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿DESEA SALIR DE LOS JUEGOS?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Close();
            }
        }

        private void aCERCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMACERCADE ACERCADE = new FRMACERCADE();
            ACERCADE.Show(this);
        }

        private void fLAPPYBIRDToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void eSFERASDELDRAGÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JUEGOESFERASDELDRAGON DBZ = new JUEGOESFERASDELDRAGON();
            DBZ.Show(this);
        }

        private void sNAKEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JUEGODESNAKE SNAKE = new JUEGODESNAKE();
            SNAKE.Show(this);
        }

        private void mEMORAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JUEGOMEMORAMA MEMORAMA = new JUEGOMEMORAMA();
            MEMORAMA.Show(this);
        }

        private void tRAGAMONEDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JUEGOTRAGAMONEDAS TRAGAMONEDAS = new JUEGOTRAGAMONEDAS();
            TRAGAMONEDAS.Show(this);
        }

        private void eLGATITOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JUEGOGATITO GATITO = new JUEGOGATITO();
            GATITO.Show(this);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labeldatatime.Text = DateTime.Now.ToString();
        }
    }
}
