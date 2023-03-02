class Solution {
    public int solution(int num, int k) {
        int answer = 0;
        String s = Integer.toString(k);
        String array = Integer.toString(num);
        answer = array.indexOf(s);
        if (answer >= 0) {
            answer += 1;
        }
        return answer;
    }
}