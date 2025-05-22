using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace CustomDialogs {
    public class ColorFader {
        public Color StartingColor { get; set; } = SystemColors.HighlightText;
        public Color FinishingColor { get; set; } = Color.FromArgb(35, 35, 35);
        
        public int Milliseconds { get; set; } = 400;
        public int Interval { get; set; } = 33;
        public int InitialInterval { get; set; } = 200;

        private Thread _currentThread;
        private bool _cancel = false;

        public void Fade(Action<Color> fader) {
            _currentThread = new Thread(() => {
                fader(StartingColor);
                Thread.Sleep(InitialInterval);

                Stopwatch watch = new Stopwatch();
                watch.Start();

                long elapsedMil = watch.ElapsedMilliseconds;
                while (!_cancel && elapsedMil <= Milliseconds) {
                    elapsedMil = watch.ElapsedMilliseconds;

                    Color mixedColor = MixColor(elapsedMil / (float)Milliseconds);
                    fader(mixedColor);

                    Thread.Sleep(Interval);
                }

                watch.Stop();
                fader(FinishingColor);

                _cancel = false;
            });

            _currentThread.Start();
        }
        public void Stop() {
            if (!_cancel) {
                _cancel = true;
                _currentThread = null;
            }
        }

        private Color MixColor(float percentage) {
            percentage = percentage < 0 ? 0 : percentage > 1 ? 1 : percentage;

            float r = StartingColor.R + (FinishingColor.R - StartingColor.R) * percentage;
            float g = StartingColor.G + (FinishingColor.G - StartingColor.G) * percentage;
            float b = StartingColor.B + (FinishingColor.B - StartingColor.B) * percentage;

            r = r < 0 ? 0 : r > 255 ? 255 : r;
            g = g < 0 ? 0 : g > 255 ? 255 : g;
            b = b < 0 ? 0 : b > 255 ? 255 : b;

            return Color.FromArgb((int)r, (int)g, (int)b);
        }
    }
}
