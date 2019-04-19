using System;

namespace hackerrankCommit
{
    class Class_Array
    {
        public static int[] Array_Solution()
        {
            var arr = new int[]{1,2,3,4};
            int count = arr.Length;
            int temp ;
            for (int i = 0; i < count/2; i++)
            {
                temp = arr[i];
                arr[i] = arr[count-i-1];
                arr[count-i-1] = temp;
            }
            return arr;
        }
    }
}
