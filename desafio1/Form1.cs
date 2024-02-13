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
    public partial class frmFichaContacto : Form
    {
        public frmFichaContacto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSexo.Items.Add("Masculino");
            cboSexo.Items.Add("Femenino");
        }

        private void btnEnviarFormulario_Click(object sender, EventArgs e)
        {
            Persona p1 = new Persona();
            p1.Nombre = txtNombre.Text;
            p1.Sexo = cboSexo.SelectedItem.ToString();
            p1.Edad = numEdad.Value.ToString();
            p1.Correo = txtCorreo.Text;
            p1.Estudios = txtEstudios.Text;
            p1.Celular = txtCelular.Text;
            p1.Hobbit = txtHobbit.Text;
            MessageBox.Show("Nombre: " + p1.Nombre + ", Sexo: " + p1.Sexo + ", Edad: " + p1.Edad + ", Correo: " + p1.Correo + ", Estudios: " + p1.Estudios + ", Celular: " + p1.Celular + ", Hobbits: " + p1.Hobbit + '.');

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            Persona p1 = new Persona();
            p1.Nombre = txtNombre.Text;
            p1.Sexo = cboSexo.SelectedItem.ToString();
            p1.Edad = numEdad.Value.ToString();
            p1.Correo = txtCorreo.Text;
            p1.Estudios = txtEstudios.Text;
            p1.Celular = txtCelular.Text;
            p1.Hobbit = txtHobbit.Text;
            MessageBox.Show(p1.saludar());
        }

        private void btnVerificarCelular_Click(object sender, EventArgs e)
        {
            Persona p1 = new Persona();
            p1.Nombre = txtNombre.Text;
            p1.Sexo = cboSexo.SelectedItem.ToString();
            p1.Edad = numEdad.Value.ToString();
            p1.Correo = txtCorreo.Text;
            p1.Estudios = txtEstudios.Text;
            p1.Celular = txtCelular.Text;
            p1.Hobbit = txtHobbit.Text;
            MessageBox.Show(p1.verificarCelular());
        }
    }
}
