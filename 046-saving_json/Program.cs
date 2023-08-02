using ParseJson;
using System.Text.Json;

var client = new HttpClient();
var uriString = "https://localhost:7151/api/question";


var uri = new Uri(uriString);
var response = await client.GetAsync(uri);
var content = await response.Content.ReadAsStringAsync();

var questions = JsonSerializer.Deserialize<List<Question>>(content);


foreach(var question in questions)
{
    Console.WriteLine(question);
}