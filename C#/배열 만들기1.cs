using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int n, int k) {
        List<int> a = new List<int>();
        for(int i=k;i<=n;i++){
           if(i%k==0){
               a.Add(i);
           }
        }
        int[] answer = a.ToArray();
        return answer;
    }
}

// Linq을 활용한 풀이법
// using System;
// using System.Linq;

// public class Solution {
//     public int[] solution(int n, int k) {
//         return Enumerable.Range(1, n).Where(w => w % k == 0).ToArray();   Enumerable.Range(int32, int32)를 사용한다면 특정 구간의 숫자를 채우는 방법이다.
//     }
// }