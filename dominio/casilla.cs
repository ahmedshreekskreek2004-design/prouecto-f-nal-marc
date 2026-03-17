class casilla
{
    

    public Char Fila { get; set; }
    public int Columna { get; set; }
    public Barco Barco { get; set; }  // null si no hay barco
    public bool Disparada { get; set; }
      public bool EstaVacia
    {
      get {return Barco == null;}  
    }
    public bool EsImpacto
    {
       get{return Disparada && Barco != null;}
    }  
    public bool EsAgua
    {
            get {return Disparada && Barco == null;}

    }
    public casilla(Char fila,int columna)
    {
        Fila=fila;
        Columna=columna;
        Barco=null; // null si no hay barco
        Disparada=false; //en la primera
    }
}