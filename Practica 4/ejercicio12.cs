using System.Collections.Generic;
using Practica4;

public class Ejercicio12
{
    public static void Ejecutar()
    {
        //El constructor de Circulo espera recibir el radio
        List<Circulo> listaCirculos = [
            new Circulo(1.1),
            new Circulo(3),
            new Circulo(3.2)
        ];
        //El constructor de Rectángulo espera recibir la base y la altura
        List<Rectangulo> listaRectangulos = [
            new Rectangulo(3, 4),
            new Rectangulo(4.3, 4.4)
        ];
        //La clase Auto está codificada como la vista en la teoría
        List<Auto> listaAutos = [
            new Auto("Nissan", 2017),
            new Auto("Ford", 2015),
            new Auto("Renault")
        ];
    }

}