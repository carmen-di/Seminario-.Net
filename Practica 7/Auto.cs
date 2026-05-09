using System;

namespace Practica7;

public class Auto : IVendible, ILavable, IReciclable
{
    public void SeVendeA(Persona p) => Console.WriteLine("Vendiendo auto a persona");
    public void SeLava() => Console.WriteLine("Lavando auto");
    public void SeSeca() => Console.WriteLine("Secando auto");
    public void SeRecicla() => Console.WriteLine("Reciclando auto"); 
    
}
