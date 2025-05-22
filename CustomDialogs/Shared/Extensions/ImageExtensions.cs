using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CustomDialogs {
    public static class ImageExtensions {
        public static Bitmap Resize(this Image image, int width, int height, InterpolationMode interpolationMode = InterpolationMode.NearestNeighbor) {
            var res = new Bitmap(width, height);

            using (var graphic = Graphics.FromImage(res)) {
                graphic.InterpolationMode = interpolationMode;
                graphic.SmoothingMode = SmoothingMode.HighQuality;
                graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphic.CompositingQuality = CompositingQuality.HighQuality;
                graphic.DrawImage(image, 0, 0, width, height);
            }

            return res;
        }
    }
}
