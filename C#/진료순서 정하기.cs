using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] emergency) {
     int[] answer=Enumerable.Repeat<int>(1, emergency.Length).ToArray<int>();
        for(int i=0;i<emergency.Length;i++)
        {
            for(int j=0;j<emergency.Length;j++)
            {
                if(emergency[i]<emergency[j])
                {
                    answer[i]++;
                }   
            }
        }
        return answer;
    }
}