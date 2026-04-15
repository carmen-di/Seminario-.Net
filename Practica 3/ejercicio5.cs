/*5) Implementar un método que devuelva un arreglo de arreglos con los mismos elementos que la matriz
pasada como parámetro:

double[][] GetArregloDeArreglo(double [,] matriz)*/

double [,] matriz= new double[,]
{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};   

double[][] arregloDoble = GetArregloDeArreglo(matriz);

imprimirArregloDeArreglos(arregloDoble);

static double[][] GetArregloDeArreglo(double[,] matriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);

    double[][] arregloDeArreglo = new double[filas][];

    for (int i = 0; i < filas; i++)
    {
        arregloDeArreglo[i] = new double[columnas];

        for (int j = 0; j < columnas; j++)
        {
            arregloDeArreglo[i][j] = matriz[i, j];
        }
    }

    return arregloDeArreglo;
}

static void imprimirArregloDeArreglos(double[][] arreglo)
{
    for (int i = 0; i < arreglo.Length; i++)
    {
        for (int j = 0; j < arreglo[i].Length; j++)
        {
            Console.Write(arreglo[i][j] + " ");
        }
        Console.WriteLine();
    }
}
