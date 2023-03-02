import java.time.LocalDate;

class Solution {
    public int solution(int age) {
        LocalDate now = LocalDate.now();

        return now.getYear() - age;
    }
}