
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




clEmpleado clEmpleado2 = new ClComisionEmpleado()
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























