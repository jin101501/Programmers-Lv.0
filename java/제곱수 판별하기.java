class Solution {
    public int solution(int n) {
        int answer = 0;
        answer = (int) Math.sqrt(n);
        if (n % answer == 0) {
            return 1;
        } else {
            return 2;
        }
    }
}