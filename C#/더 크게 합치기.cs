using System;

public class Solution {
    public int solution(int a, int b) {
        string text1=a.ToString()+b.ToString();
        string text2=b.ToString()+a.ToString();
        if(Int32.Parse(text1) >Int32.Parse(text2)){
            return Int32.Parse(text1);
        }
        else if(Int32.Parse(text1) <Int32.Parse(text2)){
            return Int32.Parse(text2);
        }
        return Int32.Parse(text1);
    }
}