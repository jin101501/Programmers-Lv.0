using System;

public class Solution {
    public string[] solution(string my_str, int n) {
        string[] answer = new string[my_str.Length%n==0 ? my_str.Length/n: my_str.Length/n+1];
        int index=0;
        for(int i=0;i<my_str.Length;i++){
            answer[index]+=my_str[i];
            if((i+1)%n==0){
                index++;
            }
        }
        return answer;
    }
}