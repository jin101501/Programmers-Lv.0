using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int sum1=0;
        int sum2=0;
        if(arr1.Length<arr2.Length){
            return -1;
        }
        else if(arr1.Length>arr2.Length){
            return 1;
        }
        else{
            for(int i=0;i<arr1.Length;i++){
                sum1+=arr1[i];
                sum2+=arr2[i];
            }
            if(sum1>sum2){
                return 1;
            }
            else if(sum1<sum2){
                return -1;
            }
            else{
                return 0;
            }
        }
    }
}