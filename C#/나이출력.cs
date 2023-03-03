using System;

public class Solution {
    public int solution(int age) {
        DateTime today = DateTime.Today;
        
        return today.Year-age;
    }
}