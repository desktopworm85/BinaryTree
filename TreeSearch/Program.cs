using System;
using System.Windows.Markup;

namespace TreeSearch {
    class TreeSearch {
        public static int[] values = {5,9,10,2,6,3,8};
        public static int[] sorted = new int[values.Length];
        public static int sortedIndex = 0;

        public static void Main(string[] args) {
            Node? root = null;
            for (int i = 0; i < values.Length; i++) {
                Node n = new Node(values[i]);
                if (root == null) {
                    root = n;
                } else {
                    n.AddNode(root);
                }
            }
        }

        public static void searchTree(Node root) {
            if (root.left == null || (root.visited == true && (root.right != null || root.right.visited != false))) { //Logic not done yet (FINISH THIS...)
                sorted[sortedIndex] = root.value;
                sortedIndex++;
                if (root.right != null && root.right.visited == false) {
                    searchTree(root.right);
                }
            }
            if (root.left != null && root.left.visited == false) {
                searchTree(root.left);
            }
        }
    }
}
