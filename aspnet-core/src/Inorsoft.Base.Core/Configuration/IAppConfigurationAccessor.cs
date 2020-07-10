using Microsoft.Extensions.Configuration;

namespace Inorsoft.Base.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
