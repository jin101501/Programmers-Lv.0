using System;
using System.Linq;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = 0;
    for(int i=0;i<s1.Length;i++)
    {
        if(s2.Contains(s1[i]))
            {
                answer++;
            }
        
    }
        return answer;
    }
}