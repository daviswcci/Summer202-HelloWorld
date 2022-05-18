// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Variable explanation
// What is a variable? 
// named objects / values that can change
// variables are named objects with values and types
// built-in types: string, int, double, boolean
// string - text, int - whole numbers, double - decimals, boolean - true/false


// variable declaration is creating a variable
// variableType variableName;
string instructor; // this variable is 'null' (has no value)

// variable assignment is giving a variable a value
// variableName = value;
// instructor is davis.
instructor = "davis"; // instructor has a value of davis (setting a variable)
instructor = "gavin";

Console.WriteLine(instructor); // instructor has a value of gavin

// variable declaration AND assignment
// variableType variableName = value;
string coInstructor = "gavin";
int studentCount = 8;

// declaring a variable and assigning it to the value the user types in the console
string input = Console.ReadLine(); // "12" vs. 12

Console.WriteLine(input);

// operators are ways that we can manipulate values / variables
// example: addition (+)
// 5 + 5
//  10
decimal num = 5 + 5; //10
Console.WriteLine(num);
num = 5 * 5; // 25
num = 5 / 5; // 1
num = 5 / 3.0m; // 1.6666667 -> 1
Console.WriteLine(num);

// visual variable type cues
// quotes "" -> string         "hello"
// d,D, .0 -> double           3d 3.59382 3.59382d
// f,F -> float                3f 3.24123f
// m,M -> deciMal              3m 3.123495m
// true,false -> boolean       true false
// number -> int               3 2 1
// single quotes '' -> char    'c' 's'
