class Barco
{
    public string Nombre{get;set;}
    public int Tamanio{get;set;}
    public List<casilla>Casiilas{get;set;}
    public int Impacto{get;set;}

    public Barco(string nombre,int tamanio)
    {
        Nombre=nombre;
        Tamanio=tamanio;
        Impacto=0;
        Casiilas=new List<casilla>();
    }

}