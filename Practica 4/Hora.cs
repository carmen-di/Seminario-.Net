using System;

namespace Practica4;

public class Hora
{
    private int Horas;
    private int Minutos;
    private double Segundos;

    public Hora(int unaHora, int unMin, double unSeg)
    {
        this.Horas = unaHora;
        this.Minutos = unMin;
        this.Segundos = unSeg;
    }

    public Hora(double hora)
    {
        this.Horas = (int)hora;
        double decimalParte = hora - this.Horas;
        double totalMinutos = decimalParte * 60;
        this.Minutos = (int)totalMinutos;
        this.Segundos = (totalMinutos - this.Minutos) * 60;
    }

    public void Imprimir()
    {
        Console.WriteLine($"{this.Horas} horas, {this.Minutos} minutos y {this.Segundos:F3} segundos");
    }
}
