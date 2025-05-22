using System;
using System.Collections.Generic;

namespace CustomDialogs {
    public class ViewCache<TCache> where TCache : new() {
        public IDictionary<IView, TCache> Cache { get; set; }

        public ViewCache() {
            Cache = new Dictionary<IView, TCache>();
        }

        public TCache GetCache(IView view) {
            if (!Cache.TryGetValue(view, out TCache cache)) {
                cache = new TCache();

                Add(view, cache);
            }

            return cache;
        }
        public void SetCache(IView view, TCache cache) {
            if (!Cache.ContainsKey(view)) {
                Add(view, cache);
            } else {
                Cache[view] = cache;
            }
        }

        public void Add(IView view, TCache cache) {
            view.Replaced += View_Replaced;
            Cache.Add(view, cache);
        }
        public void Remove(IView view) {
            view.Replaced -= View_Replaced;
            Cache.Remove(view);
        }

        private void View_Replaced(object sender, EventArgs e) {
            Remove(sender as IView);
        }
    }
}
