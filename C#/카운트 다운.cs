using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int start, int end) {
        List<int> a = new List<int>();
        for(int i=start;i>=end;i--)
        {
            a.Add(i);
        }
         return a.ToArray();

    }
}