public static class Funciones
{
    public static int IngresarEntero(string msj)
{
    Console.WriteLine(msj);
    return int.Parse(Console.ReadLine());
}
 public static int IngresarEnteroMayorCero_Menorcinco(string msj)
 {
    int num=0;
    Console.WriteLine(msj);
    num=int.Parse(Console.ReadLine());
    while(num>5||num<0)
    {
        Console.WriteLine("ERROR, solo existen entradas de tipo 1 a 4 - Ingrese los datos nuevamente: ");
        num=int.Parse(Console.ReadLine());
    }
    return num;
 }

public static string IngresarTexto(string msj)
{
    Console.WriteLine(msj);
    return Console.ReadLine();
}
public static DateTime IngresarFecha(string msj)
    {
        DateTime fechaDate;
        string fecha_ingresada = IngresarTexto(msj);
        while (!DateTime.TryParse(fecha_ingresada, out fechaDate))
        {
            fecha_ingresada = IngresarTexto("ERROR! " + msj);
        }
        return fechaDate;
    }
public static int Menu(int opcion)
{
    do
    {
        Console.WriteLine("1) Nueva Inscripción");
        Console.WriteLine("2) Obtener Estadísticas del Evento");
        Console.WriteLine("3) Buscar Cliente");
        Console.WriteLine("4) Cambiar entrada de un Cliente");
        Console.WriteLine("5) Salir");
        opcion= Funciones.IngresarEntero("Ingrese la opción que desea ejecutar: ");
    } while(opcion<0 || opcion>5);
    return opcion;
} 
}