using System.Threading.Tasks;
using AG.Pos.UiCustomization;

namespace AG.Pos.Tests.UiCustomization
{
    public class NullUiThemeCustomizerFactory : IUiThemeCustomizerFactory
    {
        public async Task<IUiCustomizer> GetCurrentUiCustomizer()
        {
            return new NullThemeUiCustomizer();
        }

        public IUiCustomizer GetUiCustomizer(string theme)
        {
            return new NullThemeUiCustomizer();
        }
    }
}
