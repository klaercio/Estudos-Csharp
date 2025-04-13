using (HttpClient client = new HttpClient()) {
    try {
        string result = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deal");
        Console.WriteLine(result);
    }catch (Exception err) {
        Console.WriteLine($"Recebemos o seguinte erro: {err.Message}");
    }
}