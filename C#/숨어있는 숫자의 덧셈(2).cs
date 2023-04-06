public class Solution {
    public int solution(string my_string) {
        my_string += "K";
        int answer = 0;
        int save = 0;
        
        for(int i = 0; i < my_string.Length; i++)
        {
            if(char.IsDigit(my_string[i]) == true)
            {
                save = save * 10 + ((int)my_string[i] - 48);
            }
            else
            {
                answer += save;
                save = 0;
            }
        }
        return answer;
    }
}