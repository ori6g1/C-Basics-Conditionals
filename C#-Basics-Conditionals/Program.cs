// ---- C# I (Dor Ben Dor) ----
// Ori Shacham-Barr
// -----------------------------

string lineBreak = "\r\n";
string messageStart, messageMiddle, messageEnd;

// A Class Work - Conditionals
// 1
messageStart = "The first number is ";
messageMiddle = " and the second number is ";
int firstNumber = 5, secondNumber = 6;

if (firstNumber == secondNumber)
    Console.WriteLine(messageStart + firstNumber + messageMiddle + secondNumber + " and they are equal.");
else 
    Console.WriteLine(messageStart + firstNumber + messageMiddle + secondNumber + " and they are different.");
Console.WriteLine(lineBreak);

//2
messageStart = "The number ";
int polarityNumber = -2;

if (polarityNumber > 0)
    Console.WriteLine(messageStart + polarityNumber + " is positive.");
else if (polarityNumber < 0)
    Console.WriteLine(messageStart + polarityNumber + " is negative.");
else
    Console.WriteLine("The number is Zero.");
Console.WriteLine(lineBreak);

//3
messageStart = "The age group of ";
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 0 && age <= 2) 
    Console.WriteLine(messageStart + age + " is infant.");
else if (age <= 9) 
    Console.WriteLine(messageStart + age + " is child.");
else if (age <= 19) 
    Console.WriteLine(messageStart + age + " is adolescent.");
else if (age <= 29) 
    Console.WriteLine(messageStart + age + " is young adult.");
else if (age <= 39) 
    Console.WriteLine(messageStart + age + " is adult.");
else if (age <= 59) 
    Console.WriteLine(messageStart + age + " is middle age.");
else if (age <= 80) 
    Console.WriteLine(messageStart + age + " is old.");
else if (age > 80) 
    Console.WriteLine(messageStart + age + " is elder.");
else 
    Console.WriteLine("The age " + age + " is invalid.");
Console.WriteLine(lineBreak);

//4
messageStart = "Among the three numbers, ";
messageEnd = " is the largest.";
int firstConditionalNumber = 4, secondConditionalNumber = 5, thirdConditionalNumber = 6;

Console.Write("The three numbers are " + firstConditionalNumber + ", " + secondConditionalNumber + ", " + firstConditionalNumber + ". ");
if (firstConditionalNumber > secondConditionalNumber && firstConditionalNumber > thirdConditionalNumber) 
    Console.WriteLine("Among the three numbers, " + firstConditionalNumber + " is the largest.");
else if (secondConditionalNumber > thirdConditionalNumber) 
    Console.WriteLine("Among the three numbers, " + secondConditionalNumber + " is the largest.");
else 
    Console.WriteLine("Among the three numbers, " + thirdConditionalNumber + " is the largest.");
Console.WriteLine(lineBreak);

//5
messageStart = "The number ";
int parityNumber = 3;

if ((parityNumber % 2) == 0)
    Console.WriteLine(messageStart + parityNumber + " is even.");
else
    Console.WriteLine(messageStart + parityNumber + " is odd.");
Console.WriteLine(lineBreak);

/* B Class Work - Logical Operators
 * 1 (10, 15) x > 5 && y < 20 : True
 * 2 (2, 1) x == 3 || y == 0 : False
 * 3 (-5.6f, 1.2f) !(x != -5.6 || y != 1.2) : True
 * 4 (3, 3) (x > 3 && y > 3) : False
 * 5 (3, -4) x > 3 || y != -4 : False
 * 6 (-12, -42) !(!(x >= -12) || !(y < -100)) : False
 */
