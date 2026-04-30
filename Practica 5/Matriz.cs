using System;

namespace Practica5;

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

    public double this[int fila, int columna]
    {
        get { return matriz[fila, columna]; }
        set { matriz[fila, columna] = value; }
    }

    public double[] GetDiagonalPrincipal
    {
        get
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
    }

    public double[] GetDiagonalSecundaria
    {
        get
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
    }

}
