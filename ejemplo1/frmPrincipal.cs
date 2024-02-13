using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Evaluamos las ventanas del tipo Form1 para no permitir que se abra más de 1 vez
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1)) 
                {
                    MessageBox.Show("Ya existe esta pestaña abierta, termine de trabajar allí");
                    return; // podemos poner esto solo directamente
                }
            }
            // La pestaña emergente se abre en la pestaña principal
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            // La pestaña emergente se abre de manera independiente ded la principal, no permitiendo modificar la principal hasta finiquitar con la secundaria
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }
    }
}
