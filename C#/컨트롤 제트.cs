using System;
using System.Linq;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        var list = s.Split(' ').ToList();

        while (list.Contains("Z"))
        {
            list.RemoveRange(list.IndexOf("Z") - 1, 2);
        }

        answer = list.Sum(x => Convert.ToInt32(x));

        return answer;
    }
}