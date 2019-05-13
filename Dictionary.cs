using System;
using System.Collections.Generic;
using System.IO;
namespace hackerrankCommit
{
    partial class Class_Hourglass
    {
        public static int Dictionary_()
        {
            var dic = new Dictionary<string,int>{};
            var keyvalue = Console.ReadLine();
            
            dic.Add(keyvalue.Split(' ')[0],int.Parse(keyvalue.Split(' ')[1]));
            return 0;
            
        }
    }
}
