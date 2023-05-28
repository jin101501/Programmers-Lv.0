using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] num_list, int n) {
         List<int>a =new List<int>();
        for(int i=0;i<num_list.Length;i+=n){
                a.Add(num_list[i]);
        }
        int[] answer=a.ToArray();
        return answer;
    }
}