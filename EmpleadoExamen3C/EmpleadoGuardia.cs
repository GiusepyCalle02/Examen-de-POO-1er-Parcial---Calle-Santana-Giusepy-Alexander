using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoExamen3C
{
    public class EmpleadoGuardia:Empleado
    {
        //Propiedades
        public int horasguardia;
        public int diasguardia;
        public double horastotalesguardia;

        public int getHorasGuardia()
        {
            return horasguardia;
        }
        public void setHorasGuardia(int horasguardia)
        {
            this.horasguardia = horasguardia;
        }


        public int getDiasGuardia()
        {
            return diasguardia;
        }
        public void setDiasGuardia(int diasguardia)
        {
            this.diasguardia = diasguardia;
        }

        public override void Mensaje()
        {
            Console.WriteLine("Datos del Empleado Guardia");
        }

        public override void CalculoHorasTrabajadas()
        {
            horastotalesguardia = horasguardia  * diasguardia;

            Console.WriteLine("Las horas registradas por sistema: {0}; La cantidad de dias trabajados: {1}; Horas Totales trabajadas en el mes: {2}", horasguardia, diasguardia, horastotalesguardia);
        }
    }
}
