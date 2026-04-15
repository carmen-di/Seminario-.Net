/*6) Implementar los siguientes métodos que devuelvan la suma, resta y multiplicación de matrices pasadas como 
parámetros. Para el caso de la suma y la resta, las matrices deben ser del mismo tamaño, en caso de no serlo devolver
null. Para el caso de la multiplicación la cantidad de columnas de A debe ser igual a la cantidad de filas de B, en 
caso contrario generar una excepción ArgumentException.

double[,]? Suma(double[,] A, double[,] B)
double[,]? Resta(double[,] A, double[,] B)
double[,] Multiplicacion(double[,] A, double[,] B) */

double[,] matrizA = new double[,]
{
    {1,2,3}, 
    {4,5,6}
};

double[,] matrizB = new double[,]
{
    {7,8,9}, 
    {6,5,4}
};

double[,]? sumaMatrices = Suma(matrizA, matrizB);
double[,]? restaMatrices = Resta(matrizA, matrizB);
double[,] productoMatrices = Multiplicacion(matrizA, matrizB);

if (sumaMatrices != null && restaMatrices != null)
{
    imprimirMatriz(sumaMatrices, "Suma");
    imprimirMatriz(restaMatrices, "Resta");
}
else
{
    Console.WriteLine("Las matrices deben tener el mismo tamaño");
}

imprimirMatriz(productoMatrices, "Multiplicación");

// Método suma
double[,]? Suma(double[,] A, double[,] B) {
    if (A.GetLength(0) == B.GetLength(0) && A.GetLength(1) == B.GetLength(1))
    {
        int filas = A.GetLength(0); 
        int columnas = A.GetLength(1);    

        double [,] suma = new double[filas, columnas]; 
        
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                suma[i, j] = A[i, j] + B[i, j];
            }
        }
        return suma;
    }
    else 
    {
        return null;
    }
}

// Método resta
double[,]? Resta(double[,] A, double[,] B)
{
    if (A.GetLength(0) == B.GetLength(0) && A.GetLength(1) == B.GetLength(1))
    {
        int filas = A.GetLength(0);
        int columnas = A.GetLength(1);

        double[,] resta = new double[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resta[i, j] = A[i, j] - B[i, j];
            }
        }
        return resta;
    }
    else
    {
        return null;
    }
}

// Método multiplicación
double[,] Multiplicacion(double[,] A, double[,] B)
{
    int filasA = A.GetLength(0);
    int columnasA = A.GetLength(1);
    int filasB = B.GetLength(0);
    int columnasB = B.GetLength(1);

    if (columnasA != filasB)
        throw new ArgumentException("No se pueden multiplicar las matrices");

    double[,] multiplicacion = new double[filasA, columnasB];

    for (int i = 0; i < filasA; i++)
    {
        for (int j = 0; j < columnasB; j++)
        {
            for (int k = 0; k < columnasA; k++)
            {
                multiplicacion[i, j] += A[i, k] * B[k, j];
            }
        }
    }
    return multiplicacion;
}

void imprimirMatriz(double[,] matriz, string titulo)
{
    Console.WriteLine(titulo + ":");

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i, j] + " ");
        }
        Console.WriteLine();
    }
}