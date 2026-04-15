/*16) ¿Qué salida por la consola produce el siguiente código?*/

int x = 0;
try
{
    Console.WriteLine(1.0 / x);
    Console.WriteLine(1 / x);
    Console.WriteLine("todo OK");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

// ¿Qué se puede inferir respecto de la excepción división por cero en relación al tipo de los operandos?

/*Salida por consola: Attempted to divided by zero. Esto se debe a que no se puede dividir por cero. 
La linea que genera una excepcion es Console.WriteLine(1 / x); ya que estoy tratando de dividir un 
entero por cero. La linea Console.WriteLine(1.0 / x); trato de dividir un real por cero lo que devuelve infinito*/