using System;

namespace TreeSearch {
    public class Node {
        public int value;
        public Node? left;
        public Node? right;
        public Node? parent;
        public bool visited;

        public Node(int data) {
            value = data;
            left = null;
            right = null;
            parent = null;
            visited = false;
        }

        public void AddNode(Node root) {
            if (root == null) {
                Console.WriteLine("Cannot add, root is null");
                return;
            } else if(root.value == value) {
                Console.WriteLine("Cannot add duplicate value");
                return;
            } else if (value < root.value) {
                if (root.left != null) {
                    AddNode(root.left);
                } else {
                    Console.WriteLine("Adding " + value + " left of " + root.value);
                    parent = root;
                    root.left = this;
                }
            } else if (value > root.value) {
                if (root.right != null) {
                    AddNode(root.right);
                } else {
                    Console.WriteLine("Adding "+ value + " right of " + root.value);
                    parent = root;
                    root.right = this;
                }
            }
        }
    }
}
