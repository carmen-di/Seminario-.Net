using System.Collections.Generic;
using Practica5;

public class ejercicio7
{
    public static void Ejecutar()
    {
        Persona p = new Persona();
        p[0] = "Juana Molina";
        p[1] = 'F';
        p[2] = 22333444;
        p[3] = new DateTime(1961, 10, 1);
        Console.WriteLine($"Nombre: {p[0]}");
        Console.WriteLine("Sexo: {0}", p[1].Equals('M') ? "Masculino" : "Femenino");
        Console.WriteLine($"DNI: {p[2]}");
        Console.WriteLine($"Nacimiento: {p[3]:dd/MM/yyyy}");
        Console.WriteLine($"Edad: {p[4]}");
    }
}