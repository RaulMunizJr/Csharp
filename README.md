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
- Resizing an Array to add room:
```
Array.Resize(ref groceryList, 6); //must use 'ref' keyword (pass by reference) then name_of_array, followed by new number of wanted size
```
- Lists
```
var awesomeSauces = new List<string>();
awesomeSauces. (on REPL) displays all useful methods: Add, Remove, RemoveAll, Reverse, Sort, Find, etc.
```
- LINQ
```
var listOfNumbers = new int[5] { 1, 3, 5, 7, 9 };
listOfNumbers. (on REPL) methods: Sum, Average, Hashing, Count etc.


//similar to an SQL query
listOfNumbers.Where(item => item >= 3)
Enumerable.WhereArrayIterator<int> { 3, 5, 7, 9 }
```
- Dictionaries (unordered)
```
var dictionaryWords = new Dictionary<string, string>(); //key type, value type; dictionaryWords.Keys displays all keys!
dictionaryWords.Add("var", "shorthand for variable");
dictionaryWords["var"] //outputs "shorthand for variable"
```
- How to use REPL with classes already on IDE (make sure to save & build first) for testing purposes.
1. On solution explorer, right click on project, click on "Open folder in File Explorer"
2. Click on bin, debug, netstandard, copy path above.
3. On REPL, type "#r" and in quotes copy and paste the path. Add backslash then tab for the '.dll' file

- NuGet.org helpful packages/libraries available for apps!!
*Might be available under tools -> NuGet Package Manager -> Manage
**IF NLOG, good to also install NLOG.config
***Run in Release mode for final submission/testing to customers, found under bin, then release. [Make sure to build solution first!]
## Other Useful References:

--------------IO---------------:
```
Console.WriteLine("Hello World!");

string yourName;
Console.WriteLine("What is your name?");
yourName = Console.ReadLine();
Console.WriteLine("Hello {0}", yourName); 
```
*Reading other Data types:
```
Convert.ToDouble, Convert.ToBoolean, etc.
double n; string x = "77";
n = Convert.ToDouble(x);
```
- var declartions must be assigned a value! ..or error occurs

--------------Loops---------------:
```
Same as C++
for(;;) {} //infinte loop
```
- The ? : Operator

*Exp1 ? Exp2 : Exp3;
```
int age = 42;
string msg;
msg = (age >= 18) ? "Welcome" : "Sorry";
Console.WriteLine(msg);
```
