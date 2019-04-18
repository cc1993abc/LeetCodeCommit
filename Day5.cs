using System;

namespace hackerrankCommit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string s3 = string.Empty;
            string s4 = string.Empty;
            for (int i = 0; i < n; i++)
            {
            string s1 = "read";
            s3 = string.Empty;
            s4 = string.Empty;
            int index = 0;
            foreach (var s in s1)
            {
                if(index % 2 == 0){
                    s3 += s;
                }else{
                s4 += s;
                }
                index++;
            }
            System.Console.WriteLine(string.Format("{0}  {1}",s3,s4));  
            }
        }
    }
}
