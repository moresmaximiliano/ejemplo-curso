namespace desafio1
{
    partial class frmBienvenidos
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
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.lblAtte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.Location = new System.Drawing.Point(52, 179);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(736, 51);
            this.lblBienvenidos.TabIndex = 0;
            this.lblBienvenidos.Text = "BIENVENIDOS A LA CONVOCATORIA";
            // 
            // lblAtte
            // 
            this.lblAtte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAtte.AutoSize = true;
            this.lblAtte.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtte.Location = new System.Drawing.Point(274, 327);
            this.lblAtte.Name = "lblAtte";
            this.lblAtte.Size = new System.Drawing.Size(293, 23);
            this.lblAtte.TabIndex = 1;
            this.lblAtte.Text = "LES DESEA SUERTE LA COMPAÑÍA";
            // 
            // frmBienvenidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(849, 454);
            this.Controls.Add(this.lblAtte);
            this.Controls.Add(this.lblBienvenidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(865, 493);
            this.Name = "frmBienvenidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Label lblAtte;
    }
}