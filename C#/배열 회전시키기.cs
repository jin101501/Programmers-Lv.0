using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];
        int temp;
        if(direction=="left"){
            temp=numbers[0];
            for(int i=0;i<numbers.Length-1;i++){
                answer[i]=numbers[i+1];
            }
            answer[numbers.Length-1]=temp;
        }
        else if(direction=="right"){
             temp=numbers[numbers.Length-1];
            for(int j=numbers.Length-2;j>=0;j--){
                answer[j+1]=numbers[j];
            }
            answer[0]=temp;
        }
        return answer;
    }
}