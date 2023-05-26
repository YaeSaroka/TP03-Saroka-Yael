public static class Ticketera{
    private static Dictionary<int,Cliente>DicCliente=new Dictionary<int, Cliente>();
    private static int UltimoIDEntrada=0;
    

    public static int DevolverUltimoID(){
        return UltimoIDEntrada;}
    public static int AgregarCliente(Cliente cliente){
        UltimoIDEntrada++;
        DicCliente.Add(UltimoIDEntrada,cliente);
        return UltimoIDEntrada;
    }
    public static Cliente BuscarCliente(int idEntrada)
    {
        if(DicCliente.ContainsKey(idEntrada)){
            return DicCliente[idEntrada];
        }
        else return null;

    }
    public static bool CambiarEntrada(int id, int tipo, int total){

        if(DicCliente.ContainsKey(id)&& DicCliente[id].TotalAbondado>total){
            DicCliente[id].TipoEntrada=tipo;
            DicCliente[id].TotalAbondado=total;
            return true;
        }
        else return false;
    }
    public static List<string>EstadisticasTicketera()
    {
        List<string> estadistica =new List<string>();
        int cont_clientes=0, cont_entrada1=0,cont_entrada2=0,cont_entrada3=0,cont_entrada4=0,recaudacion1=0,recaudacion2=0,recaudacion3=0,recaudacion4=0;
        foreach (int a in DicCliente.Keys){
            cont_clientes++;
            if(DicCliente[a].TipoEntrada==1)
            {
                cont_entrada1++;
                recaudacion1+=DicCliente[a].TotalAbondado;
            }
            else if(DicCliente[a].TipoEntrada==2)
            {
                cont_entrada2++;
                recaudacion2+=DicCliente[a].TotalAbondado;
            }
             else if(DicCliente[a].TipoEntrada==3)
            {
                cont_entrada3++;
                recaudacion3+=DicCliente[a].TotalAbondado;
            }
            else
            {
                cont_entrada4++;
                recaudacion4+=DicCliente[a].TotalAbondado;
            }
            estadistica.Add("Cantidad de clientes inscriptos: "+cont_clientes);
            estadistica.Add($"Porcentaje de entradas de tipo 1: {cont_entrada1*cont_clientes/100} %");
            estadistica.Add($"Porcentaje de entradas de tipo 2: {cont_entrada2*cont_clientes/100} %");
            estadistica.Add($"Porcentaje de entradas de tipo 3: {cont_entrada3*cont_clientes/100} %");
            estadistica.Add($"Porcentaje de entradas de tipo 4: {cont_entrada4*cont_clientes/100} %");
            estadistica.Add($"Recaudación total de entradas de tipo 1: ${recaudacion1}");
            estadistica.Add($"Recaudación total de entradas de tipo 2: ${recaudacion2}");
            estadistica.Add($"Recaudación total de entradas de tipo 3: ${recaudacion3}");
            estadistica.Add($"Recaudación total de entradas de tipo 4: ${recaudacion4}");
            estadistica.Add($"Recaudación total: ${recaudacion1+recaudacion2+recaudacion3+recaudacion4}");
        }
          return estadistica;

    }



}