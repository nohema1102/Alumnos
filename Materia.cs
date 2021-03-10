using System;

namespace Persona
{
    class Materia
    {
        public string nombreDeLamateria;
        public int semestre;
        public string nombreSemestre
        {
            //get => semestre + "o. semestre";
            get => TransformarSemestreATexto() + "semestre"; //"4to semestre"
        }

        public Materia(string nombreDeLamateria, int semestre)
        {
            this.nombreDeLamateria = nombreDeLamateria;
            this.semestre = semestre;
        }
       private string TransformarSemestreATexto()
        {
            if (this.semestre ==1)
            {
                return "1er";
            }
            else if (this.semestre ==2)
            {
                return "2do";
            }
            else if (this.semestre ==3)
            {
                return "3er";
            }
            else if (this.semestre ==7)
            {
                return "7mo.";
            }
            else if (this.semestre ==8)
            {
                return "8vo.";
            }
            else 
            {
                return "to.";
            }
        }
    }
}