using System;

namespace TreeSearch {
    public class Node {
        public int value;
        public Node? left;
        public Node? right;

        public Node(int data) {
            value = data;
            left = null;
            right = null;
        }

        public void AddNode(Node root) {
            if (root == null) {
                Console.WriteLine("Cannot add, root is null");
                return;
            } else if(root.value == value) {
                Console.WriteLine("Cannot add duplicate value");
                return;
            } else if (root.value < value) {
                if (root.left != null) {
                    AddNode(root.left);
                } else {
                    Console.WriteLine("Adding " + value + " left of " + root.value);
                    root.left = this;
                }
            } else if (root.value > value) {
                if (root.right != null) {
                    AddNode(root.right);
                } else {
                    Console.WriteLine("Adding "+ value + " right of " + root.value);
                    root.right = this;
                }
            }
        }
    }
}