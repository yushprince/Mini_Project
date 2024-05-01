using System.Threading.Tasks;

namespace _Backend.Hubs.Clients
{
    public interface IGameClient
    {
        Task ReceiveGameResult(string message);
    }
}
