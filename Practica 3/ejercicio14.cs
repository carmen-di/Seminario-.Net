/*14) Utilizar la clase Queue<T> para implementar un programa que realice el cifrado de un texto
aplicando la técnica de clave repetitiva. La técnica de clave repetitiva consiste en desplazar un carácter
una cantidad constante de acuerdo a la lista de valores que se encuentra en la clave.*/

Dictionary<char, int> letraANumero = new Dictionary<char, int>();
Dictionary<int, char> numeroALetra = new Dictionary<int, char>();

string alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ "; // Notar el espacio al final
for (int i = 0; i < alfabeto.Length; i++)
{
    char letra = alfabeto[i];
    int numero = i + 1; // Porque empezamos en 1, no en 0
            
    letraANumero[letra] = numero;
    numeroALetra[numero] = letra;
}

int[] clave = {5, 3, 9, 7};
string mensaje = "HOLA MUNDO";

string cifrado = Cifrar(mensaje, clave);
Console.WriteLine("Mensaje Cifrado: " + cifrado); 

string descifrado = Descifrar(cifrado, clave);
Console.WriteLine("Mensaje Descifrado: " + descifrado); 

// Método cifrar
static string Cifrar(string texto, int[] claveArray)
{
    Queue<int> colaClave = new Queue<int>(claveArray);
    string resultado = "";

    foreach (char c in texto)
    {
        // 1. Obtener número de la letra original
        int numLetra = letraANumero[c];
        // 2. Sacar un número de la clave y volverlo a poner al final
        int numClave = colaClave.Dequeue();
        colaClave.Enqueue(numClave);
        // 3. Sumar
        int suma = numLetra + numClave;
        // 4. Si se pasa de 28, volvemos a empezar (ej: 33 - 28 = 5)
        if (suma > 28)
        {
            suma -= 28;
        }
        // 5. Convertir a letra y agregar al resultado
        resultado += numeroALetra[suma];
    }
    return resultado;
}

//Método decifrar
static string Descifrar(string texto, int[] claveArray)
{
    Queue<int> colaClave = new Queue<int>(claveArray);
    string resultado = "";

    foreach (char c in texto)
    {
        int numLetra = letraANumero[c];

        int numClave = colaClave.Dequeue();
        colaClave.Enqueue(numClave);
        // Para descifrar, RESTAMOS en lugar de sumar
        int resta = numLetra - numClave;
        // Si la resta da 0 o negativo, damos la vuelta hacia atrás (ej: 0 + 28 = 28)
        if (resta < 1)
        {
            resta += 28;
        }
        resultado += numeroALetra[resta];
    }
    return resultado;
}