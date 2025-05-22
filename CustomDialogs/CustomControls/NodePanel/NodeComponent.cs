using System;

namespace CustomDialogs {
    public class NodeComponent {
        public string Name { get; set; }
        public INode Node { get; set; }

        public NodeComponent(INode node) {
            Name = node.DisplayedText;
            Node = node;
        }

        public bool IsEqual(NodeComponent other) {
            if (Name != other.Name) return false;
            return Node.Node == other.Node.Node;
        }
    }
}
