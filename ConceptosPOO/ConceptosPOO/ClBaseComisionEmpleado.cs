namespace ConceptosPOO      //CREAMOS STA CLASE QUE NO HEREDA DE EMPLEADO SINO DE COMISION EMPLEADO
{
    internal class ClBaseComisionEmpleado : clComisionEmpleado     //CLASE PUBLICA// no la admite tok INTERNAL
    {


        public decimal baseSalario { get; set; }

        public override decimal GetValorPagar()  //genera la herencia de la clase inmediatamente anterior y tare el metodo valor pagar
        {
            return base.GetValorPagar() + baseSalario;     // retorna el salario a pagar  +  base
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tVALOR SALARIO BASE..........: {baseSalario:c2}";  //ya trae todo ste override solo se le adicona la base


        }


    }
}
