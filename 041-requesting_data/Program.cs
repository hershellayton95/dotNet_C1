/*
Create a Console Application,
the application should prompt the user for a URL.
After the URL is supplied,
the application should print out the response headers and content.
*/

Console.WriteLine("Inserisci l'URL:");
string url = Console.ReadLine();


var request = new Requesting();
var response = await request.RequestingData(url);
request.GetHeader(response);
request.GetBody(response);


class Requesting
{
    public async Task<HttpResponseMessage?> RequestingData(string url)
    {
        var httpClient = new HttpClient();
        var uri = new Uri(url);
        var response = await httpClient.GetAsync(uri);

        return response;
    }

    public async Task GetHeader(HttpResponseMessage? response)
    {
        Console.WriteLine($"STATUS: {(int)response.StatusCode} - {response.StatusCode}");
        Console.WriteLine("HEADERS: ");
        foreach (var header in response.Headers)
        {
            Console.WriteLine($"{header.Key}={string.Join(", ", header.Value)}");
        }
        var result = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"Lenght: {result.Length}");
        Console.WriteLine(result);
    }

    public async Task GetBody(HttpResponseMessage? response)
    {
        var result = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"Lenght: {result.Length}");
        Console.WriteLine(result);
    }
}