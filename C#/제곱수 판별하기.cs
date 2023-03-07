using System;
using static System.Math;

public class Solution {
    public int solution(int n) {
        int answer= Convert.ToInt32(Math.Sqrt(n));
        if(n%answer==0)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
 }