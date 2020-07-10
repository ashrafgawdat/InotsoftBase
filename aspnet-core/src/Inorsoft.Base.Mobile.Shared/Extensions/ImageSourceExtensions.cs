using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inorsoft.Base.Extensions
{
    public static class ImageSourceExtensions
    {
        public static async Task<Stream> GetSourceStreamAsync(this ImageSource imageSource)
        {
            return await ((StreamImageSource)imageSource).Stream(CancellationToken.None);
        }
    }
}