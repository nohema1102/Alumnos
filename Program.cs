using System;

namespace Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumnos alumnos1 = new Alumnos("Nohemí ", "Santiago ", "Vazquez");


            alumnos1.Presentarse();
            Console.WriteLine(alumnos1.NombreCompleto);

            //No funciona porque no tiene set
            //alumnos1.NombreCompleto = "Nombre Apellido"

            alumnos1.primerApellido = "Lopez ";
            Console.WriteLine(alumnos1.NombreCompleto);
            alumnos1.Presentarse();

            alumnos1.ColorFavorito = "Azul";
        }
    }
}
