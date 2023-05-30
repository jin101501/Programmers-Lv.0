using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer ="";
        char[] arr = my_string.ToCharArray();
        for(int i=0;i<arr.Length;i++)
        {
            answer[i] = i % 2 == 0 ? strArr[i].ToLower() : strArr[i].ToUpper();
        }
        return answer;
    }
}


// Linq을 이용한 풀이
// using System;
// using System.Linq;

// public class Solution {
//     public string[] solution(string[] strArr) 
//     {
//         return strArr.Select((c, index) => 
//                          {
//                              if(index % 2 == 0) return c.ToLower();
//                              else return c.ToUpper();
//                          }).ToArray();
//     }
// }