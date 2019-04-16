using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode {
  internal class MainClass {
    public static void Main(string[] args) {
      var s = "hello,world";
      Console.Write(s);
      Console.Write("hi");
      Console.ReadLine();
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

  }
}
