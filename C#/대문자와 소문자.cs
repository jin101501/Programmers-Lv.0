using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {        
        return String.Concat(my_string.Select(x=>(Char.IsUpper(x)?Char.ToLower(x):Char.ToUpper(x))).ToArray());        
    }
}