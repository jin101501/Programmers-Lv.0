class Solution {
    public int solution(int n) {
        int answer = 0;
        String array = String.valueOf(n);
        for (int i = 0; i < array.length(); i++) {
            answer += Integer.parseInt(array.substring(i, i + 1));
        }
        return answer;
    }
}