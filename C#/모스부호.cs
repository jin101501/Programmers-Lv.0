using System;

public class Solution {
    public string solution(string letter) {
        string[] mos = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        string answer = "";

        foreach (string t in letter.Split(' '))
        {
            answer += Convert.ToChar(Array.IndexOf(mos, t) + 97);
        }

        return answer;
    }
}