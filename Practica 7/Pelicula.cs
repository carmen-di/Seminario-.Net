using System;

namespace Practica7;

public class Pelicula: IAlquilable
{
    public virtual void SeAlquilaA(Persona p)
    {
      Console.WriteLine("Alquilando película a persona"); 
    } 
    public virtual void SeDevuelvePor(Persona p)
    {
        Console.WriteLine("Película devuelta por persona");
    }

}

class PeliculaClasica : Pelicula, IVendible
{
    public override void SeAlquilaA(Persona p)
    {
        Console.WriteLine("Alquilando película clásica a persona");
    }
    public override void SeDevuelvePor(Persona p)
    {
        Console.WriteLine("Película clásica devuelta por persona");
    }
    public void SeVendeA(Persona p)
    {
        Console.WriteLine("Vendiendo película clásica a persona");
    }
}