using Microsoft.AspNetCore.SignalR.Client;


HubConnection conn = new HubConnectionBuilder()
                        .WithUrl("https://localhost:7082/myhub")
                        .WithAutomaticReconnect()
                        .Build();
await conn.StartAsync();

Console.WriteLine($"ConnectionId : {conn.ConnectionId}");

conn.On<string, string>("receive", message =>
{
    Console.WriteLine($"Message : {message}");
    return $"Client_OK -  ClientId: {conn.ConnectionId}";
});
while (true)
{
    if (Console.ReadKey().Key == ConsoleKey.M)
    {
        Console.WriteLine("Write ConnId");
        Console.WriteLine("Connection Id : ");
        string connId = Console.ReadLine() ?? "";
        Console.WriteLine("Send Message");
        Console.WriteLine("Message : ");
        string message = Console.ReadLine() ?? "";
        Console.WriteLine();
        await conn.InvokeAsync("SendMessageAsync", message,connId);
    }
}

