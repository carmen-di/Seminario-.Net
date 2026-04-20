using System.Collections.Generic;
using Practica4;

public class Ejercicio7
{
    public static void Ejecutar()
    {
        Matriz m1 = new Matriz(2, 3); //2x3
            double[,] aux1 = new double[,] { { 6, 5, 4 }, { 3, 2, 1 } }; //2x3
            Matriz m2 = new Matriz(aux1);
            double[,] aux2 = new double[,] { { 1, 2 }, { 3, 4 } }; //2x2
            Matriz m3 = new Matriz(aux2);
            m1.SetElemento(0, 0, 5);
            m1.SetElemento(0, 1, 3);
            m3.GetElemento(0, 0);
            m1.imprimir();
            m2.imprimir();
            m3.imprimir("0.00");
            m1.sumarle(m2);
            m1.restarle(m2);
            m1.sumarle(m3);
            m1.restarle(m3);
            m1.imprimir();
            m2.imprimir();
            m1.multiplicarPor(m2);
            m3.multiplicarPor(m2);
            double[] fila = m1.GetFila(0);
            double[] columna = m2.GetColumna(0);
            double[] diagP = m3.GetDiagonalPrincipal();
            double[] diagS = m3.GetDiagonalSecundaria();
            double[][] arrDeArr = m3.GetArregloDeArreglo();
    }
} 