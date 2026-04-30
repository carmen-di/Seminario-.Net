using Practica5;

public class ejercicio8
{
    public static void Ejecutar()
    {
        ListaDePersonas lista = new ListaDePersonas();

        Persona p1 = new Persona("Ana", 30456345);
        Persona p2 = new Persona("Juan", 40111222);
        Persona p3 = new Persona("Alberto", 29888777);
        Persona p4 = new Persona("Maria", 35555111);

        lista.Agregar(p1);
        lista.Agregar(p2);
        lista.Agregar(p3);
        lista.Agregar(p4);

        Persona encontre= lista[30456345];

        if (encontre != null)
            Console.WriteLine("Encontrada: " + encontre.Nombre);
        else
            Console.WriteLine("No existe");

        List<string> nombres = lista['A'];

        Console.WriteLine("\nNombres que empiezan con A:");
        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }
}

