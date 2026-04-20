using System;

namespace Practica4;

public class Matriz
{
    private double [,] matriz;
    public Matriz(int filas, int columnas)
    {
        this.matriz = new double[filas, columnas];
    }
    public Matriz(double[,] matriz)
    {
        this.matriz = matriz;
    }

    public void SetElemento(int fila, int columna, double elemento)
    {
        this.matriz[fila, columna] = elemento;
    }

    public double GetElemento(int fila, int columna)
    {
        return this.matriz[fila, columna];
    }

    public void imprimir()
    {
        for (int f = 0; f < matriz.GetLength(0); f++)
        {
            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                Console.Write($"{this.matriz[f,c], -5}");
            }
        }
        Console.WriteLine();
    }

    public void imprimir(string formatString)
    {
        for (int f = 0; f < matriz.GetLength(0); f++)
        {
            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                Console.Write($"{this.matriz[f, c].ToString(formatString), -5}");
            }
        }
        Console.WriteLine("\n");
    }

    public double[] GetFila(int fila)
    {
        double[] arrayFila = new double[this.matriz.GetLength(1)];
        for (int i = 0; i < this.matriz.GetLength(1); i++)
        {
            arrayFila[i] = this.matriz[fila, i];
        }
        return arrayFila;
    }

    public double[] GetColumna(int columna)
    {
        double[] arrayColumna = new double[this.matriz.GetLength(0)];
        for (int c = 0; c < this.matriz.GetLength(0); c++)
        {
            arrayColumna[c] = this.matriz[c, columna];
        }
        return arrayColumna;
    }

    public double[] GetDiagonalPrincipal()
    {
        int filas = matriz.GetLength(0);

        double[] diagonal = new double[filas];
        for (int i = 0; i < filas; i++)
        {
            diagonal[i] = matriz[i, i];
        }
        return diagonal;
    }

    public double[] GetDiagonalSecundaria()
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        double[] diagonal = new double[filas];
        for (int i = 0; i < filas; i++)
        {
            diagonal[i] = matriz[i, columnas - 1 - i];
        }
        return diagonal;
    }

    public double[][] GetArregloDeArreglo()
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

    public void sumarle(Matriz m)
    {
        if (this.matriz.GetLength(0) == m.matriz.GetLength(0) && this.matriz.GetLength(1) == m.matriz.GetLength(1))
        {
            for (int i = 0; i < this.matriz.GetLength(0); i++)
            {
                for (int j = 0; j < this.matriz.GetLength(1); j++)
                {
                    this.matriz[i, j] = this.matriz[i, j] + m.matriz[i, j];
                }
            }
        }
        else
        {
            Console.WriteLine("Sólo se pueden sumar matrices del mismo tamaño");
        }
    }

    public void restarle(Matriz m)
    {
        if (this.matriz.GetLength(0) == m.matriz.GetLength(0) && this.matriz.GetLength(1) == m.matriz.GetLength(1))
        {
            for (int i = 0; i < this.matriz.GetLength(0); i++)
            {
                for (int j = 0; j < this.matriz.GetLength(1); j++)
                {
                    this.matriz[i, j] = this.matriz[i, j] - m.matriz[i, j];
                }
            }

        }
        else
        {
            Console.WriteLine("Sólo se pueden restar matrices del mismo tamaño");
        }
    }

    public void multiplicarPor(Matriz m)
    {
        if (this.matriz.GetLength(1) == m.matriz.GetLength(0))
        {
            double[,] multiplicar = new double[this.matriz.GetLength(0), m.matriz.GetLength(1)];
            double suma;
            for (int i = 0; i < this.matriz.GetLength(0); i++)
            {
                for (int j = 0; j < m.matriz.GetLength(1); j++)
                {
                    suma = 0;
                    for (int k = 0; k < m.matriz.GetLength(0); k++)
                    {
                        suma += this.matriz[i, k] * m.matriz[k, j];
                    }
                    multiplicar[i, j] = suma;
                }
            }
            this.matriz = multiplicar;
        }
        else
        {
            Console.WriteLine("La cantidad de columnas de la matriz 1 es distinto a la cantidad de filas de la matriz 2");
        }
    }
}
