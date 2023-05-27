using System;

public class Solution {
    public string solution(string my_string, int[] index_list) {
        string answer = "";
            for(int j=0;j<index_list.Length;j++){
                answer+=my_string[index_list[j]];
            }
        return answer;
    }
}