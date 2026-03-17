using System.Collections.Generic;
class flot
{
    public List<Barco> Barcos{get;set;}
    public flot()
    {
        Barcos=new List<Barco>();
       
    }


    public void CrearFlotaAutomatica()//me parece eso mas facil
    {
        Barcos.Add(new Barco("Portaaviones", 5));
        Barcos.Add(new Barco("Acorazado", 4));
        Barcos.Add(new Barco("Destructor", 3));
        Barcos.Add(new Barco("Submarino", 3));
        Barcos.Add(new Barco("Patrullera", 2));
    }
   
    
}
