using System;

namespace Practica4;

public class Circulo
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double GetArea()
    {
        return Math.PI * radio * radio;
    }
}
