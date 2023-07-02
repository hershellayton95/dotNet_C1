/*
But what if we want to convert Fahrenheit to Celsius as well?
Extend the program so that the user can first choose if they want to convert °C to °F or the other way around.
Oh btw, you can convert Fahrenheit to Celsius by subtracting 32 and multiplying by .5556.
 */

using ConsoleAppMainApplication.Model;

while (true)
{
    string? input = null;
    IConverter converter; ;
    Console.WriteLine("Make a chosen");
    Console.WriteLine("1 - Celsius to Fahrenheit");
    Console.WriteLine("2 - Fahrenheit to Celsius");
    Console.WriteLine("7 - End");
    input = Console.ReadLine();


    switch (input)
    {
        case "1":
            converter = new ToFahrenheitConverter();
            Console.WriteLine(converter.Convert(Input.InputToDouble()));
            break;
        case "2":
            converter = new ToCelsiusConverter();
            Console.WriteLine(converter.Convert(Input.InputToDouble()));
            break;
        case "7":
            Environment.Exit(0);
            return;
        default:
            Console.WriteLine("Incorrect choice\n");
            continue;

    }

}


