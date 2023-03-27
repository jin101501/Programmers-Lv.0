using System;
using System.Linq;
public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        int sum1=0;
        int sum2=0;
        for(int i = 0; i < before.Length; i++) {
            sum1 += (int)before[i];
            sum2 += (int)after[i];
        }
        return (sum1 == sum2)? 1 : 0;
    }
}