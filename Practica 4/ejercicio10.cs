using System.Collections.Generic;
using Practica4;

public class Ejercicio10
{
    public static void Ejecutar()
    {
        Cuenta cuenta = new Cuenta();
        cuenta.Imprimir();
        cuenta = new Cuenta(30222111);
        cuenta.Imprimir();
        cuenta = new Cuenta("José Perez");
        cuenta.Imprimir();
        cuenta = new Cuenta("Maria Diaz", 20287544);
        cuenta.Imprimir();
        cuenta.Depositar(200);
        cuenta.Imprimir();
        cuenta.Extraer(150);
        cuenta.Imprimir();
        cuenta.Extraer(1500);
    }
}