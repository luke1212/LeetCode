﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode {
  internal class MainClass {
    
    public static void Main(string[] args) {

      BinaryTree tree = new BinaryTree();

      /* Assume that inorder traversal  
         of following tree is given  
          40  
          / \  
      10     30  
      /         \  
      5         28 */
      int[] inorder = new int[] { 5, 10, 40, 30, 28 };
      int len = inorder.Length;
      Node mynode = tree.buildTree(inorder, 0,
                                   len - 1, tree.root);

      /* Let us test the built tree by  
         printing Inorder traversal */
      Console.WriteLine("Inorder traversal of " +
                     "the constructed tree is ");
      Console.Read();
      tree.printInorder(mynode);
    }

    // problem 3
    public string ToLowerCase(string str) {
      return str.ToLower();
    }
    //this is just a test

    public int NumUniqueEmails(string[] emails) {
      if (emails == null || emails.Length == 0)
        return 0;

      var hashset = new HashSet<string>();

      foreach (var email in emails) {
        var splitedEmail = email.Split('@');
        var domaiName = splitedEmail[1];
        var userName = splitedEmail[0];
        var shapedUserName = userName.Split('+');
        var splittedUserName = shapedUserName[0];
        var splitWithDot = splittedUserName.Split('.');
        var finalUserName = String.Join("", splitWithDot);
        hashset.Add(userName + "@" + domaiName);
      }
      return hashset.Count;
    }

    // 1021
    public string RemoveOuterParentheses(string parentheses) {
      var leftCount = 0;
      var rightCount = 0;
      var startIndex = 0;
      var parenthesesCharArray = parentheses.ToCharArray();
      for (int i = 0; i < parenthesesCharArray.Length; i++) {
        if (parenthesesCharArray[i] == '(') {
          if (leftCount == rightCount)
            startIndex = i;
          leftCount++;
        } else {
          rightCount++;
          if (leftCount == rightCount) {
            parenthesesCharArray[startIndex] = '*';
            parenthesesCharArray[i] = '*';
          }
        }
      }
      return new string(parenthesesCharArray.Where(x => x != '*').ToArray());
    }

    // 807
    public static int MaxIncreaseKeepingSkyline(int[,] grid) {
      int row = grid.GetLength(0);
      int col = grid.GetLength(1);
      int[] row_Max = new int[row];
      int[] col_Max = new int[col];
      int[,] newArray = new int[row, col];
      int sum = 0;

      for (int i = 0; i < row; i++) {
        for (int j = 0; j < col; j++) {
          if (grid[i, j] >= col_Max[i]) {
            col_Max[i] = grid[i, j];
          }
          if (grid[i, j] >= row_Max[j]) {
            row_Max[j] = grid[i, j];
          }
        }
      }

      for (int i = 0; i < row; i++) {
        for (int j = 0; j < col; j++) {
          if (row_Max[i] <= col_Max[j]) {
            newArray[i, j] = row_Max[i];
            sum += newArray[i, j] - grid[i, j];
          } else {
            newArray[i, j] = col_Max[j];
            sum += newArray[i, j] - grid[i, j];
          }
        }
      }
      return sum;
    }

    //938
    public static int RangeSumBST(Node root, int L, int R) {
      var totalSum = 0;
      Node current; 

      var que = new Queue<Node>();
      que.Enqueue(root);

      while (que.Count() > 0) {
        current = que.Dequeue();
        if (current.data >= L && current.data <= R) {
          totalSum += current.data;

          if (current.left != null) {
            que.Enqueue(current.left);
          }
          if (current.right != null) {
            que.Enqueue(current.right);
          }
        } else if (current.data < L) {
          if (current.right != null)
            que.Enqueue(current.right);
        } else if (current.data > R) {
          if (current.left != null)
            que.Enqueue(current.left);
        }
      }

      return totalSum;
    }
  // 654 https://www.geeksforgeeks.org/construct-binary-tree-from-inorder-traversal/

    // 402. Remove K Digits
    public string RemoveKdigits(string num, int k){
                if(num.Length == 0)
                {
                    return "";
                }

                return "";
            }

        // 1038
        private static int sum = 0;
        public static Node BstToGst(Node root)
        {
            RightNodeLeft(root);
            return root;
        }
        
        private static void RightNodeLeft(Node root)
        {

            if (root == null) return;
            RightNodeLeft(root.right);
            sum = sum + root.data;
            root.data = sum;
            RightNodeLeft(root.left);
        }
    }
}

