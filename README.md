# Csharp

Helpful Notes:

(MAC) type "csharp" on terminal to replace 'REPL' on Windows.

*useful for reviewing built-in methods like: CompareTo, Trim, ToUpper, Length, etc.
```
stringExample.Substring(4,8); //starts at index 4 and gets the first 8 chars after.

var challenge = " Text processing in c# is really great!  ";
challenge.Trim().Substring(24, challenge.Trim().Length - 25).ToUpper().Trim() //"REALLY GREAT"

var sb = new StringBuilder(); //sb.AppendLine("Keeps appending text");

Math class: abs, floor, ceiling, pow, etc.
```
