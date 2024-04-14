// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// var name = "Feras";

/*
 var name = Console.ReadLine();
Console.WriteLine($"Your Name is {name}");
Console.ReadLine();
*/


// C#  Primitive Types

// Task 1
int myIntegerVariable = 5;
Console.WriteLine(myIntegerVariable);
double myDoubleVariable = 23.5;
Console.WriteLine(myDoubleVariable);
string myStringVariable = "Feras";
Console.WriteLine(myStringVariable);
bool  myBooleanVariable = false;
Console.WriteLine(myBooleanVariable);

// Task 2
int number = 45;
double number1 = Convert.ToDouble(number);
Console.WriteLine(number1);
// Bonus
char letter = 'A';
Console.WriteLine(letter);


// C# Variables

// Task 1
string studentName = "Mohammed";
double studentGPA = 3.54;
string studentFavSubj = "Physics";
Console.WriteLine($" The student's name is {studentName} and his GPA is {studentGPA}, also his favourite subject is {studentFavSubj}. \n");

// Task 2
double width = 34.5;
double height = 23.6;
double areaOfRectangle = width * height;
Console.WriteLine(areaOfRectangle);
// Bonus
const double width2 = 34.5;
Console.WriteLine(width2);
var width3 = 234.56;
Console.WriteLine(width3);
width3 = 5432.654;
Console.WriteLine(width3);
// The difference is that the developer can re-assign a variable and cannot re-assign a constant.