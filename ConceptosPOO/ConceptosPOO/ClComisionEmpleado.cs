using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    internal class clComisionEmpleado : clEmpleado
    {
        public float porcentajeComision { get; set; }
        public decimal ventas { get; set; }

        public override decimal GetValorPagar()
        {
            return ventas * (decimal)porcentajeComision; //se le coloca decimal "SE AC  UN CASTING"
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tVALOR COMISION..........: {porcentajeComision:p2}" +
                $"\n\tVENTAS............: {$"{ ventas:C2}",20}" +       //doble interpolacion para generar espacion entre los 2 puntos y la cifra
                $"\n\tVALOR A PAGAR...........:{$"{GetValorPagar():c2}",20}";

        }
    }
}
