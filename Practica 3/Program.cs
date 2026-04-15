Console.WriteLine("Hello, World!");

static void ImprimirMatrizConFormato(double[,] matriz, string formatString) 
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write($"{matriz[i, j].ToString(formatString)}\t");
        }
        Console.WriteLine(); // salto de línea al terminar la fila
    }
}

double[,] matriz = new double[4, 4];

for (int f = 0; f < matriz.GetLength(0); f++)
{
    for (int c = 0; c < matriz.GetLength(1); c++)
    {
        matriz[f, c] = f + c; // guardamos la suma de los índices para ver inicializarla
    }
}
string formato = "0.00";
ImprimirMatrizConFormato(matriz, formato);
