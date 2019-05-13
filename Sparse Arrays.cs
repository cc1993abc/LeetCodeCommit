using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace hackerrankCommit
{
    partial class Class_Hourglass
    {
        public static int[] Sparse_Arrays()
        {
           var str1 = new string[]{"ab","ab","bc"};
           var querystrs = new string[]{"ab","123","333"};
           var dic = new Dictionary<string,int>();
           foreach (var item in str1)
           {
               if (!dic.ContainsKey(item))
               {
                   dic.Add(item,1);
               }else{
                   dic[item] += 1;
               }
           }
           var returnlist = new List<int>{};
           foreach (var item in querystrs)
           {
               if (dic.ContainsKey(item))
               {
                   returnlist.Add(dic[item]);
               }else{
                   returnlist.Add(0);
               }
           }
        return returnlist.ToArray();
           
        }
    }
}
