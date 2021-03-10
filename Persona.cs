using System;

namespace Persona
{
    class Persona
    {
       public string nombre;
       public string primerApellido; 
       public string segundoApellido;
//propiedad
// -Public, en c# empieza con mayuscula y tiene get y/o get 
//(getter y/o setter)
//No es un metodo si no tiene parentesis
       public string NombreCompleto
       {
           get => this.nombre + " " + this.primerApellido + 
           this.segundoApellido;

       }
       private string colorFavorito;
       
       public string ColorFavorito
       {
           get => this.colorFavorito;
           //-value- está disponible dentro del set
           //quiere decir el valor que se va a asignar
           //get - consultar set- modificar
           set => this.colorFavorito = value;
       }
      
       public Persona(string nombre, string primerApellido, string segundoApellido)
       {
           this.nombre = nombre;
           this.primerApellido = primerApellido;
           this.segundoApellido = segundoApellido;
           
       }
       public virtual void Presentarse()
       {
           Console.WriteLine("Hola, me llamo " + this.nombre + this.primerApellido + this.segundoApellido);
       }
    }
}