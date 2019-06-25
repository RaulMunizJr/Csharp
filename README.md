# Csharp

Helpful Notes:

(MAC) type "csharp" on terminal to replace 'REPL' on Windows.

* useful for reviewing built-in methods like: CompareTo, Trim, ToUpper, Length, etc.
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
* Reading other Data types:
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

* Exp1 ? Exp2 : Exp3;
```
int age = 42;
string msg;
msg = (age >= 18) ? "Welcome" : "Sorry";
Console.WriteLine(msg);
```

- foreach Loop
```
//shorter and easier way of accessing array elements.
foreach (var k in a) {
  Console.WriteLine(k);
}
```

--------------Passing by Reference---------------:

* Pass by reference copies an argument's memory address into the formal parameter instead of value
- ref keyword
```
static void Sqr(ref int x)
{
  x = x * x;
}
static void Main()
{
  int a = 3;
  Sqr(ref a);

  Console.WriteLine(a); // Outputs 9
}
//The ref keyword is used both when defining the method and when calling it.
```

--------------Passing by Output---------------:

* Output parameters are similar to reference parameters, except that they transfer data out of the method rather than accept data in.
```
static void GetValues(out int x, out int y)
{
  x = 5;
  y = 42;
}
static void Main(string[] args)
{
  int a, b;
  GetValues(out a, out b);
  //Now a equals 5, b equals 42
}
//out keyword is used both when defining the method and when calling it.
//useful when you need to return multiple values from a method.
```

--------------Encapsulation---------------:

```
class BankAccount
{
  private double balance=0;
  public void Deposit(double n)
  {
    balance += n;
  }
  public void Withdraw(double n)
  {
    balance -= n;
  }
  public double GetBalance()
  {
    return balance;
  }
}
//The class data can be read through the GetBalance method and modified only through the Deposit and Withdraw methods.
//You cannot directly change the balance variable. You can only view its value using the public method. This helps maintain //data integrity.
```

```
class Person
{
  private string name; //field

  public string Name //property
  {
    get { return name; }
    set { name = value; }
  }
}
//The Person class has a Name property that has both the set and the get accessors.
//The set accessor is used to assign a value to the name variable; get is used to return its value. 

static void Main(string[] args)
{
  Person p = new Person();
  p.Name = "Bob";
  Console.WriteLine(p.Name);
}

//Value is a special keyword, which represents the value we assign to a property using the set accessor. 
```

--------------Auto-Implemented Properties---------------:

* Allow for easy and short declaration of private members.
```
//public string Name { get; set; }

class Person
{
  public string Name { get; set; }
}
static void Main(string[] args)
{
  Person p = new Person();
  p.Name = "Bob";
  Console.WriteLine(p.Name);
}
// Outputs "Bob"
```

--------------Arrays---------------:

```
int[ ] myArray;
int[ ] myArray = new int[5]; 

string[ ] names = new string[3] {"John", "Mary", "Jessica"};
string[ ] names = new string[ ] {"John", "Mary", "Jessica"};
string[ ] names = {"John", "Mary", "Jessica"};
```

--------------Multidimensional Arrays---------------:

* type[, , … ,] arrayName = new type[size1, size2, …, sizeN];
```
int[ , ] x = new int[3,4]; //3x4, rc

int[ , ] someNums = { {2, 3}, {5, 6}, {4, 6} }; //3r, 2c
//Nested curly brackets are used to define values for each row.

for (int k = 0; k < 3; k++) {
  for (int j = 0; j < 2; j++) {
    Console.Write(someNums[k, j]+" ");
  }
  Console.WriteLine();
}
```

--------------Jagged Arrays---------------:

* A jagged array is an array whose elements are arrays. So it is basically an array of arrays.
```
//The following is a declaration of a single-dimensional array that has three elements, each of which is a single-dimensional //array of integers:
int[ ][ ] jaggedArr = new int[3][ ];

//Each dimension is an array, so you can also initialize the array upon declaration like this:
int[ ][ ] jaggedArr = new int[ ][ ] 
{
  new int[ ] {1,8,2,7,9},
  new int[ ] {2,4,6},
  new int[ ] {33,42}
};
//int x = jaggedArr[2][1]; //42

//8 2dim arr
int[ ][,] a = new int[8][,];
```
-  Length and Rank properties return the number of elements and the number of dimensions of the array, respectively

--------------Strings---------------:

- Length returns the length of the string.
- IndexOf(value) returns the index of the first occurrence of the value within the string.
- Insert(index, value) inserts the value into the string starting from the specified index.
- Remove(index) removes all characters in the string after the specified index.
- Replace(oldValue, newValue) replaces the specified value in the string.
- Substring(index, length) returns a substring of the specified length, starting from the specified index. If length is not specified, the operation continues to the end of the string.
- Contains(value) returns true if the string contains the specified value.

