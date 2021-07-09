using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoExamen3C
{
    public abstract class Empleado
    {
        //Propiedades
        private string nombres;
        private string apellidos;
        private string facultad;
        private int cedula;

        public string getNombres()
        {
            return nombres;
        }
        public void setNombres(string nombres)
        {
            this.nombres = nombres;
        }


        public string getApellidos()
        {
            return apellidos;
        }
        public void setApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }


        public string getFacultad()
        {
            return facultad;
        }
        public void setFacultad(string facultad)
        {
            this.facultad = facultad;
        }


        public int getCedula()
        {
            return cedula;
        }
        public void setCedula(int cedula)
        {
            this.cedula = cedula;
        }

        //Método para mostrar Datos
        public void Mostrar()
        {
            Console.WriteLine("Nombres: {0}; Apellidos: {1}; Facultad donde labora: {2}; Cédula: {3}", nombres, apellidos, facultad, cedula);
        }

        public abstract void CalculoHorasTrabajadas();

        public abstract void Mensaje();
    }
}
