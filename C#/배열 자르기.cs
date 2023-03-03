using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
      List<int> a = new List<int>();
        for(int i=num1;num1<=num2;num1++)
        {
            a.Add(numbers[num1]);
        }
        int[] answer=a.ToArray();
        
        
        return answer;

            
    }
}