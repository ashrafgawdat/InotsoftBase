using System.Threading.Tasks;

namespace AG.Pos.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}