using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
            for(int i = 0; i<arr.Length;i++){
            if(arr.Length%2==1 && i%2==0){
                arr[i]+=n;
            }
            if(arr.Length%2==0 && i%2==1){
                arr[i]+=n;
            }
        }
        return arr;
    }
}