/*13) Utilizar la clase Stack<T> (pila) para implementar un programa que pase un número en base 10 a otra base 
realizando divisiones sucesivas. Por ejemplo para pasar 35 en base 10 a binario dividimos sucesivamente por dos
hasta encontrar un cociente menor que el divisor, luego el resultado se obtiene leyendo de abajo hacia arriba
el cociente de la última división seguida por todos los restos.*/

static string DecimalABinario(int numero)
{
    if (numero == 0) return "0";

    Stack<int> pila = new Stack<int>();

    while (numero > 0)
    {
        pila.Push(numero % 2);
        numero /= 2;
    }

    string resultado = "";

    while (pila.Count > 0)
    {
        resultado += pila.Pop();
    }

    return resultado;
}

Console.WriteLine("Ingrese un número:");
int n = int.Parse(Console.ReadLine());

string binario = calcularBinario(n);

Console.WriteLine($"El numero {n} en binario es: {binario}");