using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoExamen3C
{
    public class EmpleadoAdministrativo:Empleado
    {
        //Propiedades
        public int horasfijasad;
        public int diasfijoad;
        public double horastotalesad;

        public int getHorasFijasAd ()
        {
            return horasfijasad;
        }
        public void setHorasFijasAd(int horasfijasad)
        {
            this.horasfijasad = horasfijasad;
        }


        public int getDiasFijoAd()
        {
            return diasfijoad;
        }
        public void setDiasFijoAd(int diasfijoad)
        {
            this.diasfijoad = diasfijoad;
        }

        public override void Mensaje()
        {
            Console.WriteLine("Datos del Empleado Administrativo");
        }

        public override void CalculoHorasTrabajadas()
        {
            horastotalesad = horasfijasad * diasfijoad;

            Console.WriteLine("La cantidad de horas fijas diarias: {0}; La cantidad de días fijo: {1}; Las horas totales trabajadas en el mes: {2}", horasfijasad, diasfijoad, horastotalesad);
        }
    }
}
