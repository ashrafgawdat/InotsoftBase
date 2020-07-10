using System.Threading.Tasks;
using Inorsoft.Base.Views;
using Xamarin.Forms;

namespace Inorsoft.Base.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
