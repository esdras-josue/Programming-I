using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante
{
    internal class Estudiante
    {
        private string nombre;
        private int edad;
        private int grado;
        private double promedio;
        private string estatus;
        private int calificaciones;
        
        public string Nombre {get; set;}
        public int Edad {get; set;}  
        public int Grado {get; set;}
        public int Promedio { get; set;}
       
        public int Calificaciones
        {
            get
            {
                return this.calificaciones;
            }
            set
            {
                if (value >= 70)
                {
                    this.estatus = "Aprobado";
                }
                else if(value < 70)
                {
                    this.estatus = "Reprobado";
                }

                this.calificaciones = value;
            }
            
        }

        public string Estatus
        {
            get
            {
                return this.estatus;
            }
        }
        public double IncrementarPromedio(double incremento)
        {
            this.promedio = incremento;
            return this.promedio;
        }
       
    }
}
