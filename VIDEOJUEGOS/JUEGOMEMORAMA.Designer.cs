namespace VIDEOJUEGOS
{
    partial class JUEGOMEMORAMA
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
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.paneljuego = new System.Windows.Forms.GroupBox();
            this.BTNREINICIAR = new System.Windows.Forms.Button();
            this.LBLRECORD = new System.Windows.Forms.Label();
            this.NUMERODERECORD = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.Color.Transparent;
            this.BTNSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSALIR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNSALIR.Location = new System.Drawing.Point(566, 485);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(144, 60);
            this.BTNSALIR.TabIndex = 2;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.UseVisualStyleBackColor = false;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // paneljuego
            // 
            this.paneljuego.BackColor = System.Drawing.Color.Transparent;
            this.paneljuego.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paneljuego.Location = new System.Drawing.Point(13, 13);
            this.paneljuego.Name = "paneljuego";
            this.paneljuego.Size = new System.Drawing.Size(530, 660);
            this.paneljuego.TabIndex = 3;
            this.paneljuego.TabStop = false;
            // 
            // BTNREINICIAR
            // 
            this.BTNREINICIAR.BackColor = System.Drawing.Color.Transparent;
            this.BTNREINICIAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNREINICIAR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNREINICIAR.Location = new System.Drawing.Point(566, 409);
            this.BTNREINICIAR.Name = "BTNREINICIAR";
            this.BTNREINICIAR.Size = new System.Drawing.Size(144, 60);
            this.BTNREINICIAR.TabIndex = 4;
            this.BTNREINICIAR.Text = "REINICIAR JUEGO";
            this.BTNREINICIAR.UseVisualStyleBackColor = false;
            this.BTNREINICIAR.Click += new System.EventHandler(this.BTNREINICIAR_Click);
            // 
            // LBLRECORD
            // 
            this.LBLRECORD.AutoSize = true;
            this.LBLRECORD.BackColor = System.Drawing.Color.Transparent;
            this.LBLRECORD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBLRECORD.Location = new System.Drawing.Point(563, 107);
            this.LBLRECORD.Name = "LBLRECORD";
            this.LBLRECORD.Size = new System.Drawing.Size(53, 13);
            this.LBLRECORD.TabIndex = 5;
            this.LBLRECORD.Text = "RECORD";
            // 
            // NUMERODERECORD
            // 
            this.NUMERODERECORD.AutoSize = true;
            this.NUMERODERECORD.BackColor = System.Drawing.Color.Transparent;
            this.NUMERODERECORD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NUMERODERECORD.Location = new System.Drawing.Point(642, 107);
            this.NUMERODERECORD.Name = "NUMERODERECORD";
            this.NUMERODERECORD.Size = new System.Drawing.Size(13, 13);
            this.NUMERODERECORD.TabIndex = 6;
            this.NUMERODERECORD.Text = "()";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // JUEGOMEMORAMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VIDEOJUEGOS.Properties.Resources._712181;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 685);
            this.Controls.Add(this.NUMERODERECORD);
            this.Controls.Add(this.LBLRECORD);
            this.Controls.Add(this.BTNREINICIAR);
            this.Controls.Add(this.paneljuego);
            this.Controls.Add(this.BTNSALIR);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JUEGOMEMORAMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JUEGOMEMORAMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.GroupBox paneljuego;
        private System.Windows.Forms.Button BTNREINICIAR;
        private System.Windows.Forms.Label LBLRECORD;
        private System.Windows.Forms.Label NUMERODERECORD;
        private System.Windows.Forms.Timer timer1;
    }
}