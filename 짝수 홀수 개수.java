import java.util.*;

class Solution {
    public Object[] solution(int[] num_list) {
        Stack<Integer> stack = new Stack<>();
        int even = 0;
        int odd = 0;
        for (int i = 0; i < num_list.length; i++) {
            if (num_list[i] % 2 == 0) {
                even += 1;
            } else {
                odd += 1;
            }

        }
        stack.push(even);
        stack.push(odd);

        Object[] answer = stack.toArray();

        return answer;
    }
}