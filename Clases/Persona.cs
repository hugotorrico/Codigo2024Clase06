using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
     public class Persona
    {
        private string Nombres;
        private string Apellidos;

        //Constructor: Función que tiene el mismo nombre de la clase 
        // y que no retorna nada
        public Persona()
        {

        }
        //Los constructores me permiten crear objetos de forma diferentes
        //Constructor con parámetros
        public Persona(string nombres, string apellidos)
        {
            Nombres= nombres;
            Apellidos= apellidos;
        }

        public void RenombarNombres(string nombres)
        {
            Nombres = nombres;
        }


        public string RetornarNombresCompletos()
        {
            return Nombres + " " + Apellidos;
        }
    }
}
