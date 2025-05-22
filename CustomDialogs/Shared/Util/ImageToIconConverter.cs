using System;
using System.IO;
using System.Drawing;

namespace CustomDialogs {

    //Remake from https://gist.github.com/darkfall/1656050
    public static class ImageToIconConverter {
        public static Icon Convert(Image image, int width, int height) {
            if (image == null) return null;

            using (MemoryStream outputStream = new MemoryStream()) {
                Bitmap newBitmap = image.Resize(width, height);

                // save the resized png into a memory stream for future use
                MemoryStream memData = new MemoryStream();
                newBitmap.Save(memData, System.Drawing.Imaging.ImageFormat.Png);

                BinaryWriter iconWriter = new BinaryWriter(outputStream);
                // 0-1 reserved, 0
                iconWriter.Write((byte)0);
                iconWriter.Write((byte)0);

                // 2-3 image type, 1 = icon, 2 = cursor
                iconWriter.Write((short)1);

                // 4-5 number of images
                iconWriter.Write((short)1);

                // image entry 1
                // 0 image width
                iconWriter.Write((byte)width);
                // 1 image height
                iconWriter.Write((byte)height);

                // 2 number of colors
                iconWriter.Write((byte)0);

                // 3 reserved
                iconWriter.Write((byte)0);

                // 4-5 color planes
                iconWriter.Write((short)0);

                // 6-7 bits per pixel
                iconWriter.Write((short)32);

                // 8-11 size of image data
                iconWriter.Write((int)memData.Length);

                // 12-15 offset of image data
                iconWriter.Write(6 + 16);

                // write image data
                // png data must contain the whole png data file
                iconWriter.Write(memData.ToArray());

                iconWriter.Flush();

                outputStream.Position = 0;
                return new Icon(outputStream);
            }
        }
    }
}
