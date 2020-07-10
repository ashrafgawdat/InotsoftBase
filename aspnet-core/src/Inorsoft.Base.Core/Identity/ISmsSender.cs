using System.Threading.Tasks;

namespace Inorsoft.Base.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}