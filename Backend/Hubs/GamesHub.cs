using System.Threading.Tasks;
using _Backend.Hubs.Clients;
using Microsoft.AspNetCore.SignalR;

namespace _Backend.Hubs
{
    public class GamesHub : Hub<IGameClient>
    {
        public async Task SendGameResult(string result)
        {
            await Clients.All.ReceiveGameResult(result);
        }
    }
}
