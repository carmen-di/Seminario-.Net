/*18) Cuál es la salida por consola del siguiente programa:*/

try
{
    Metodo1();
}
catch
{
    Console.WriteLine("Método 1 propagó una excepción no tratada");
}
try
{
    Metodo2();
}
catch
{
    Console.WriteLine("Método 2 propagó una excepción no tratada");
}
try
{
    Metodo3();
}
catch
{
    Console.WriteLine("Método 3 propagó una excepción");
}

void Metodo1()
{
    object obj = "hola";
    try
    {
        int i = (int)obj;
    }
    finally
    {
        Console.WriteLine("Bloque finally en Metodo1");
    }
}

void Metodo2()
{
    object obj = "hola";
    try
    {
        int i = (int)obj;
    }
    catch (OverflowException)
    {
        Console.WriteLine("Overflow");
    }
}

void Metodo3()
{
    object obj = "hola";
    try
    {
        int i = (int)obj;
    }
    catch (InvalidCastException)
    {
        Console.WriteLine("Excepción InvalidCast en Metodo3");
        throw;
    }
}

/*Salida por consola:
Bloque finally en Metodo1
Método 1 propagó una excepción no tratada
Método 2 propagó una excepción no tratada
Excepción InvalidCast en Metodo3
Método 3 propagó una excepción*/

/*Bloque finally en Metodo1: en el Método 1 se produce una excepción por querer castear un string como si fuera int. Como este método no posee un manejador catch, se produce primero el finally dentro del método.
Método 1 propagó una excepción no tratada: Esta es la propagación del error del punto anterior siendo manejada por el catch dentro del Main.
Método 2 propagó una excepción no tratada: El Método 2 realiza la misma acción que desencadena en una excepción, a diferencia del Metodo 1 este tiene un manejador catch, pero el mismo esta destinado a tratar con excepciones tipo OverflowException. Por lo tanto, la excepción será manejada en el catch correspondiente en el Main.
Excepción InvalidCast en Metodo3: El Método 3 si posee un catch especializado en la excepción InvalidCastException**.
Método 3 propagó una excepción: Dentro del manejador catch en el método 3, hay una propagación (throw) que lo envía a ser manejado por el método que lo llamó. En este caso, se ve en el catch correspondiente del método Main.*/