using System;

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

    public Node root;

    public static Node Insert(Node root, int data) {

      if (root == null) root = new Node(data);
      else if (data <= root.data) root.left = Insert(root.left, data);
      else if (data > root.data) root.right = Insert(root.right, data);
      return root;
    }

    public virtual Node buildTree(int[] inorder, int start,
                             int end, Node node) {
      if (start > end) {
        return null;
      }

      /* Find index of the maximum  
      element from Binary Tree */
      int i = max(inorder, start, end);

      /* Pick the maximum value and 
      make it root */
      node = new Node(inorder[i]);

      /* If this is the only element in  
      inorder[start..end], then return it */
      if (start == end) {
        return node;
      }

      /* Using index in Inorder traversal,  
      construct left and right subtress */
      node.left = buildTree(inorder, start,
                            i - 1, node.left);
      node.right = buildTree(inorder, i + 1,
                             end, node.right);

      return node;
    }

    /* UTILITY FUNCTIONS */

    /* Function to find index of the 
    maximum value in arr[start...end] */
    public virtual int max(int[] arr,
                           int strt, int end) {
      int i, max = arr[strt], maxind = strt;
      for (i = strt + 1; i <= end; i++) {
        if (arr[i] > max) {
          max = arr[i];
          maxind = i;
        }
      }
      return maxind;
    }

    /* This funtcion is here just  
       to test buildTree() */
    public virtual void printInorder(Node node) {
      if (node == null) {
        return;
      }

      /* first recur on left child */
      printInorder(node.left);

      /* then print the data of node */
      Console.Write(node.data + " ");

      /* now recur on right child */
      printInorder(node.right);
    }
  }
}