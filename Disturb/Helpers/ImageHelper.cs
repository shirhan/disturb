using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Disturb.Helpers
{
    public static class ImageHelper
    {
        const int MinHeight = 100;
        const int MaxHeight = 600;
        const int MinWidth = 100;
        const int MaxWidth = 600;

        public static bool ValidateImage(HttpPostedFileBase file)
        {
            try
            {
                using (Image img = Image.FromStream(file.InputStream))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        public static void SaveImage(HttpPostedFileBase file, string filePath)
        {
            try
            {
                using (Image img = Image.FromStream(file.InputStream))
                {
                    int width = img.Width;
                    int height = img.Height;


                    if (width > MaxWidth) width = MaxWidth;
                    if (width < MinWidth) width = MinWidth;

                    if (height > MaxHeight) height = MaxHeight;
                    if (height < MinHeight) height = MinHeight;

                    using (var newImage = new Bitmap(width, height))
                    using (var graphics = Graphics.FromImage(newImage))
                    using (var stream = new MemoryStream())
                    {
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        graphics.DrawImage(img, new Rectangle(0, 0, width, height));
                        newImage.Save(filePath, ImageFormat.Png);
                    }

                }
            }
            catch
            {

            }
        }
    }
}