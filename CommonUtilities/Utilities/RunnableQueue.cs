using System;
using System.Threading;

namespace CommonUtilities {
    public class RunnableQueue {
        public ObservableList<(string, Action)> Queue { get; } = new ObservableList<(string, Action)>();

        public bool Running => _running;
        private bool _running = false;

        public (string, Action) CurrentAction => _currentAction;
        private (string, Action) _currentAction;

        public RunnableQueue() {
            Queue.OnItemsAdd += (sender, items) => Run();
        }

        public void ExecuteSafely(string name, Action action) {
            for (int i = 0; i < Queue.Count; i++) {
                if (Queue[i].Item1 == name) return;
            }

            Queue.Add((name, action));
        }
        private void Run() {
            if (_running) return;

            _running = true;
            new Thread(() => {
                while (Queue.Count > 0) {
                    _currentAction = Queue[0];
                    Queue.RemoveAt(0);

                    _currentAction.Item2();
                }

                _currentAction = (null, null);
                _running = false;
            }).Start();
        }
    }
}
