using System;
using System.Collections.Generic;

namespace LeetCode
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var s = "hello,world";
            var s1 = s.Remove(',');
            foreach (var s2 in s1)
            {
                Console.WriteLine(s2);
            }
        }

        // problem 3
        public string ToLowerCase(string str)
        {
            return str.ToLower();
        }
        //this is just a test

        public int NumUniqueEmails(string[] emails)
        {
            var hashset = new HashSet<string>();

            foreach (var email in emails)
            {
                var splitedEmail = email.Split('@');
                var domaiName = splitedEmail[1];
                var userName = splitedEmail[0];
                var shapedUserName = userName.Remove('.');

            }
            return 0;
        }

    }
}
