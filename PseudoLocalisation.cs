using UnityEngine;
using System.Collections.Generic;

public static class PseudoLocalisation {

    static Dictionary<char,char> AccentMap = new Dictionary<char,char>{
        {'a','ȧ'},
        {'A','Ȧ'},
        {'b','ƀ'},
        {'B','Ɓ'},
        {'c','ƈ'},
        {'C','Ƈ'},
        {'d','ḓ'},
        {'D','Ḓ'},
        {'e','ḗ'},
        {'E','Ḗ'},
        {'f','ƒ'},
        {'F','Ƒ'},
        {'g','ɠ'},
        {'G','Ɠ'},
        {'h','ħ'},
        {'H','Ħ'},
        {'i','ī'},
        {'I','Ī'},
        {'j','ĵ'},
        {'J','ĵ'},
        {'k','ķ'},
        {'K','Ķ'},
        {'l','ŀ'},
        {'L','Ŀ'},
        {'m','ḿ'},
        {'M','Ḿ'},
        {'n','ƞ'},
        {'N','Ƞ'},
        {'o','ǿ'},
        {'O','Ǿ'},
        {'p','ƥ'},
        {'P','Ƥ'},
        {'q','ɋ'},
        {'Q','Ɋ'},
        {'r','ř'},
        {'R','Ř'},
        {'s','ş'},
        {'S','Ş'},
        {'t','ŧ'},
        {'T','Ŧ'},
        {'u','ŭ'},
        {'U','Ŭ'},
        {'v','ṽ'},
        {'V','Ṽ'},
        {'w','ẇ'},
        {'W','Ẇ'},
        {'x','ẋ'},
        {'X','Ẋ'},
        {'y','ẏ'},
        {'Y','Ẏ'},
        {'z','ẑ'},
        {'Z','Ẑ'}
    };

    static Dictionary<char, int> multiplierMap = new Dictionary<char, int>
    {
        {'a',3},
        {'A',3},
        {'e',3},
        {'E',3},
        {'i',3},
        {'I',3},
        {'o',3},
        {'O',3},
        {'u',3},
        {'U',3}
    };

    static Dictionary<string, string> cachedMap = new Dictionary<string, string>();

    public static string PseudoLocaliseString(string originalString)
    {
        if (cachedMap.ContainsKey(originalString))
            return cachedMap[originalString];

        string newString = "[";

        foreach (var letter in originalString)
        {
            if (multiplierMap.ContainsKey(letter))
            {
                for (int i = 0; i < multiplierMap[letter]; i++)
                    newString += AccentMap[letter];
            }
            else
            {
                if (AccentMap.ContainsKey(letter))
                    newString += AccentMap[letter];
                else
                    newString += letter;
            }
        }
           cachedMap.Add(originalString, newString + "]");
           return newString + "]";
       }
}


 
