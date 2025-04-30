using ShadowKey.Enum;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ShadowKey.Extenstions
{
    public static class ImageExtensions
    {
        public static byte[] ToByteArray(this Image image, ImageFormat format)
        {
            if (image == null)
            {
                return null;
            }
            var memoryStream = new MemoryStream();
            image.Save(memoryStream, format);
            return memoryStream.ToArray();
        }

        public static Image SaveImageWithSecret(this Image image, string secret, string filename,ImageFormat imageFormat, StegoKeySize stegoKeySize)
        {

            var bytes = Steganography.HideSecretInImage(image, secret, stegoKeySize, imageFormat);
            File.WriteAllBytes(filename, bytes);
            return bytes.ByteArrayToImage();
        }

        public static string GetSecretFromImage(this Image image,ImageFormat imageFormat, StegoKeySize stegoKeySize)
        {
            return Steganography.GetSecretFromImage(image, imageFormat, stegoKeySize);
        }
    }
}
