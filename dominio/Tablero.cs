class Tablero
{
    casilla[,] casillaTablero = new casilla[10,10];

    public Tablero()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                char fila = (char)('A' + i);
                int columna = j + 1;

                casillaTablero[i,j] = new casilla(fila, columna);
            }
        }
    }

   
  public void LogarBarco()
{
    flot barcos = new flot();
    barcos.CrearFlotaAutomatica();

    int fila = 0;

    foreach (var barcoActual in barcos.Barcos)
    {
        for (int j = 0; j < barcoActual.Tamanio; j++)
        {
            char letraFila = (char)('A' + fila);

            casillaTablero[fila, j] = new casilla(letraFila, j + 1);
            casillaTablero[fila, j].Barco = barcoActual;
        }

        fila++;
    }
}
    }
