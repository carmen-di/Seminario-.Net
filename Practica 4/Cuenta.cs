using System;

namespace Practica4;

public class Cuenta
{
    private double _monto;
    private int _titularDni;
    private string? _titularNombre;

    public Cuenta() : this("No especificado", 0) { }

    public Cuenta(int dni) : this("No especificado", dni) { }

    public Cuenta(string nombre) : this(nombre, 0) { }

    public Cuenta(string nombre, int dni)
    {
        this._titularNombre = nombre;
        this._titularDni = dni;
        this._monto = 0;
    }

     public void Imprimir()
    {
        string nombre = _titularNombre ?? "No especificado"; //Hacer uso del null-coalescing, operación que pregunta si el primer valor es igual a null, y en dicho caso asigna el segundo
        string DNI = (_titularDni != 0) ? _titularDni.ToString() : "No especificado";
        
        Console.WriteLine($"Nombre: {nombre}, DNI: {DNI}, Monto: {_monto}");
    }

    public void Depositar(double monto)
    {
        this._monto += monto; 
    }

    public void Extraer(double monto)
    {
        if (monto < this._monto)
        {
            this._monto -= monto;
        }
        else
        {
            Console.WriteLine("Operación cancelada, monto insuficiente.");
        }
    }

}
