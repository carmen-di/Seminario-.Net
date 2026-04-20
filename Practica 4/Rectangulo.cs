using System;

namespace Practica4;

public class Rectangulo
{
    private double baseR;
    private double altura;

    public Rectangulo(double b, double h)
    {
        baseR = b;
        altura = h;
    }

    public double GetArea()
    {
        return baseR * altura;
    }
}
