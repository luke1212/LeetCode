using System;
using System.Collections.Generic;

namespace LeetCode
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var s = "hello,world";
            Console.WriteLine(s);

        }

        // problem 3
        public string ToLowerCase(string str)
        {
            return str.ToLower();
        }
        //this is just a test

        public int NumUniqueEmails(string[] emails)
        {
            if (emails == null || emails.Length == 0)
                return 0;

            var hashset = new HashSet<string>();

            foreach (var email in emails)
            {
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

    }
}
