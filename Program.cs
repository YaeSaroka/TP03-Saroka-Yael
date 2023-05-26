using System.Collections.Generic;
int opcion=0, tipo_entrada=0, id_entrada=0,id_entrada_buscado=0,nuevo_tipo=0;
const int ENTRADA1=15000, ENTRADA2= 30000, ENTRADA3=10000,ENTRADA4=40000;
List<string> estadistica =new List<string>();

while(opcion!=5)
{
    opcion=Funciones.Menu(opcion);
    Console.Clear();
switch(opcion)
{
    case 1:
        NuevaInscripcion();
        Console.Clear();
    break;
    case 2:
      estadistica=Ticketera.EstadisticasTicketera();
      foreach(string estadisticas in estadistica){
        Console.WriteLine(estadisticas);}
    break;
    case 3: 
    id_entrada=Funciones.IngresarEntero("Ingrese el id de la persona que desea buscar: ");
    Cliente cliente=Ticketera.BuscarCliente(id_entrada);
    Console.WriteLine("DNI: "+cliente.DNI+"Nombre: "+cliente.Nombre+"Apellido: "+cliente.Apellido+"Tipo de Entrada Abonada: "+cliente.TipoEntrada+ "Total Abonado: "+cliente.TotalAbondado);
    break;
    case 4:
    id_entrada_buscado=Funciones.IngresarEntero("Ingrese el id la persona a la que desea modificarle la entrada: ");
    nuevo_tipo=Funciones.IngresarEnteroMayorCero_Menorcinco("Ingrese el tipo de entrada al que desea cambiar: ");
    int total_abonado= CalcularTotal(tipo_entrada);
    if(Ticketera.CambiarEntrada(id_entrada_buscado,nuevo_tipo,total_abonado))
    Console.WriteLine("Se ha cambiado su entrada correctamente :)");
    else Console.WriteLine("No se ha podido cambiar su entrada :(");
    break;
}




//FUNCIONES LOCALES:
void NuevaInscripcion(){
    string dni= Funciones.IngresarTexto("Ingrese su DNI: ");
    ValidarDNI(ref dni);
    string surname=Funciones.IngresarTexto("Ingrese su apellido: ");
    string name= Funciones.IngresarTexto("Ingrese su nombre: ");
    tipo_entrada=Funciones.IngresarEnteroMayorCero_Menorcinco("Ingrese el tipo de entrada a abonar: ");
    int total_abonado= CalcularTotal(tipo_entrada);
    Cliente cliente = new Cliente(dni, surname,name,tipo_entrada,total_abonado);
    id_entrada=Ticketera.AgregarCliente(cliente);
    Console.WriteLine("Su ID para ingresar será: "+id_entrada);
}

void ValidarDNI(ref string dni)
{
    while(dni.Length<8 || dni.Length>8)
    {
        dni = Funciones.IngresarTexto("Error, ingrese su DNI nuevamente: ");
    }
}
int CalcularTotal(int tipo_entrada){
    if(tipo_entrada==1) return ENTRADA1;
    else if(tipo_entrada==2)return ENTRADA2;
    else if(tipo_entrada==3)return ENTRADA3;
    else return ENTRADA4;
}
}