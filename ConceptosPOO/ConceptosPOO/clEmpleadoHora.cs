namespace ConceptosPOO           //22-05-22
{
    internal class clEmpleadoHora : clEmpleado    //heredamos de empleado pero obligatoriamente debemos llamar los metodos q tenga esa clase CLASES ABSTRACTAS
    {

        public float horas { get; set; }   //el que float pasa a decimal
        public decimal valorHora { get; set; }


        public override decimal GetValorPagar()
        {
            return (decimal)horas * valorHora;                        //el que float pasa a decimal

        }


        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHORAS TRABAJADAS..........: {horas:N2}" + //FORMATear el n pero q no coloque el signo de $ FORMATO DE N CON 2 DECI
                $"\n\tVALOR HORA................: {$"{valorHora:C2}",20}" +
                $"\n\tVALOR A PAGAR.............:{$"{GetValorPagar():c2}",20}";

        }

    }
}
