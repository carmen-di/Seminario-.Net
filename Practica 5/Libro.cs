using System;

namespace Practica5;

public class Libro
{
    public string ISBN {get;}
    public DateTime? FechaPublicacion {get; init;}
    public required string Titulo {get; init;}
    public double Precio {get;set;}

    public Libro(string isbn)
    {
        ISBN = isbn;
    }
}
