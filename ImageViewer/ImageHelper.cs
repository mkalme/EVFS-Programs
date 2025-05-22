using System;
using System.IO;
using System.Drawing;

namespace ImageViewer {
    static class ImageHelper {
        public static Image Resize(this Image image, Size containerSize) {
            int width = containerSize.Width;
            int height = (int)(image.Height * (containerSize.Width / (float)image.Width));

            if (image.Height > containerSize.Width) {
                width = (int)(image.Width * (containerSize.Height / (float)image.Height));
                height = containerSize.Height;
            }

            if (width == 0 || height == 0) return image;

            Bitmap output = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(output)) {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(image, 0, 0, width, height);
            }

            return output;
        }
        public static byte[] ToBytes(this Image image) {
            using (var ms = new MemoryStream()) {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        public static Image ImageFromBytes(byte[] bytes) {
            using (var ms = new MemoryStream(bytes)) {
                try {
                    return Image.FromStream(ms); ;
                } catch {
                    return null;
                }
            }
        }
    }
}
