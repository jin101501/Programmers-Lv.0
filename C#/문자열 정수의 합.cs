using System;
using System.Linq;

public class Solution {
    public int solution(string num_str) {
        return num_str.Select(s => s - '0').Sum();
    }
}



// using System;

// public class Solution {
//     public int solution(string num_str) {
//         int answer = 0;
//         foreach (char c in num_str) 
//         {
//           answer+=c-'0';
//         }
        
//         return answer;
//     }
// }