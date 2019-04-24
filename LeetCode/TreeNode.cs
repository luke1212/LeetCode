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

    public static Node Insert(Node root, int data) {

      if (root == null) root = new Node(data);
      else if (data <= root.data) root.left = Insert(root.left, data);
      else if (data > root.data) root.right = Insert(root.right, data);
      return root;
    }
  }
}