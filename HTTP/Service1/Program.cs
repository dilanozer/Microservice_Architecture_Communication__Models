HttpClient httpClient = new();
HttpResponseMessage responseMessage = await httpClient.GetAsync("https://localhost:7165/api/values");
if (responseMessage.IsSuccessStatusCode)
{
    Console.WriteLine(await responseMessage.Content.ReadAsStringAsync());
}


