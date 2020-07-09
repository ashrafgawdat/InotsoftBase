using Xamarin.Forms.Internals;

namespace AG.Pos.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}