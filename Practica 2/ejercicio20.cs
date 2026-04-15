/*20) Codificar el método Swap que recibe 2 parámetros enteros e intercambia sus valores. El cambio debe apreciarse
en el método invocador.*/

Console.WriteLine("Ingrese dos números:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

Swap(ref num1, ref num2);

Console.WriteLine("Número 1: " + num1 + "\nNúmero 2: " + num2);

static void Swap(ref int num1, ref int num2)
{
    int aux = num2;
    num2 = num1;
    num1 = aux;
}