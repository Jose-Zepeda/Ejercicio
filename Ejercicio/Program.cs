static void saludar(String nomsal)
{
    Console.WriteLine($"Un gran saludo a {nomsal}");
}
   
static int Calculo_año_nacimiento (int edad)
{
    int añon = 2023 - edad;
    return añon;
}


////LA DIFERENCIA ENTRE UNA OTRA ESQUE VOID NO DEVUELVE NINGUN VALOR Y SE LE LLAMA METODO, MIENTRAS QUE EL INT EN ESTE CASO DEVUELVE UN VALOR Y SE LE LLAMA FUNCION
//string nombre;
//    int edad;
//    ;

//char letra = 'a';

//Console.Write("Cómo te llamas?");
//nombre = Console.ReadLine();
//saludar(nombre);

//Console.WriteLine($"Hola, gusto en saludarte {nombre}");

//Console.WriteLine("Cuantos años tienes?");
//edad = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Bonita edad:{edad} naciste en {año_nac(edad)}");


static bool palindromo(String palabra)
{
    int longitud = palabra.Lenght;
    string pal = "";

    for (int c = longitud-1; c >= 0; c--)
    {
        pal = pal + palabra[c].ToString().ToUpper();
    }

    if (palabra.Equals(pal))
    {
        return true;
    }
    return false;
}

String palabra;
palabra = "maría";
bool esPalindromo = palindromo("anA");

if (esPalindromo)
{
    Console.WriteLine("Es palindromo");
} else
{
    Console.WriteLine("Nel");
}