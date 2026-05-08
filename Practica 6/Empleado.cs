using System;

namespace Practica6;

public abstract class Empleado
{
    public string Nombre { get; protected set; }
    public int DNI { get; protected set; }
    public DateTime FechaDeIngreso { get; protected set; }
    public double SalarioBase { get; protected set; }
    public abstract double Salario {get ;}

    public Empleado(string nombre, int dni, DateTime ingreso, double salarioBase)
    {
        this.Nombre = nombre;
        this.DNI = dni;
        this.FechaDeIngreso = ingreso;
        this.SalarioBase = salarioBase;
    }

    public int Antiguedad
    {
        get
        {
            int ant = DateTime.Today.Year - FechaDeIngreso.Year;
            // Ajuste por si aún no pasó el mes/día de ingreso este año
            if (DateTime.Today < FechaDeIngreso.AddYears(ant))
            {
                ant--;
            }
            return ant;
        }
    }

    public abstract void AumentarSalario();

    public override string ToString()
    {
        return $"Nombre: {Nombre}, DNI: {DNI} Antiguedad: {Antiguedad} \nSalario Base: {SalarioBase}, ";
    }
}
