using System;
using System.Text.RegularExpressions;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = Regex.Replace(my_string,letter,"");
        return answer;
    }
}