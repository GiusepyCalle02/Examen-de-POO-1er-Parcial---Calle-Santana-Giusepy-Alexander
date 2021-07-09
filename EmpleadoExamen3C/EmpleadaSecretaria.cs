using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoExamen3C
{
    public class EmpleadaSecretaria:Empleado
    {
        //Propiedades

        public int horasfijassec;
        public int horasextrassec;
        public int diastrabajadossec;
        public double horastotalessec;

        public int getHorasFijasSec()
        {
            return horasfijassec;
        }
        public void setHorasFijasSec(int horasfijassec)
        {
            this.horasfijassec = horasfijassec;
        }


        public int getHorasExtrasSec()
        {
            return horasextrassec;
        }
        public void setHorasExtrasSec(int horasextrassec)
        {
            this.horasextrassec = horasextrassec;
        }


        public int getDiasTrabajadosSec()
        {
            return diastrabajadossec;
        }
        public void setDiasTrabajadosSec(int diastrabajadossec)
        {
            this.diastrabajadossec = diastrabajadossec;
        }

        public override void Mensaje()
        {
            Console.WriteLine("Datos de la empleada Secretaria");
        }

        public override void CalculoHorasTrabajadas()
        {
            horastotalessec = (horasfijassec + horasextrassec)*diastrabajadossec;

            Console.WriteLine("Las horas fijas trabajadas: {0}; Las horas extras trabajadas: {1}; Cantidad de dias trabajados: {2}; Horas Totales trabajadas en el mes: {3}", horasfijassec, horasextrassec, diastrabajadossec, horastotalessec);
        }

    }
}
