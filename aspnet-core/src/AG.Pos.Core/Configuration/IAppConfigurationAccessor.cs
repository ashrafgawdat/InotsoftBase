using Microsoft.Extensions.Configuration;

namespace AG.Pos.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
