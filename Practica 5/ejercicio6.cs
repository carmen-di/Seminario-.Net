using System.Collections.Generic;
using Practica5;

public class ejercicio6
{
    public static void Ejecutar()
    {
        Matriz m = new Matriz(3,3);

        m[0,0] = 1;
        m[1,1] = 5;
        m[2,2] = 9;

        double[] diag = m.GetDiagonalPrincipal;

        foreach (double d in diag)
        {
            Console.WriteLine(d);
        }
    }
}