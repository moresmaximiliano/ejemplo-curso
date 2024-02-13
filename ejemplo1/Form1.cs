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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            // Operador ternario: IF en una linea
            string chocolate = ckbChocolate.Checked == true ? "le gusta el chocolate" : "odia el chocolate";
            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";
            string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            string NumeroFavorito = numNumeroFavorito.Value.ToString();
            string mensaje = "Su nombre es " + nombre + ", su fecha de nacimiento es " + fecha + ", " + chocolate + ", es un " + tipo + ", su color favorito es el " + colorFavorito + ", y su número favorito es el " + NumeroFavorito;
            MessageBox.Show(mensaje);
        }
    }
}
