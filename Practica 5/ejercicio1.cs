using System.Collections.Generic;
using Practica5;

public class ejercicio1
{
    public static void Ejecutar()
    {
        Cuenta c1 = new Cuenta();
        c1.Depositar(100).Depositar(50).Extraer(120).Extraer(50);

        Cuenta c2 = new Cuenta();
        c2.Depositar(200).Depositar(800);

        new Cuenta().Depositar(20).Extraer(20);

        c2.Extraer(1000).Extraer(1);
        
        Console.WriteLine("\nDETALLE");
        Cuenta.ImprimirDetalle();
    }
}
