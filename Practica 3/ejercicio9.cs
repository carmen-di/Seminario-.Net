/*9) ¿Qué líneas del siguiente método provocan error de compilación y por qué?*/

var a = 3L;
dynamic b = 32;
object obj = 3;
a = a * 2.0;    // Error: se intenta multiplicar un tipo LONG y un DOUBLE, no puedo convertir implícitamente un tipo double en un tipo long.
b = b * 2.0;
b = "hola";
obj = b;
b = b + 11;
obj = obj + 11; // Error: el operador + no se puede aplicar a operandos del tipo object e int.
var c = new { Nombre = "Juan" };
var d = new { Nombre = "María" };
var e = new { Nombre = "Maria", Edad = 20 };
var f = new { Edad = 20, Nombre = "Maria" };
f.Edad = 22;    // Error: el tipo anonimo es de solo lectura, no puedo asignarle un valor.
d = c;
e = d;          // Error: no puedo convertir implicitamente el tipo en <anonymous type: string Nombre, int Edad>.
f = e;          // Error: no puedo convertir implicitamente el tipo <anonymous type: string Nombre, int Edad> en <anonymous type: int Edad, string Nombre>.