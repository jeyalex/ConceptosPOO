namespace ConceptosPOO
{
    internal abstract class clEmpleado   //la clse de define abstraccta "OSEA NO PUEDO DEFINIR OBJETOS"
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }            // aqui genera el contructor generico de c# 
        public clDate fechaNacimento { get; set; } //deriva de la clase date hecha anteriormnte
        public clDate fechaContratacion { get; set; }
        public bool activo { get; set; }

        public abstract decimal GetValorPagar();      //metodo abtracto solo se plante no se implementa x q no sabemos q empleado es para sacar el salario lo implementan las clases que hereden de esta


        public override string ToString()
        {
            return $"{id}-{nombre}-{apellido}," +                 //FORMA PARA IMPRIMIR
                $"FECHA DE NACIMIENTO:{fechaNacimento}," +
                $" FECHA CONTRATACION: {fechaContratacion}," +
                $" ESTA ACTIVO:{activo}";
        }


    }
}
