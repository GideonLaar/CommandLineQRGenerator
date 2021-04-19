using System.Drawing;
using System.Drawing.Imaging;
using QRCoder;

namespace QRGenerator.Methods
{
    public class GenerateURL
    {
        public Bitmap CreateWithoutImage(string url)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            PayloadGenerator.Url payload = new PayloadGenerator.Url(url);
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White, true);
            return qrCodeImage;
        }

        public Bitmap CreateWithImage(string url, string path)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            PayloadGenerator.Url payload = new PayloadGenerator.Url(url);
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White, (Bitmap)Bitmap.FromFile(path));
            return qrCodeImage;
        }
    }
}