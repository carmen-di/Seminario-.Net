using System;

namespace Practica4;

public class Auto
{
    private string marca;
    private int anio;

    public Auto(string marca, int anio)
    {
        this.marca = marca;
        this.anio = anio;
    }

    public Auto(string marca)
    {
        this.marca = marca;
        this.anio = 2022;
    }

    public string GetDescripcion()
    {
        return $"Auto {marca} {anio}";
    }
}
