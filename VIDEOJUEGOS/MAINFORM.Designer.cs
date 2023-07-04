namespace VIDEOJUEGOS
{
    partial class MAINFORM
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAINFORM));
            this.mainmenu = new System.Windows.Forms.MenuStrip();
            this.eLGATITOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMORAMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sNAKEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSFERASDELDRAGÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRAGAMONEDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCERCAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.labeldatatime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mainmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainmenu
            // 
            this.mainmenu.BackColor = System.Drawing.Color.IndianRed;
            this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eLGATITOToolStripMenuItem,
            this.mEMORAMAToolStripMenuItem,
            this.sNAKEToolStripMenuItem,
            this.eSFERASDELDRAGÓNToolStripMenuItem,
            this.tRAGAMONEDASToolStripMenuItem,
            this.aCERCAToolStripMenuItem,
            this.toolStripMenuItem1});
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(984, 24);
            this.mainmenu.TabIndex = 0;
            this.mainmenu.Text = "mainmenu";
            // 
            // eLGATITOToolStripMenuItem
            // 
            this.eLGATITOToolStripMenuItem.Name = "eLGATITOToolStripMenuItem";
            this.eLGATITOToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.eLGATITOToolStripMenuItem.Text = "&EL GATITO";
            this.eLGATITOToolStripMenuItem.Click += new System.EventHandler(this.eLGATITOToolStripMenuItem_Click);
            // 
            // mEMORAMAToolStripMenuItem
            // 
            this.mEMORAMAToolStripMenuItem.Name = "mEMORAMAToolStripMenuItem";
            this.mEMORAMAToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.mEMORAMAToolStripMenuItem.Text = "&MEMORAMA";
            this.mEMORAMAToolStripMenuItem.Click += new System.EventHandler(this.mEMORAMAToolStripMenuItem_Click);
            // 
            // sNAKEToolStripMenuItem
            // 
            this.sNAKEToolStripMenuItem.Name = "sNAKEToolStripMenuItem";
            this.sNAKEToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.sNAKEToolStripMenuItem.Text = "&SNAKE";
            this.sNAKEToolStripMenuItem.Click += new System.EventHandler(this.sNAKEToolStripMenuItem_Click);
            // 
            // eSFERASDELDRAGÓNToolStripMenuItem
            // 
            this.eSFERASDELDRAGÓNToolStripMenuItem.Name = "eSFERASDELDRAGÓNToolStripMenuItem";
            this.eSFERASDELDRAGÓNToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.eSFERASDELDRAGÓNToolStripMenuItem.Text = "&POKEBOLAS CAEN";
            this.eSFERASDELDRAGÓNToolStripMenuItem.Click += new System.EventHandler(this.eSFERASDELDRAGÓNToolStripMenuItem_Click);
            // 
            // tRAGAMONEDASToolStripMenuItem
            // 
            this.tRAGAMONEDASToolStripMenuItem.Name = "tRAGAMONEDASToolStripMenuItem";
            this.tRAGAMONEDASToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.tRAGAMONEDASToolStripMenuItem.Text = "&TRAGAMONEDAS";
            this.tRAGAMONEDASToolStripMenuItem.Click += new System.EventHandler(this.tRAGAMONEDASToolStripMenuItem_Click);
            // 
            // aCERCAToolStripMenuItem
            // 
            this.aCERCAToolStripMenuItem.Name = "aCERCAToolStripMenuItem";
            this.aCERCAToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.aCERCAToolStripMenuItem.Text = "&ACERCA DE ";
            this.aCERCAToolStripMenuItem.Click += new System.EventHandler(this.aCERCAToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(828, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeldatatime
            // 
            this.labeldatatime.AutoSize = true;
            this.labeldatatime.BackColor = System.Drawing.Color.IndianRed;
            this.labeldatatime.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldatatime.Location = new System.Drawing.Point(804, 29);
            this.labeldatatime.Name = "labeldatatime";
            this.labeldatatime.Size = new System.Drawing.Size(44, 20);
            this.labeldatatime.TabIndex = 2;
            this.labeldatatime.Text = "fecha";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MAINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::VIDEOJUEGOS.Properties.Resources.orig_81167;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 512);
            this.Controls.Add(this.labeldatatime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainmenu;
            this.MaximizeBox = false;
            this.Name = "MAINFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIDEOJUEGOS (COMPILACIÓN)";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mainmenu.ResumeLayout(false);
            this.mainmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainmenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem aCERCAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eSFERASDELDRAGÓNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sNAKEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEMORAMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRAGAMONEDASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLGATITOToolStripMenuItem;
        private System.Windows.Forms.Label labeldatatime;
        private System.Windows.Forms.Timer timer;
    }
}

