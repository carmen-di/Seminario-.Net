/*19) Idem. al ejercicio 18.a) y 18.b) pero devolviendo el resultado en un parámetro de salida void Fac(int n, out int f)*/

// a) Función no recursiva
Console.WriteLine("Ingrese un número:");
int n = int.Parse(Console.ReadLine());

Fac(n, out int f);

Console.WriteLine("Factorial del número ingresado: " + f);

static void Fac(int n,out int f)
{
    f = 1;
    for (int i = n; i > 1; i--)
    {
        f *= i;
    }
}

// Función recursiva
static void Fac(int n, out int f)
{
    if (n == 1)
    {
        f = n;
    } else
    {
        Fac(n - 1, out f);
        f = n * f;
    }
}