--------------Static---------------:

* This makes those members belong to the class itself, instead of belonging to individual objects. No matter how many objects of the class are created, there is only one copy of the static member.
For example:
```
class Cat {
  public static int count=0;
  public Cat() {
    count++;
  }
}
//No matter how many Cat objects are instantiated, there is always only one count variable that belongs to the Cat class //because it was declared static.
```
- Because of their global nature, static members can be accessed directly using the class name without an object.
```
Console.WriteLine(Cat.count);//increments!

//Same for methods!
class Dog
{
  public static void Bark() {
    Console.WriteLine("Woof");
  }
}
static void Main(string[] args)
{
  Dog.Bark();
}
// Outputs "Woof"
```
- Constant members are static by definition. (const)

- sealed, prevents other classes from inheriting it
```
sealed class Animal {
  //some code
}
class Dog : Animal { } //Error
```

- With inheritance, the base class constructor and destructor are not inherited, so you should define constructors for the derived classes.

1. First the base class constructor
2. Derived class constructor
3. Object destoryed; derived class destructor
4. base class destructor

--------------Polymorphism---------------:

- The virtual keyword allows methods to be overridden in derived classes.
```
class Shape {
  public virtual void Draw() {
    Console.Write("Base Draw");
  }
}
```
- Now, we can derive different shape classes that define their own Draw methods using the override keyword:
```
class Circle : Shape {
  public override void Draw() {
    // draw a circle...
    Console.WriteLine("Circle Draw");
  }
}
class Rectangle : Shape {
  public override void Draw() {
    // draw a rectangle...
    Console.WriteLine("Rect Draw");
  }
}
```

--------------Abstract Classes---------------:

* An abstract class is intended to be a base class of other classes. It acts like a template for its derived classes.
```
abstract class Shape {
  public abstract void Draw();
}
class Circle : Shape {
  public override void Draw() {
    Console.WriteLine("Circle Draw");
  }
}
class Rectangle : Shape {
  public override void Draw() {
    Console.WriteLine("Rect Draw");
  }
}
static void Main(string[] args) {
  Shape c = new Circle();
  c.Draw();
  //Outputs "Circle Draw"
}

Abstract classes have the following features:
- An abstract class cannot be instantiated.
- An abstract class may contain abstract methods and accessors.
- A non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors.
```

--------------Interfaces---------------:

* An interface is a completely abstract class, which contains only abstract members.
It is declared using the interface keyword:
```
public interface IShape {
  void Draw();
}
class Circle : IShape {
  public void Draw() {
    Console.WriteLine("Circle Draw");
  }
}
static void Main(string[] args) {
  IShape c = new Circle();
  c.Draw();
  //Outputs "Circle Draw"
}
```

--------------Structs---------------:

```
struct Book {
  public string title;  
  public double price;
  public string author;
}

static void Main(string[] args) {
  Book b;
  b.title = "Test";
  b.price = 5.99;
  b.author = "David";

  Console.WriteLine(b.title);
  //Outputs "Test"
}
```

--------------Enum---------------:

```
-> enum Days {Sun, Mon, Tue, Wed, Thu, Fri, Sat}; //Sun=0, etc.
enum Days {Sun, Mon, Tue=4, Wed, Thu, Fri, Sat}; //0, 1, 4, Wed=5, etc.

static void Main(string[] args) {
  int x = (int)Days.Tue;
  Console.WriteLine(x);
  //Outputs 2
}
```
- Commonly used in switch statements
```
enum TrafficLights { Green, Red, Yellow };

static void Main(string[] args) {
  TrafficLights x = TrafficLights.Red;
  switch (x) {
    case TrafficLights.Green:
      Console.WriteLine("Go!");
      break;
    case TrafficLights.Red:
      Console.WriteLine("Stop!");
      break;
    case TrafficLights.Yellow:
      Console.WriteLine("Caution!");
      break;
  }
  //Outputs "Stop!"
}
```

- Writing to Files
```
string str = "Some text";
File.WriteAllText("test.txt", str);
```

- Reading from Files
```
string txt = File.ReadAllText("test.txt");
Console.WriteLine(txt); 

The following methods are available in the File class:
AppendAllText() - appends text to the end of the file.
Create() - creates a file in the specified location.
Delete() - deletes the specified file.
Exists() - determines whether the specified file exists.
Copy() - copies a file to a new location.
Move() - moves a specified file to a new location
```
