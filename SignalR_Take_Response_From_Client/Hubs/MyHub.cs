using Microsoft.AspNetCore.SignalR;

namespace SignalR_Take_Response_From_Client.Hubs
{
    public class MyHub:Hub
    {
        public async Task SendMessageAsync(string message,string connectionId)
        {
            string log =  await Clients.Client(connectionId).InvokeAsync<string>("receive",message,new CancellationToken());
            await Clients.All.SendAsync("receive",message);
            //logging, db operations etc
            Console.WriteLine(log);
        }
    }
}
