using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Rectangulo
    {
        public int base1;
        public int altura;

        //En .net el constructor por defecto viene de forma de automática
        //Constructor por defecto
        //public Rectangulo()
        //{

        //}
        public int CalcularArea()

        {
            return base1 * altura;
        }
        public int CalcularPerimetro()
        {
            return (base1 + altura) * 2;
        }
    }
}
