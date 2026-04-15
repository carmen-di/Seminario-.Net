/*2) Implementar un método para imprimir por consola todos los elementos de una matriz (arreglo de dos dimensiones)
pasada como parámetro. Debe imprimir todos los elementos de una fila en la misma línea en la consola.

void ImprimirMatriz(double[,] matriz)

Ayuda: Si A es un arreglo, A.GetLength(i) devuelve la longitud del arreglo en la dimensión i.
*/

static void ImprimirMatriz(double[,] matriz)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i, j] + " ");
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

ImprimirMatriz(matriz);
