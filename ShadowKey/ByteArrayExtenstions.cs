using System.Drawing;
using System.IO;

namespace ShadowKey.Extenstions
{
    public static class ByteArrayExtensions
    {
        public static Image ByteArrayToImage(this byte[] imageBytes)
        {
            return imageBytes == null ? null : Image.FromStream(new MemoryStream(imageBytes));
        }
    }
}
