using System;

namespace Practica5;  

public class Persona
{
    public string Nombre {get; set;}
    public char Sexo {get; set;}
    public int DNI {get; set;}
    public DateTime FechaNacimiento {get; set;}

    public Persona()
    {
        Nombre = "";
    }

    public int Edad {
        get {
            DateTime hoy = DateTime.Now;
            int edadCalculada = (hoy.Year - FechaNacimiento.Year );
            return edadCalculada;
        }
    }
    
    public object this[int i]
    {
        get
        {
            if (i == 0) return Nombre;
            else if (i == 1) return Sexo;
            else if (i == 2) return DNI;
            else if (i == 3) return FechaNacimiento;
            else return Edad;
        }
        set
        {
            if (i == 0) Nombre = (string)value;
            else if (i == 1) Sexo = (char)value;
            else if (i == 2) DNI = (int)value;
            else if (i == 3) FechaNacimiento = (DateTime)value;
        }
    }
}