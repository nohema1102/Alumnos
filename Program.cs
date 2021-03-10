using System;
using System.Collections.Generic;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alumnos = persona
            Persona persona1 = new Persona("Nohemí ", "Santiago ", "Vazquez");


            persona1.Presentarse();
            Console.WriteLine(persona1.NombreCompleto);

            //No funciona porque no tiene set
            //alumnos1.NombreCompleto = "Nombre Apellido"

            persona1.primerApellido = "Lopez ";
            Console.WriteLine(persona1.NombreCompleto);
            persona1.Presentarse();

            persona1.ColorFavorito = "Azul";

            //Alumno
            Alumno alumno1 = new Alumno("Pedro", "Martinez ", "López", 273618);
            Console.WriteLine("Alumno #1: " + alumno1.NombreCompleto);

            //Materias
           Materia programacionI = new Materia ("programación I ", 2);
           Console.WriteLine("La materia de " + programacionI.nombreDeLamateria + "se ve en " + programacionI.semestre);

            Materia inteligenciaArtifical = new Materia ("Inteligencia Artificial ", 7);
            Console.WriteLine("La materia de " + inteligenciaArtifical.nombreDeLamateria + "se ve en " + inteligenciaArtifical.semestre);

            //lista
            //- <> operados diamante
            //- <Materia> contiene Materias
            //- Requiere inicializacion

            List<Materia> materiasDeInteres = new List<Materia>();
            
            materiasDeInteres.Remove(programacionI);
            materiasDeInteres.Add(inteligenciaArtifical);
            materiasDeInteres.Add(new Materia("Sistemas Inrativos I", 7));
            //materiasDeInteres[2]

            Console.WriteLine("La materia de " + materiasDeInteres[0].nombreDeLamateria + " se ve en " + materiasDeInteres[2].nombreSemestre);
            Console.WriteLine("Me interesan " + materiasDeInteres.Count  + " materias");
           
           for (int i = 0; i < materiasDeInteres.Count; i++)
           {
               Console.WriteLine(materiasDeInteres[i].nombreDeLamateria);
           }
        
        
        }
    }
}
