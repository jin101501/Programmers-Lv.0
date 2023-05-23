using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = num_list.ToList().GetRange(0,n).ToArray();
        return answer;
    }
}