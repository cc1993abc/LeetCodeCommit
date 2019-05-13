using System;
using System.Collections.Generic;
using System.IO;
namespace hackerrankCommit
{
    partial class Class_Hourglass
    {
        public static void Binary_Numbers()
        {
        int n = 3;
        int maxcount = 0;
        int count = 0;
        while(n>0){
          count = n%2 == 1 ? ++count : 0;
          if(count > maxcount){
              maxcount = count;
          }
          n = n / 2;
        }
        Console.WriteLine(maxcount);
            
        }
    }
}
