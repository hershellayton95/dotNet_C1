/*
But what if we want to convert Fahrenheit to Celsius as well?
Extend the program so that the user can first choose if they want to convert °C to °F or the other way around.
Oh btw, you can convert Fahrenheit to Celsius by subtracting 32 and multiplying by .5556.
 */

while (true)
{
    Console.WriteLine("Make a chosen");
    Console.WriteLine("1 - Celsius to Fahrenheit");
    Console.WriteLine("2 - Fahrenheit to Celsius");
    Console.WriteLine("7 - Fine");
    string? input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine(ConvertCelsiusToFahrenheit(InputToNumber()) + " F\n");
            break;
        case "2":
            Console.WriteLine(ConvertFahrenheitToCelsius(InputToNumber()) + " C\n");
            break;
        case "7":
            Environment.Exit(0);
            return;
        default:
            Console.WriteLine("Scelta non corretta\n");
            continue;

    }

}


double InputToNumber()
{
    string? input = null;
    double num = 0d;
    bool parseBool = false;

    Console.WriteLine("Inserisci un numero");
    input = Console.ReadLine();
    Console.WriteLine("Il rusultato è");
    parseBool = double.TryParse(input, out num);

    if (parseBool)
    {
        return num;
    }
    else
    {
        throw new Exception("number not valid");
    }

}

double ConvertCelsiusToFahrenheit(double celsius)
{
    return (celsius * 1.8) + 32;
}

double ConvertFahrenheitToCelsius(double fahrenheit)
{
    return (fahrenheit - 32) / 1.8;
}