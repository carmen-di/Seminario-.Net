using System;

namespace Practica4;  

public class Persona
{
    private string Nombre;
    private int Edad;
    private string DNI;

    public Persona(string unNombre, int unaEdad, string unDni)
    {
        Nombre = unNombre;
        Edad = unaEdad;
        DNI = unDni;
    }

    public string Imprimir => $"{Nombre} {Edad} {DNI}";

    public bool EsMayorQue(Persona p)
    {
        bool cumple = false;
        if (p.Edad < this.Edad)
        {
            cumple = true;
        }
        return cumple;
    }
}

// En el ejercicio 1, los atriburtos / variables de instancia tienen que ser publicos, para que se puedan acceder desde fuera de la clase como se pide en este ejercicio