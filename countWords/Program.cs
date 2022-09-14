using System;

namespace countWords
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = " hi  iam naresh ";
            String s2 = s1.Trim();
            int count = 1;
           // Console.WriteLine(s1.Length);
           //Console.WriteLine(s2.Length);
            for(int i = 0;i<s2.Length-1;i++)
            {
                char ch = s2[i];
                char ch2 = s2[i + 1];
                if(ch==' ')
                {
                    count++;
                }
                if(ch==' '&&ch2==' ')
                {
                    i++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
