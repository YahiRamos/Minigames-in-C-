namespace VIDEOJUEGOS
{
    partial class JUEGOESFERASDELDRAGON
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblrecord = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.Color.Transparent;
            this.BTNSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSALIR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNSALIR.Location = new System.Drawing.Point(284, 12);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(48, 39);
            this.BTNSALIR.TabIndex = 2;
            this.BTNSALIR.TabStop = false;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.UseVisualStyleBackColor = false;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblrecord
            // 
            this.lblrecord.AutoSize = true;
            this.lblrecord.BackColor = System.Drawing.Color.Transparent;
            this.lblrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecord.Location = new System.Drawing.Point(24, 25);
            this.lblrecord.Name = "lblrecord";
            this.lblrecord.Size = new System.Drawing.Size(30, 31);
            this.lblrecord.TabIndex = 3;
            this.lblrecord.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VIDEOJUEGOS.Properties.Resources.pong1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 416);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // JUEGOESFERASDELDRAGON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VIDEOJUEGOS.Properties.Resources.fpndopokemon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblrecord);
            this.Controls.Add(this.BTNSALIR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JUEGOESFERASDELDRAGON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JUEGOESFERASDELDRAGON";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cambiardecolor);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblrecord;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}