using System;

namespace Alumnos
{
    //Alumno extiende la calse persona(alumnos)
    //Alumnos es la clase base de Alumno 
    class Alumno : Alumnos 
    {

        public int matricula;
        static public string escuela = "CRESP";
        public Alumno(string nombre, string primerApellido, string segundoApellido, int matricula) : base(nombre, primerApellido, segundoApellido)
        {
            this.matricula = matricula;
        }
        public override void Presentarse()
        {
            Console.WriteLine("Hola, ni nombre es " + this.NombreCompleto + "y soy estudiante en " + Alumno.escuela + "con matrícula" + this.matricula); 
        }
    }
}