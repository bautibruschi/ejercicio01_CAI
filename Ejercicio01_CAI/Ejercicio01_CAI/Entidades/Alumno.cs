using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_CAI.Entidades
{
    public class Alumno : Persona
    {
        private int _codigo;

        public int Codigo { get => _codigo; set => _codigo = value; }

        protected override void GetCredencial()
        {

        }
    }
}
