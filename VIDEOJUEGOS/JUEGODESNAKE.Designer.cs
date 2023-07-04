namespace VIDEOJUEGOS
{
    partial class JUEGODESNAKE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LBLPUNTOS = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LBLPUNTOS
            // 
            this.LBLPUNTOS.AutoSize = true;
            this.LBLPUNTOS.BackColor = System.Drawing.Color.Transparent;
            this.LBLPUNTOS.Location = new System.Drawing.Point(555, 13);
            this.LBLPUNTOS.Name = "LBLPUNTOS";
            this.LBLPUNTOS.Size = new System.Drawing.Size(35, 13);
            this.LBLPUNTOS.TabIndex = 3;
            this.LBLPUNTOS.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // JUEGODESNAKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VIDEOJUEGOS.Properties.Resources.fondosnake;
            this.ClientSize = new System.Drawing.Size(619, 485);
            this.Controls.Add(this.LBLPUNTOS);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "JUEGODESNAKE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JUEGODESNAKE";
            this.Load += new System.EventHandler(this.JUEGODESNAKE_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JUEGODESNAKE_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBLPUNTOS;
        private System.Windows.Forms.Timer timer1;
    }
}