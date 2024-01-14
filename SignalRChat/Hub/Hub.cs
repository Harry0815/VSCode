using Microsoft.AspNetCore.SignalR;
using SignalRChat.Daten;
using System.Text.Json;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            var daten = new Msg {
                User = user,
                Message = message
                
            };

            await Clients.All.SendAsync("ReceiveMessage", user, JsonSerializer.Serialize(daten));
        }
    }
}