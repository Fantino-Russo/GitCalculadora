float resultado = 0;
float num1 = 0;
float num2 = 0;
bool invalido = false;
int seguir = 2;

Console.WriteLine("Bienvenido a la calculadora!");

do
{
    Console.WriteLine("Ingrese la cantidad de numeros que desea calcular: ");
    int Cantidad = Convert.ToInt32(Console.ReadLine());
    if (Cantidad < 1)
    {
        Console.WriteLine("Numero imposible para calculo, estableciendo a 2 numeros");
        Cantidad = 2;
    }
    var numeros = new List<float> { };
    for (int i = 0; i < Cantidad; i++)
    {

        Console.WriteLine($"Ingrese el numero {i + 1} que desea añadir al calculo: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Ingrese el siguiente numero: ");
        //num2 = Convert.ToInt32(Console.ReadLine());
        numeros.Add(num1);
    }
    //if (seguir != 1)
    //{
    //    Console.WriteLine("Para comenzar ingrese el primer numero: ");
    //    num1 = Convert.ToInt32(Console.ReadLine());
    //}
    //else
    //{
    //    num1 = resultado;
    //}
    //Console.WriteLine("Ingrese el siguiente numero: ");
    //num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el operador que va a utilizar: ");
    string operador = Console.ReadLine();
    resultado = numeros[0];
    for (int i = 1; i < numeros.Count; i++)
        switch (operador)
        {
            case "+":
                resultado = Suma(resultado, numeros[i]);
                break;
            case "-":
                resultado = Resta(resultado, numeros[i]);
                break;
            case "*":
                resultado = Multiplicacion(resultado, numeros[i]);
                break;

            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Divicion por 0 es imposible");
                    invalido = true;
                }
                else
                {
                    resultado = Divicion(resultado, numeros[i]);
                }
                break;


            default:
                Console.WriteLine("La calculadora no posee esa funcion, intente un operdor valido como +, -, *, /");
                invalido = true;
                break;

        }


    if (!invalido)
        Console.WriteLine($"El resultado de la operacion es: {resultado}");
    else
    {
        invalido = false;
    }
    Console.WriteLine("Desea seguir la operacion? " + Environment.NewLine +
        "1 realizar otra operacion " + Environment.NewLine +
        "2 para terminar el programa");
    seguir = Convert.ToInt32(Console.ReadLine());
} while (seguir == 1);
Console.WriteLine("Finalizando, Gracias por utilizar la calculadora");

float Suma(float n1, float n2)
{

    return n1 += n2;
}

float Resta(float n1, float n2)
{
    return n1 -= n2;
}

float Multiplicacion(float n1, float n2)
{
    return n1 *= n2;
}

float Divicion(float n1, float n2)
{
    return n1 /= n2;
}