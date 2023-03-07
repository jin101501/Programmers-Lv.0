using System;
using System.Text.RegularExpressions;
public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string result=Regex.Replace(my_string,@"\D","");
        for(int i=0;i<result.Length;i++)
        {
           answer+=result[i]-'0';
        }
        return answer;
    }
}