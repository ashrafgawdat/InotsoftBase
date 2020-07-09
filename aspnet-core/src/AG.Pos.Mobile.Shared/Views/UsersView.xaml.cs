using AG.Pos.Models.Users;
using AG.Pos.ViewModels;
using Xamarin.Forms;

namespace AG.Pos.Views
{
    public partial class UsersView : ContentPage, IXamarinView
    {
        public UsersView()
        {
            InitializeComponent();
        }

        public async void ListView_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            await ((UsersViewModel) BindingContext).LoadMoreUserIfNeedsAsync(e.Item as UserListModel);
        }
    }
}