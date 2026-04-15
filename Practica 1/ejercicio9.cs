/*9) Escribir un programa que lea dos palabras separadas por un blanco que  terminan con <ENTER>, y determinar si 
son simétricas (Ej: 'abbccd' y 'dccbba' son simétricas).
Tip: si st es un string, entonces st[0] devuelve el primer carácter de st, y st[st.Length-1] devuelve el último 
carácter de st. */

Console.WriteLine("Ingrese dos palabras:");

string st = Console.ReadLine();

int espacio = 0;

// buscar el espacio
while (st[espacio] != ' ')
{
    espacio++;
}

bool simetrica = true;

int i = 0;

while (i < espacio && simetrica)
{
    if (st[i] != st[st.Length - 1 - i])
    {
        simetrica = false;
    }
    i++;
}

if (simetrica)
{
    Console.WriteLine("Son simétricas");
}
else
{
    Console.WriteLine("No son simétricas");
}