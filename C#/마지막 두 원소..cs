using System;

public class Solution {
    public int[] solution(int[] num_list) 
    {
        int[] answer = new int[num_list.Length + 1];
        Array.Copy(num_list, answer, num_list.Length); // 배열 복사 메소드 
        int a = num_list[num_list.Length - 2];
        int b = num_list[num_list.Length - 1];
        answer[answer.Length - 1] = b > a ? b - a : b * 2;
        return answer;
    }
}



// using System;

// public class Solution {
//     public int[] solution(int[] num_list) {
//         int[] answer = new int[num_list.Length+1];
//         int last=0;
//         int before=0;
//         for(int i=0;i<num_list.Length;i++){
//             answer[i]=num_list[i];
//         }
//         last=num_list[num_list.Length-1];
//         before=num_list[num_list.Length-2];
//        if(last>before){
//             answer[num_list.Length] = last - before;
//        }
//        else{
//             answer[num_list.Length] = last * 2;  
//        }
//         return answer;
//     }
// }