using System;

namespace Practica6;

public class Administrativo : Empleado
{
    public double Premio {get; set;}

    public Administrativo(string nombre, int dni, DateTime ingreso, double salarioBase) 
        : base(nombre, dni, ingreso, salarioBase) { }

    public override double Salario 
    {
        get
        {
            return SalarioBase + Premio;
        }    
    }

    public override void AumentarSalario()
    {
        double aumento = SalarioBase * (Antiguedad * 0.01);
        SalarioBase += aumento;
    }

    public override string ToString()
    {
        return "Administrativo " + base.ToString() + $"Salario: {Salario}";
    }

}
