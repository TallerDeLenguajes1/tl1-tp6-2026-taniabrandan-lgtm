//9Console.WriteLine("Hello, World!");

//int a;
//int b;
//a =10;
//b =a;

//Console.WriteLine("valor de a:"+a);
//Console.WriteLine("valor de b:"+b);


// PUNTO I 


// Ingresar un número
Console.WriteLine("Ingrese un número:");
string entrada = Console.ReadLine();

// Convertir el texto a número entero

// TryParse devuelve true si pudo convertir o false si no

int numero;
bool esValido = int.TryParse(entrada, out numero);

// Vemos que no sea un numero invalido

if (!esValido)
{
    Console.WriteLine("Lo que ingresaste no es un número válido.");
}
// Numero menos de 0
else if (numero <= 0)
{
    Console.WriteLine("El número debe ser mayor a 0.");
}
// Si esta todo ok, invertimos
else
{
    // Invertir el número
    int invertido = 0;
    int aux = numero;

    while (aux > 0)
    {
        int digito = aux % 10;      // obtenemos el último dígito
        invertido = invertido * 10 + digito;  // lo "pegamos" al resultado
        aux = aux / 10;             // descartamos el último dígito
    }

    Console.WriteLine("Número invertido: " + invertido);
}