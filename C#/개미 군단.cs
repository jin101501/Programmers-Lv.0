using System;

public class Solution {
    public int solution(int hp) {
        int answer = 0;
        int rest = hp;
        
        answer = rest/5;
        rest = hp%5;     
        
        answer += rest/3;
        rest = rest%3;

        return answer+rest;
    }
}