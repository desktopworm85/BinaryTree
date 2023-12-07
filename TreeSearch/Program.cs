using System;

namespace TreeSearch {
    class TreeSearch {
        public static void Main(string[] args) {
            Node? root = null;
            int[] values = {5,9,10,2,6,3,8};
            for (int i = 0; i < values.Length; i++) {
                Node n = new Node(values[i]);
                if (root == null) {
                    root = n;
                } else {
                    n.AddNode(root);
                }
            }
        }
    }
}