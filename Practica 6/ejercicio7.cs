using System;

public class ejercicio7
{
    public static void Ejecutar()
    {
        Imprimidor.Imprimir(new A(), new B(), new C(), new D());
    }
}
abstract class Letra
{
    public abstract void Imprimir();
}
class A : Letra
{
    public override void Imprimir() => Console.WriteLine("Soy una instancia A");
}

class B : Letra
{
    public override void Imprimir() => Console.WriteLine("Soy una instancia B");
}

class C : Letra
{
    public override void Imprimir() => Console.WriteLine("Soy una instancia C");
}

class D : Letra
{
    public override void Imprimir() => Console.WriteLine("Soy una instancia D");
}

static class Imprimidor
{
    public static void Imprimir(params Letra[] vector)
    {
        foreach (Letra l in vector)
        {
            l.Imprimir();
        }
    }
}
