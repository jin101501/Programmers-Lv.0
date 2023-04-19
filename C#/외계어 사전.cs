using System;
using System.Linq;
public class Solution {
    public int solution(string[] spell, string[] dic) {
        int answer = 2;
        foreach(string dicN in dic)
        {
            bool check=true;
            foreach(string spellN in spell){
                if(dicN.IndexOf(spellN)==-1){
                    check=false;
                }
            }
            if(check==true){
                answer=1;
                break;
            }
        }
    
    // int answer = dic.Any(x => string.Concat(x.OrderBy(o => o)) == string.Concat(spell.OrderBy(z => z))) ? 1 : 2;
        return answer;
    }
}