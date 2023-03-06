using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n) {
        List<int>a =new List<int>();
        for(int i=1;i<=n;i++)
        {
            if(i%2!=0)
            {
                a.Add(i);
            }
        }
        int[] answer=a.ToArray();
        return answer;
    }
}