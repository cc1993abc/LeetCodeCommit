using System;

namespace hackerrankCommit
{
    partial class Class_Hourglass
    {
        public static int left_rotation()
        {
            var arr = new int[]{1,2,3,4,5};
            int d = 4;
            var newarr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int newposition = (i+d) % arr.Length;
                newarr[newposition] = arr[i];
            }
            return 0;
        }
    }
}
