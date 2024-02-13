namespace desafio1
{
    partial class frmPantallaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bienvenidosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rellenarFichaDeContactoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.spbProgresoAño = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bienvenidosToolStripMenuItem1,
            this.rellenarFichaDeContactoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(545, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bienvenidosToolStripMenuItem1
            // 
            this.bienvenidosToolStripMenuItem1.Name = "bienvenidosToolStripMenuItem1";
            this.bienvenidosToolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.bienvenidosToolStripMenuItem1.Text = "&Bienvenidos";
            this.bienvenidosToolStripMenuItem1.Click += new System.EventHandler(this.bienvenidosToolStripMenuItem1_Click);
            // 
            // rellenarFichaDeContactoToolStripMenuItem1
            // 
            this.rellenarFichaDeContactoToolStripMenuItem1.Name = "rellenarFichaDeContactoToolStripMenuItem1";
            this.rellenarFichaDeContactoToolStripMenuItem1.Size = new System.Drawing.Size(156, 20);
            this.rellenarFichaDeContactoToolStripMenuItem1.Text = "&Rellenar ficha de contacto";
            this.rellenarFichaDeContactoToolStripMenuItem1.Click += new System.EventHandler(this.rellenarFichaDeContactoToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssFecha,
            this.spbProgresoAño});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(545, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssFecha
            // 
            this.tssFecha.Name = "tssFecha";
            this.tssFecha.Size = new System.Drawing.Size(152, 17);
            this.tssFecha.Text = "jueves, 1 de febrero de 2024";
            // 
            // spbProgresoAño
            // 
            this.spbProgresoAño.Name = "spbProgresoAño";
            this.spbProgresoAño.Size = new System.Drawing.Size(100, 16);
            this.spbProgresoAño.Value = 8;
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 436);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(561, 475);
            this.Name = "frmPantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Herramientas del Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bienvenidosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rellenarFichaDeContactoToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssFecha;
        private System.Windows.Forms.ToolStripProgressBar spbProgresoAño;
    }
}