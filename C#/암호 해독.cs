using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string cipher, int code) {
        //return String.Concat(cipher.Select((x,i)=>(i+1)%code==0?x.ToString():"").ToArray());
        
        return String.Concat(cipher.Where((c, i) => (i + 1) % code == 0).Select(x => x));
    }
}