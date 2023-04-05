using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int n) {
        List<int> list = new List<int>(); 
        for (int i = 2; i * i <= n; i++) 
        {
            while(n % i == 0)
            {
                list.Add(i);
                n /= i;
            }
        }
        if(n > 1)
            list.Add(n);
            list=list.Distinct().ToList();
            int[] answer=list.ToArray();
            return answer;
        }

}