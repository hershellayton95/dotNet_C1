/*
We want a calculator that can convert from Celcius to Fahrenheit. To convert from Celsius to Fahrenheit, multiply by 1.8 and add 32.
 */


double ConvertCelsiusToFahrenheit(double celsius)
{
    return (celsius * 1.8) + 32;
}

Console.WriteLine(ConvertCelsiusToFahrenheit(5));