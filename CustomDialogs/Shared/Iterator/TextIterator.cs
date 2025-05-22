using System;
using System.Threading;

namespace CustomDialogs {
    public class TextIterator {
        public string BaseText { get; set; } = "Text";
        public string Symbol { get; set; } = ".";
        public int MaxCount { get; set; } = 3;
        public int Interval { get; set; } = 400;

        private bool _cancel = false;
        private Thread _currentThread;

        public void Iterate(Action<string> textIterator) {
            _currentThread = new Thread(() => {
                string text = BaseText;
                int count = 0;

                while (!_cancel) {
                    textIterator(text);

                    count++;
                    if (count == MaxCount + 1) {
                        count = 0;
                        text = BaseText;
                    } else {
                        text = $"{text}{Symbol}";
                    }
                    Thread.Sleep(Interval);
                }

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
    }
}
