using System;

namespace Practica4;

public class Ecuacion2
{
    private double a;
    private double b;
    private double c;

    public Ecuacion2(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double GetDiscriminante()
    {
        return Math.Pow(this.b, 2) - 4 * this.a * this.c;
    }

    public int GetCantidadDeRaices()
    {
        return GetDiscriminante() < 0 ? 0 : GetDiscriminante() == 0 ? 1 : 2;
    }

    public void ImprimirRaices()
    {
        if (this.GetCantidadDeRaices() == 0)
        {
            Console.WriteLine("La ecuación no tiene raíces reales");
        } else if (this.GetCantidadDeRaices() == 1)
        {
            double raiz = -this.b / (2 * this.a);
            Console.WriteLine("La ecuación tiene una raíz igual a:{0:0.00}", raiz);
        } else
        {
            double raiz1 = (-this.b + Math.Sqrt(this.GetDiscriminante())) / 2 * this.a;
            double raiz2 = (-this.b - Math.Sqrt(this.GetDiscriminante())) / 2 * this.a;
            Console.WriteLine("La ecuación tiene dos raices reales r1: {0:0.00} y r2: {1:0.00}", raiz1, raiz2);
        }
    }
}
