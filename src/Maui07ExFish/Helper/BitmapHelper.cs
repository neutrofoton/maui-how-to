using System;
using SkiaSharp;

namespace Maui07ExFish.Helper
{
    public static class BitmapHelper
    {
        static HttpClient httpClient = new HttpClient();

        public static async Task<SKBitmap> LoadBitmapFromUrl(string url)
        {
            using (Stream stream = await httpClient.GetStreamAsync(url))
            using (MemoryStream memStream = new MemoryStream())
            {
                await stream.CopyToAsync(memStream);
                memStream.Seek(0, SeekOrigin.Begin);
                SKBitmap webBitmap = SKBitmap.Decode(memStream);
                return webBitmap;
            }
        }
    }
}
