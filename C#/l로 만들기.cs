using System;
using System.Linq;

public class Solution {
    public string solution(string myString){
        return new string(myString.Select(s => s - 'l' > 0 ? s : 'l').ToArray());
    }
}




// using System;
// using System.Text.RegularExpressions; 
// public class Solution {
//     public string solution(string myString) {
//         myString= Regex.Replace(myString,@"[a-k]", "l");
//         return myString;
//     }
// }