using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        Array.Sort(array);
        if(array.Length%2==1)
        {
          answer=  array[array.Length/2];
        }
        return answer;
    }
}