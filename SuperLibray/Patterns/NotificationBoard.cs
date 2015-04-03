using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperLibray {
    public class NotificationBoard {
        private static NotificationBoard instance;

        private Dictionary<string, object> BoardDict = new Dictionary<string, object>();

        public static NotificationBoard Instance {
            get {
                if (instance == null) {
                    instance = new NotificationBoard();
                }
                return instance;
            }
        }

        public void Add(string notification, object customDelegate) {
            if (customDelegate is Action<string>) {
                Action<string> ff = customDelegate as Action<string>;
            }
        }

        public void Remove(string notification) {

        }

    }
}
