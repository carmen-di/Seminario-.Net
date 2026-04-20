using System.Collections.Generic;
using Practica4;

public class Ejercicio3
{
    public static void Ejecutar()
    {
        List<Persona> listaPersonas = new List<Persona>();

        Console.WriteLine("Ingrese los datos: Nombre,DNI,Edad");
        string st = Console.ReadLine();

        while (st != "")
        {
            string[] partes = st.Split(',');

            Persona p = new Persona(
                partes[0],
                int.Parse(partes[2]),
                partes[1]
            );

            listaPersonas.Add(p);

            st = Console.ReadLine();
        }

        for (int i = 0; i < listaPersonas.Count; i++)
        {
            Console.WriteLine((i + 1) + ") " + listaPersonas[i].Imprimir);
        }

        Persona masJoven = new Persona("", 100, "");
        for (int i = 0; i < listaPersonas.Count; i++)
        {
            if (masJoven.EsMayorQue(listaPersonas[i]))
            {
                masJoven = listaPersonas[i];
            }
        }
        Console.WriteLine("Persona más joven:");
        Console.WriteLine(masJoven.Imprimir);
    }
}