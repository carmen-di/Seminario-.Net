/*18) Escribir una función (método int Fac(int n)) que calcule el factorial de un número n pasado al programa como
parámetro por la línea de comando
a) Definiendo una función no recursiva
b) Definiendo una función recursiva
c) idem a b) pero con expression-bodied methods (Tip: utilizar el operador condicional ternario)*/

// a) Definiendo una función no recursiva

static int Fac(int n)
{
    int fac = 1;
    for (int i = n; i >= 1; i--)
    {
        fac *= i;
    }
    return fac;
}

Console.WriteLine("Ingrese un número:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Factorial del número ingresado: " + Fac(n));

// b) Definiendo una función recursiva
static int Fac(int n)
{
    if (n == 1)
    {
        return n;
    } else
    {
        return n * Fac(n - 1);
    }
}

// c) Con expression-bodied methods
static int Fac(int n) => n == 1 ? 1 : n * Fac(n - 1);