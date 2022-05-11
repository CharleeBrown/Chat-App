using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;




namespace SignalR_App.Hubs
{
    public class talkHub:Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
