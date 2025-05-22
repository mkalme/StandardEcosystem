using System;
using System.Collections.Generic;

namespace CustomDialogs {
    public class NodeProfile {
        public List<NodeComponent> NodeComponents { get; set; }

        public NodeProfile() {
            NodeComponents = new List<NodeComponent>();
        }

        public static NodeProfile FromNode(INode node) {
            NodeProfile output = new NodeProfile();

            var item = node;

            while (item != null) {
                output.NodeComponents.Add(new NodeComponent(item));
                item = item.Parent;
            }

            output.NodeComponents.Reverse();

            return output;
        }

        public int GetFirstUncommonIndex(NodeProfile otherProfile) {
            int min = Math.Min(NodeComponents.Count, otherProfile.NodeComponents.Count);

            for (int i = 0; i < min; i++) {
                if (!NodeComponents[i].IsEqual(otherProfile.NodeComponents[i])) return i;
            }

            return -1;
        }
    }
}
