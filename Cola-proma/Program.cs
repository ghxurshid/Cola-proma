using Cola_proma;
using System.Net.Http;
using System.Text;

string url = "https://botmaker.uz/ngapi/api/code6";

HttpClient httpClient = new();

string[] accounts = { "6101632981" };

foreach (string account in accounts)
{
    Console.WriteLine($"{account}\n{{");

    for (int i = 0; i < 10; i ++)
    {
        string code = RandomGenerator.GenerateRandomString();
        //string jsonContent = $"{{\"_auth\":\"query_id=AAHkzZgeAAAAAOTNmB6jNc0P&user=%7B%22id%22%3A{account}%2C%22first_name%22%3A%22%D0%A5%D1%83%D1%80%D1%88%D0%B8%D0%B4%20%D0%A5%D1%83%D0%B6%D0%B0%D0%BC%D0%B0%D1%82%D0%BE%D0%B2%22%2C%22last_name%22%3A%22%22%2C%22language_code%22%3A%22ru%22%2C%22allows_write_to_pm%22%3Atrue%7D&auth_date=1713373037&hash=73f5ba4e26408c5d4e0cc898a688fe1ec66f678bbb8e7fead202662b351b7255\",\"type\":1,\"code\":\"{code}\"}}";
        string jsonContent = $"{{\"_auth\":\"query_id=AAHVh69rAgAAANWHr2uGOjId&user=%7B%22id%22%3A{account}%2C%22first_name%22%3A%22%E2%99%A1%E2%99%A1%E2%99%A1%22%2C%22last_name%22%3A%22%22%2C%22language_code%22%3A%22ru%22%2C%22allows_write_to_pm%22%3Atrue%7D&auth_date=1713375834&hash=89a838037289e0e4080e0ff02fe6e4dd94b5a5c7483d8d56d328035fdcd71648\",\"type\":1,\"code\":\"{code}\"}}";

        HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await httpClient.PostAsync(url, content);

        Console.Write($"   {code}: ");

        if (response.IsSuccessStatusCode)
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            // Обработка ответа
        }
        else
        {
            // Обработка ошибки
            Console.WriteLine("Error occured");
        }

        Thread.Sleep(5000);
    }    

    Console.WriteLine("}\n");
}


