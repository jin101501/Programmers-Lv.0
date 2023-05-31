using System;

class Solution {
    public int solution(int[] num_list) {
        String e = "" , o = "";
        
        for (int i = 0; i < num_list.Length ; i++) {
            if (num_list[i] % 2 == 0) {
                e += num_list[i];
            } else {
                o += num_list[i];
            }
        }
        
        return Int32.Parse(e) + Int32.Parse(o);
    }
}