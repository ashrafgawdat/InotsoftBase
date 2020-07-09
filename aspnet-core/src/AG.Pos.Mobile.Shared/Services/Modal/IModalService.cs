using System.Threading.Tasks;
using AG.Pos.Views;
using Xamarin.Forms;

namespace AG.Pos.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
