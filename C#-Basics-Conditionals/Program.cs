// ---- C# I (Dor Ben Dor) ----
// Ori Shacham-Barr
// -----------------------------

string lineBreak = "\r\n";

// 1
Console.Write("Enter a number to check if it is a real number: ");
float realNumber = int.Parse(Console.ReadLine());

//Since all number that are represented by a float are real numbers, I just print that it is real
Console.WriteLine("The number " + realNumber + " is a real number.");
Console.WriteLine(lineBreak);


//2
Console.Write("Enter three numbers: ");
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

if ((firstNumber % 3) == 0 && (secondNumber % 3) == 0 && (thirdNumber % 3) == 0)
    Console.WriteLine("All of the three numbers are divisible by three.");
else
    Console.WriteLine("Not all of the three number are divisible by three.");
Console.WriteLine(lineBreak);

//3
int clientAge;
bool isIDFake = false, isBartenderOnShift;
string input;
string servedMessage = "The drink can be served";

Console.Write("Enter the client's age: ");
clientAge = int.Parse(Console.ReadLine());

if (clientAge < 18)
{
    Console.Write("Is the client using a fake ID (y = yes): ");
    input = Console.ReadLine();
    if (input == "y")
        isIDFake = true;
}

Console.Write("Is a bartendet on shift (y = yes): ");
input = Console.ReadLine();
if (input == "y")
    isBartenderOnShift = true;
else
    isBartenderOnShift = false;

if (clientAge >= 18 && isBartenderOnShift)
    Console.WriteLine(servedMessage);
else if (clientAge >= 15 && isIDFake && !isBartenderOnShift)
    Console.WriteLine(servedMessage);
else
    Console.WriteLine("The drink cannot be served.");
Console.WriteLine(lineBreak);

//4
int sum = 0, product = 0;

Console.Write("Enter 10 numbers: ");
int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
int numberThree = int.Parse(Console.ReadLine());
int numberFour = int.Parse(Console.ReadLine());
int numberFive = int.Parse(Console.ReadLine());
int numberSix = int.Parse(Console.ReadLine());
int numberSeven = int.Parse(Console.ReadLine());
int numberEight = int.Parse(Console.ReadLine());
int numberNine = int.Parse(Console.ReadLine());
int numberTen = int.Parse(Console.ReadLine());

//Since we did not study arrays and loops I did it like this. Otherwise I would have used them
if (numberOne > 0)
    sum += numberOne;
else if (numberOne < 0)
    product = numberOne;

if (numberTwo > 0)
    sum += numberTwo;
else if (numberTwo < 0 && product != 0)
    product *= numberTwo;
else if (numberTwo < 0 && product == 0)
    product = numberTwo;

if (numberThree > 0)
    sum += numberThree;
else if (numberThree < 0 && product != 0)
    product *= numberThree;
else if (numberThree < 0 && product == 0)
    product = numberThree;

if (numberFour > 0)
    sum += numberFour;
else if (numberFour < 0 && product != 0)
    product *= numberFour;
else if (numberFour < 0 && product == 0)
    product = numberFour;

if (numberFive > 0)
    sum += numberFive;
else if (numberFive < 0 && product != 0)
    product *= numberFive;
else if (numberFive < 0 && product == 0)
    product = numberFive;

if (numberSix > 0)
    sum += numberSix;
else if (numberSix < 0 && product != 0)
    product *= numberSix;
else if (numberSix < 0 && product == 0)
    product = numberSix;

if (numberSeven > 0)
    sum += numberSeven;
else if (numberSeven < 0 && product != 0)
    product *= numberSeven;
else if (numberSeven < 0 && product == 0)
    product = numberSeven;

if (numberEight > 0)
    sum += numberEight;
else if (numberEight < 0 && product != 0)
    product *= numberEight;
else if (numberEight < 0 && product == 0)
    product = numberEight;

if (numberNine > 0)
    sum += numberNine;
else if (numberNine < 0 && product != 0)
    product *= numberNine;
else if (numberNine < 0 && product == 0)
    product = numberNine;

if (numberTen > 0)
    sum += numberTen;
else if (numberTen < 0 && product != 0)
    product *= numberTen;
else if (numberTen < 0 && product == 0)
    product = numberTen;

Console.WriteLine("The sum of the positive numbers is " + sum + " and the product of the negative numbers is " + product);