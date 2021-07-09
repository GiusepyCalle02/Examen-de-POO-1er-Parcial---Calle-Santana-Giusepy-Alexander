using System;
using System.Collections.Generic;

namespace EmpleadoExamen3C
{
    class Program
    {
        static void Main(string[] args)
        {
            //Empleado Administrativo
            EmpleadoAdministrativo empleadmi = new EmpleadoAdministrativo();
            empleadmi.setNombres("Javier Arteaga");
            empleadmi.setApellidos("Pérez López");
            empleadmi.setFacultad("Ciencias Informáticas");
            empleadmi.setCedula(1320345672);
            empleadmi.horasfijasad = 8;
            empleadmi.diasfijoad = 20;

            //Empleada Secretaria
            EmpleadaSecretaria emplesecre = new EmpleadaSecretaria();
            emplesecre.setNombres("Karen Beatriz");
            emplesecre.setApellidos("Triviño Cruz");
            emplesecre.setFacultad("Odontología");
            emplesecre.setCedula(1416287923);
            emplesecre.horasfijassec = 8;
            emplesecre.horasextrassec = 4;
            emplesecre.diastrabajadossec = 18;

            //Empleado Guardia
            EmpleadoGuardia empleguardia = new EmpleadoGuardia();
            empleguardia.setNombres("Dereck Adrian");
            empleguardia.setApellidos("Alcívar Zambrano");
            empleguardia.setFacultad("Ingenieria Industrial");
            empleguardia.setCedula(1416287923);
            empleguardia.horasguardia = 8;
            empleguardia.diasguardia = 22;

            List<Empleado> ListaEmpleados = new List<Empleado>();
            ListaEmpleados.Add(empleadmi);
            ListaEmpleados.Add(emplesecre);
            ListaEmpleados.Add(empleguardia);

            foreach (Empleado empleado in ListaEmpleados)
            {
                empleado.Mensaje();
                empleado.Mostrar();
                empleado.CalculoHorasTrabajadas();
                Console.WriteLine();
            }

        }
    }
}
