using System;

public class Solution {
    public int solution(int[] num_list, int n) {
        int answer = Array.FindIndex(num_list,b => b == n) == -1 ? 0 : 1;
        return answer;
    }
}
