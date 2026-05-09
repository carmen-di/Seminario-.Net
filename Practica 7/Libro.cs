using System;

namespace Practica7;

public class Libro : IAlquilable, IReciclable
{
    public void SeAlquilaA(Persona p)
    {
        Console.WriteLine("Alquilando libro a persona");
    }

    public void SeDevuelvePor(Persona p)
    {
        Console.WriteLine("Libro devuelto por persona");
    }

    public void SeRecicla()
    {
        Console.WriteLine("Reciclando libro");
    }
}
