using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        List<int> a = new List<int>(); 
        for(int i=0;i<arr.Length;i++){
        for(int j=0;j<arr[i];j++){
             a.Add(arr[i]);
        }
    }
        return a.ToArray();
    }
}