using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_CAI.Entidades
{
    public abstract class Empleado : Persona
    {
        // ATRIBUTOS
        private int _legajo;
        private DateTime _fechaIngreso;

        // PROPIEDADES
        private int Legajo { get => _legajo; set => _legajo = value; }
        private DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }

        // PROPIEDADES HEREDADAS
        public DateTime FechaNacimiento { get => FechaNac; set => FechaNac = value; }

        // PROPIEDADES CUSTOM
        public int Antiguedad { get => (DateTime.Now - _fechaIngreso).Days / 365; }

        // MÉTODOS
        protected override void GetCredencial()     // Se hace un override del método abstracto de Persona
        {

        }

        protected abstract string ListarEmpleados(bool listarConId);
    }
}
