using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_CAI.Entidades
{
    public abstract class Persona // Una clase abstracta no puede ser privada, ya que debe ser heredada y deben poder acceder.
                                  // La clase abstracta nunca se va a instanciar, sólo se usa para ser accedida por las clases hijas.
    {
        // ATRIBUTOS    
        private string _nombre;     // No se puede acceder directamente al atributo, pero se puede hacer desde las propiedades.
        private string _apellido;
        private DateTime _fechaNac;

        // PROPIEDADES
        protected string Nombre { get => _nombre; set => _nombre = value; } // Acceder desde las propiedades permite una manipulación sobre la escritura de los atributos
        protected string Apellido { get => _apellido; set => _apellido = value; }
        protected DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }

        // MÉTODOS
        protected abstract void GetCredencial();  // Como es una clase abstracta, nunca se va a instanciar y lo que sirve es que sean protected para que puedan acceder los hijos. 
                                                  // No se declara el método abstracto, no se utilizan llaves. Obliga a los hijos a implementarlo a su manera.

        protected virtual void GetNombreCompleto()  // El virtual es una implementación por default, que luego puede o no ser modificada.
        {
            
            
        }

        protected void GetSaludoInformal()  // Implementación forzosa para los hijos.
        {

        }
    }

}
