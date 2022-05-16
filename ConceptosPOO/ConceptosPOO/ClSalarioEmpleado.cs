namespace ConceptosPOO
{
    internal class ClSalarioEmpleado : clEmpleado // OJO CON LA MAYUSCULA DE LA CLASE "C"
    {
        public decimal salario { get; set; }

        public override decimal GetValorPagar()
        {
            return salario;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tVALOR A PAGAR.............:{$"{GetValorPagar():c2}",20}";           //llama todo lo del empleado y adiicionamos el salario
        }                                                                                 //c2 aparece con deciamles u-d-c currency con 2 dcimales
    }
}
