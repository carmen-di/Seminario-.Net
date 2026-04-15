/*4) Resolver los errores de compilación en el siguiente fragmento de código. Utilizar el operador as cuando 
sea posible. */

object o = "Hola Mundo!";
string? st = o as string; // el tipo de dato string acepta valores null entonces puedo usar as

int i = 12;
byte b = (byte)i; // puede generar perdida de datos, si el dato a convertir no entra en 1 byte. 
                  // no puedo usar as porque byte no acepta valores null 

double d = i;
float f = (float)d; // no puedo usar as porque byte no acepta valores null

o = i;
i = (int)o + 1;  // //no puedo usar as porque int no acepta valores null