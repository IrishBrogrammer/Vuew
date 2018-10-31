# Vuew

Inspired by https://medium.com/netflix-techblog/pseudo-localization-netflix-12fff76fbcbe

A simple collection of scripts to help with the development of UI elements in Unity to help reduce the amount of string over-lap when dealing with different languages. Often when developing UIs only the English version of texts are used which latter causes issues in other languages when the translated text can be 20/30/40% longer. 

To combat this rather than waiting for the texts to be translated and QA to un-cover these issues these scripts attempt simulate the increased length/accent issues that may arise from the translated texts while maintaining readability.

A simple algorithm is used where letters are replaced with an acceneted version of the letter to combat any possible vertical alignment issues. To simulate length issues a map is provided, which by default is populated by vowels, and any occurance of a character present in this map will be tripled in the output string. 

A set of matching brackets \[ \] encase the given text to make the start and end points clear and reduce confusion on overflow elements.


# Example 

### English 
> Don’t miss out.

### German 
> Lassen Sie sich nichts entgehen.

### Psuedo Localised 
> \[Ḓǿǿǿǿƞ’ŧ ḿīīīīşş ǿǿǿǿŭŭŭŭŧ.\]


# Future Improvements 

* Allow loading of custom json files for accent map so alternative symbols can be used
* Allow the duplicate map to be loaded from json so the lengthening settings can be alterated
* Create a simple tool that allows a simple localisation file in the format of { textKey: textValue } to be loaded in. It will then go through each pairing in the file and generated a psuedo localisation version of the file which can be pre-loaded rather than generating this map at run-time. 
