using System;
using System.Linq;
public class Solution {
    public int solution(int[] numbers) {
        int num=numbers.Max()*numbers.Min();
        for(int i=0;i<numbers.Length;i++)
        {
            for(int j=i+1;j<numbers.Length;j++)
            {
                if(numbers[i]*numbers[j]>num)
                {
                    num=numbers[i]*numbers[j];
                }
            }
        }
        return num;
    }
}
