using System;
using System.Linq;
public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        int a=0;
        int b=0;
        a=sides.Max()-sides.Min();
        b=sides.Max()+sides.Min();
        answer=b - a - 1;

        return answer;
    }
}