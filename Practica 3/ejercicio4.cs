/*4) Implementar los métodos GetDiagonalPrincipal y GetDiagonalSecundaria que devuelven un vector con la diagonal 
correspondiente de la matriz pasada como parámetro. Si la matriz no es cuadrada generar una excepción ArgumentException.
double[] GetDiagonalPrincipal(double[,] matriz)
double[] GetDiagonalSecundaria(double[,] matriz)*/


double [,] matriz= new double[,]
{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};   

double [] principal = GetDiagonalPrincipal(matriz);
double[] secundaria = GetDiagonalSecundaria(matriz);

static double[] GetDiagonalPrincipal(double[,] matriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);

    if (filas != columnas)
        throw new ArgumentException("La matriz no es cuadrada");

    double[] diagonal = new double[filas];

    for (int i = 0; i < filas; i++)
    {
        diagonal[i] = matriz[i, i];
    }

    return diagonal;
}

static double[] GetDiagonalSecundaria(double[,] matriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);

    if (filas != columnas)
        throw new ArgumentException("La matriz no es cuadrada");

    double[] diagonal = new double[filas];

    for (int i = 0; i < filas; i++)
    {
        diagonal[i] = matriz[i, columnas - 1 - i];
    }

    return diagonal;
}

Console.WriteLine("Diagonal principal:");
foreach (double d in principal)
{
    Console.WriteLine(d);
}

Console.WriteLine("Diagonal secundaria:");
foreach (double d in secundaria)
{
    Console.WriteLine(d);
}