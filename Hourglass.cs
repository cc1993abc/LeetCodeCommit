using System;

namespace hackerrankCommit
{
    class Class_Hourglass
    {
        public static int HourGlass()
        {
            var arr = new int[][]{new int[]{1,2,3,4,5},
            new int[]{1,2,3,4,5},
            new int[]{1,2,3,4,5},
            new int[]{1,2,3,4,5}
            };
            int maxsum = int.MinValue;
            int temp =int.MinValue;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for(int j=0;j<arr[i].Length-2;j++){
                    temp = arr[i][j] +arr[i][j+1] + arr[i][j+2] + arr[i+1][j+1] + arr[i+2][j] +arr[i+2][j+1] + arr[i+2][j+2];
                    if(temp > maxsum){
                        maxsum = temp;
                    }
                }
            }

            return maxsum;
        }
    }
}
