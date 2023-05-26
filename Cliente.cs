public class Cliente{
    public string DNI {get;private set;}
    public string Apellido{get;private set;}
    public string Nombre{get;private set;}
    public DateTime FechaInscripcion{get;set;}
    public int TipoEntrada{get;set;}
    public int TotalAbondado{get;set;}
    public Cliente(string dni, string surname, string name, int tipo_entrada, int total_abonado){
        DNI= dni;
        Apellido=surname;
        Nombre= name;
        TipoEntrada=tipo_entrada;
        TotalAbondado=total_abonado;
    }


}