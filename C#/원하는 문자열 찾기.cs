using System;

public class Solution {
    public int solution(string myString, string pat) {
       int answer = 0;
       if(myString.Contains(pat, StringComparison.OrdinalIgnoreCase)) {
           answer=1;
       }
        return answer;
    }
}