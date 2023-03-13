using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        char text;
        StringBuilder sb= new StringBuilder(my_string);
        text=sb[num1];
        sb[num1]=sb[num2];
        sb[num2]=text;
        
        return sb.ToString();
    }
}