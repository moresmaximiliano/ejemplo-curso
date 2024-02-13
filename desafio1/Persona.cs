using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Persona
    {
        // Propiedades 
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public string Edad { get; set; }
        public string Correo { get; set; }
        public string Estudios { get; set; }
        public string Celular { get; set; }
        public string Hobbit { get; set; }

        // Métodos
        public string saludar()
        {
            return "Hola " + Nombre;
        }
        public string verificarCelular()
        {
            return "Enviando mensaje de confirmación al número " + Celular;
        }
    }
}
