using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_CAI.Entidades
{
    public abstract class Persona // Una clase abstracta no puede ser privada, ya que debe ser heredada y deben poder acceder.
    {
        // ATRIBUTOS    
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNac;

        protected string Nombre { get => _nombre; set => _nombre = value; }
        protected string Apellido { get => _apellido; set => _apellido = value; }
        protected DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }
    }
}
