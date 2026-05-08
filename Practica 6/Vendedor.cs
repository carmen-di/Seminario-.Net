using System;

namespace Practica6;

public class Vendedor : Empleado
{
    public double Comision {get; set;}

    public Vendedor(string nombre, int dni, DateTime ingreso, double salarioBase) 
        : base(nombre, dni, ingreso, salarioBase) { }
    
    public override double Salario 
    {
        get
        {
            return SalarioBase + Comision;
        }    
    }

    public override void AumentarSalario()
    {
        double aumento = (Antiguedad < 10) ? 1.05 : 1.10;
        SalarioBase *= aumento;
    }

    public override string ToString()
    {
        return "Vendedor " + base.ToString() + $"Salario: {Salario}";
    }

}
