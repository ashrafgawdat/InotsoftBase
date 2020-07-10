using Xamarin.Forms.Internals;

namespace Inorsoft.Base.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}