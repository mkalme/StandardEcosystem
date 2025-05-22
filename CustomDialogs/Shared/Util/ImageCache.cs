using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CustomDialogs {
    public class ImageCache {
        public InterpolationMode InterpolationMode { get; set; } = InterpolationMode.HighQualityBicubic;

        private IDictionary<string, Image> _imageCache = new Dictionary<string, Image>();

        public Image GetImage(string name, Image defaultImage, int width, int height) {
            if (!_imageCache.TryGetValue(name, out Image image)) {
                image = defaultImage.Resize(width, height, InterpolationMode);
                _imageCache.Add(name, image);
            }

            return image;
        }
    }
}
