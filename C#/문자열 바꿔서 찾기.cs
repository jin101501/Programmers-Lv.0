using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        String sentence="";
        myString=myString.Replace("A","0");
        myString=myString.Replace("B","A");
        myString=myString.Replace("0","B");
        if(myString.Contains(pat)){
            answer=1;
        }
        Console.WriteLine(myString);
        return answer;
    }
}