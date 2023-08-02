var client = new HttpClient();
var uriString = "https://localhost:7151/api/question";


var uri = new Uri(uriString);
var response = await client.GetAsync(uri);
var content = await response.Content.ReadAsStringAsync();

File.WriteAllText("../../../questions.json", content);