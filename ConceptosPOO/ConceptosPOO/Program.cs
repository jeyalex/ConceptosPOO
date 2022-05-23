
// See https://aka.ms/new-console-template for more information


using ConceptosPOO;

Console.WriteLine("DE TU MANO TODO LO PUEDO tobares");

//instanciar un objeto de la clase year
//clDate fecha1 = new clDate(2022, 2, 11);// es mejor tipar el objeto

/*try
{
    Console.WriteLine(new clDate(2022, 2, 11));                   // asi no la ejecuta x q la clase date hereda d la object hay q sobreescribir el metodo q a la final se quita el tostring
    Console.WriteLine(new clDate(2022, 8, 30));
    Console.WriteLine(new clDate(2022, 11, 15));
}
    catch (Exception error)                                   //la clese exepction ereda de MonthException
{
    Console.WriteLine(error.Message);               
}*/

// VAMOS  CREAR UN OBJETO DE LA CLASE clEmpleado
//creamos la clase SALARIOEMPLEADO

clEmpleado clEmpleado1 = new ClSalarioEmpleado()
{
    id =001,
    nombre = "Juan",
    apellido= "Lara",
    fechaNacimento =new clDate(1993,11,10),
    fechaContratacion= new clDate (2021,02,15),
    activo= true,
    salario= 1730000M
};   
Console.WriteLine(clEmpleado1);




clEmpleado clEmpleado2 = new clComisionEmpleado()
{
    id = 002,
    nombre = "Natalia",
    apellido = "Pita",
    fechaNacimento = new clDate(1933, 05, 23),
    fechaContratacion = new clDate(2022, 01, 23),
    activo = true,
    ventas=320000000M,
    porcentajeComision =0.03F
};
Console.WriteLine(clEmpleado2);


clEmpleado clEmpleado3 = new clEmpleadoHora()
{
    id = 003,
    nombre = "Pedro",
    apellido = "Cabuya",
    fechaNacimento = new clDate(1930, 05, 23),
    fechaContratacion = new clDate(2021, 01, 23),
    activo = true,
    horas = 10.5F,
    valorHora = 5000.5M
};
Console.WriteLine(clEmpleado3);


clEmpleado clEmpleado4 = new ClBaseComisionEmpleado()
{
    id = 003,
    nombre = "Benito",
    apellido = "Lazo",
    fechaNacimento = new clDate(1990, 05, 13),
    fechaContratacion = new clDate(2021, 10, 23),
    activo = true,                                //como hereda de clcomision empleado x ello se traaen sus atributos ventas y %
    baseSalario = 860678.45M,
    ventas = 58000000M,
    porcentajeComision = 0.015F

};
Console.WriteLine(clEmpleado4);


//VAMOS A CREAR UNA LISTA DE EMPLEADOS X SABER LA NOMINA DE TODOS  "COLLECTION LIST ARRAY"

ICollection<clEmpleado> nominaEmpleados = new List<clEmpleado>()
{

    clEmpleado1,clEmpleado2,clEmpleado3,clEmpleado4

    //nominaEmpleados.Add(clEmpleado1); D OTRA MANERA

};
//TOTAL NOMINA

 decimal totalNomina=0;  //variable

foreach (clEmpleado clEmpleado in nominaEmpleados)        //por cada empleado de la clase empleado en la coleccion nomina empleado
{ 
    Console.WriteLine(clEmpleado);
    totalNomina+= clEmpleado.GetValorPagar();  //arroja lo q se le paga a cada empleado con getvalopagar 
                                               // se puede sumar los totales x q todos tiene el metodo get valorpagar
} 

Console.WriteLine("                                         ============");
Console.WriteLine($"TOTAL NOMINA:                            {$"{totalNomina:c2}",15}");  //doble interpola para aliniar los n ala izq



//INTERFACES 


ZIFactura factura1 = new ZIFactura()
{
    descripcion = "iphone 13",
    id = 1,
    precio  = 5300000M,
    cantidad = 6
};

ZIFactura factura2 = new ZIFactura()
{
    descripcion = "TV 65",
    id = 2,
    precio = 2600000M,
    cantidad = 3
};

Console.WriteLine(factura1);
Console.WriteLine(factura2);
































