using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public class ZIFactura : ZIPagar   //IMPLEMENTE LA INTERF
    {
        //ATRIBUTOS

        public int id { get; set; }
        public string descripcion { get; set; }
        public float cantidad { get; set; }
        public decimal precio { get; set; }

        public decimal GetValorPagar()    //metodo obligatorio
        {
            return precio *(decimal)cantidad; //saber el valor de la fact 

        }
        public override string ToString()
        {
            return $"{id} - {descripcion}" +
                $"\n\tCANTIDAD.........:  {$"{cantidad:N2}",18}" +
                $"\n\tPRECIO...........:  {$"{precio:c2}",18}" +
                $"\n\tvalor............:  {$"{GetValorPagar():c2}",18}";
        }

    }
}
