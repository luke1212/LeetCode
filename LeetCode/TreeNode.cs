namespace LeetCode {
  public class Node {
    public int data;
    public Node left;
    public Node right;
    public Node(int d) {
      data = d;
    }
  }

  public class BinaryTree {

    public static Node insert(Node root, int data) {

      if (root == null) root = new Node(data);
      else if (data <= root.data) root.left = insert(root.left, data);
      else if (data > root.data) root.right = insert(root.right, data);
      return root;
    }
  }
}