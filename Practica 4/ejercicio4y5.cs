using System.Collections.Generic;
using Practica4;

public class Ejercicio4y5
{
    public static void Ejecutar()
    {
        Hora h = new Hora(23, 30, 15);
        h.Imprimir();

        new Hora(23, 30, 15).Imprimir();
        new Hora(14.43).Imprimir();
        new Hora(14.45).Imprimir();
        new Hora(14.45114).Imprimir();
    }
} 
 
 
