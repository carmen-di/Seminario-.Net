/*12) Definir el tipo de datos enumerativo llamado Meses y utilizarlo para:
a) Imprimir en la consola el nombre de cada uno de los meses en orden inverso (diciembre, noviembre, octubre …, enero)
b) Solicitar al usuario que ingrese un texto y responder si el texto tipeado corresponde al nombre de un mes
Nota: en todos los casos utilizar un for iterando sobre una variable de tipo Meses*/

// inciso a)
for (Meses m = Meses.Diciembre; m >= Meses.Enero; m--)
{
    Console.WriteLine("Mes: " + m);
}

// inciso b)
Console.WriteLine("Ingrese un texto: ");
string texto = Console.ReadLine();

Boolean ok = false;

for (Meses m = Meses.Enero; m <= Meses.Diciembre; m++)
{
    if (m.ToString() == texto)
    {
        ok = true;
    } 
}

String mensaje = ok ? "El texto ingresado es un mes": "No se ingreso un mes";  
Console.WriteLine(mensaje); 

// definimos el tipo meses
enum Meses {
    Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio,
    Agosto, Septiembre, Octubre, Noviembre, Diciembre
}
