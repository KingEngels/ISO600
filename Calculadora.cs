

Console.WriteLine("Hola humano inservible");
Console.WriteLine("Escribe el primer numero para calcular:");

decimal num1;
while (true)
{
    try
    {
        num1 = Convert.ToDecimal(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Numero invalido. Intenta de nuevo:");
    }
}

Console.WriteLine("Escribe el segundo numero para calcular:");

decimal num2;
while (true)
{
    try
    {
        num2 = Convert.ToDecimal(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Numero invalido. Intenta de nuevo:");
    }
}

Console.WriteLine("Selecciona la operacion (+, -, *, /):");
string operacion = Console.ReadLine() ?? "";

decimal resultado;

switch (operacion)
{
    case "+":
        resultado = num1 + num2;
        break;
    case "-":
        resultado = num1 - num2;
        break;
    case "*":
        resultado = num1 * num2;
        break;
    case "/":
        if (num2 == 0)
        {
            Console.WriteLine("No se puede dividir entre cero.");
            return;
        }
        resultado = num1 / num2;
        break;
    default:
        Console.WriteLine("Operacion no valida.");
        return;
}

Console.WriteLine($"El resultado es: {resultado}");




