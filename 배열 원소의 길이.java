import java.util.*;

class Solution {
    public Object[] solution(String[] strlist) {
        Stack<Integer> stack = new Stack<>();

        for (String data : strlist) {
            stack.push(data.length());
        }

        Object[] answer = stack.toArray();

        return answer;
    }
}