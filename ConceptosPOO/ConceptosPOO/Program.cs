
// See https://aka.ms/new-console-template for more information


using ConceptosPOO;

Console.WriteLine("DE TU MANO TODO LO PUEDO tobares");

//instanciar un objeto de la clase year
//clDate fecha1 = new clDate(2022, 2, 11);// es mejor tipar el objeto

try
{
    Console.WriteLine(new clDate(2022, 2, 11));// asi no la ejecuta x q la clase date hereda d la object hay q sobreescribir el metodo q a la final se quita el tostring
    Console.WriteLine(new clDate(2022, 8, 30));
    Console.WriteLine(new clDate(2022, 11, 15));
}

    catch (Exception error)              //la clese exepction ereda de MonthException
{

    Console.WriteLine(error.Message);               
}






















