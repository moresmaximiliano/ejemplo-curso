using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio1
{
    public partial class frmPantallaPrincipal : Form
    {
        public frmPantallaPrincipal()
        {
            // agregamos un comentario para el GitHub
            InitializeComponent();
        }

        private void bienvenidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Configuramos para que se abra en el misma pestaña inicial
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmBienvenidos))   
                {
                    MessageBox.Show("Ya existe una pestaña abierta de este tipo");
                    return;
                }
            }
            frmBienvenidos ventanaBienvenidos = new frmBienvenidos();
            ventanaBienvenidos.MdiParent = this;
            ventanaBienvenidos.Show();
        }

        private void rellenarFichaDeContactoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmFichaContacto))
                {
                    MessageBox.Show("Ya existe una pestaña abierta de este tipo, termine de trabajar con ella.");
                    return;
                }
            }
            frmFichaContacto ventanaFichaContacto = new frmFichaContacto();
            ventanaFichaContacto.Show();
        }
    }
}
