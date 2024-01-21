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
Console.Write("Enter an age: ");
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

Console.Write("The three numbers are " + firstConditionalNumber + ", " + secondConditionalNumber + ", " + thirdConditionalNumber + ". ");
if (firstConditionalNumber > secondConditionalNumber && firstConditionalNumber > thirdConditionalNumber) 
    Console.WriteLine("Among the three numbers, " + firstConditionalNumber + messageEnd);
else if (secondConditionalNumber > thirdConditionalNumber) 
    Console.WriteLine("Among the three numbers, " + secondConditionalNumber + messageEnd);
else 
    Console.WriteLine("Among the three numbers, " + thirdConditionalNumber + messageEnd);
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

// C Class Work - Switch Case
//1
Console.Write("Please enter a race: ");
string race = Console.ReadLine();

Console.Write("The race '" + race + "' can be the following class:");
switch(race)
{
    case "protean":
        Console.WriteLine(" vanguard.");
        break;
    case "human":
        Console.WriteLine(" fighter.");
        break;
    case "efreet":
        Console.WriteLine(" mage.");
        break;
    default:
        Console.WriteLine(" assassin.");
        break;
}
Console.WriteLine(lineBreak);

//2
Console.Write("Please enter an age group: ");
string ageGroup = Console.ReadLine();

Console.Write("The age group '" + ageGroup + "' is of the following generation:");
switch (ageGroup)
{
    case "infant":
    case "child":
        Console.WriteLine(" Generation Alpha.");
        break;
    case "adolescent":
    case "young adult":
        Console.WriteLine(" Generation Z.");
        break;
    case "adult":
        Console.WriteLine(" Generation Y.");
        break;
    case "middle age":
        Console.WriteLine(" Generation x.");
        break;
    case "old":
        Console.WriteLine(" Baby Boomers.");
        break;
    default:
        Console.WriteLine(" Silnet Generation or older.");
        break;
}
Console.WriteLine(lineBreak);

//D Conditionals
//1
bool flipBoolean = true;
flipBoolean = !flipBoolean;

Console.WriteLine("The boolean used to be " + !flipBoolean + " but now it is " + flipBoolean + ".");
Console.WriteLine(lineBreak);

//2
int firstTerm = 10, secondTerm = 98;
messageStart = "The addition of " + firstTerm + " and " + secondTerm + " is ";

if (100 <= firstTerm + secondTerm)
    Console.WriteLine(messageStart + "more than 100.");
else
    Console.WriteLine(messageStart + "less than 100.");
Console.WriteLine(lineBreak);

//3
Console.Write("Please enter the gamble's probability: ");
float gambleProbability = float.Parse(Console.ReadLine());

Console.Write("Please enter the gamble's prize: ");
int gamblePrize = int.Parse(Console.ReadLine());

Console.Write("Please enter the gamble's down payment: ");
int gambleDownPayment = int.Parse(Console.ReadLine());

messageStart = "The gamble is ";

if (gambleDownPayment > (gambleProbability * gamblePrize))
    Console.WriteLine(messageStart + "not profitable.");
else if (gambleDownPayment < (gambleProbability * gamblePrize))
    Console.WriteLine(messageStart + "profitable.");
else
    Console.WriteLine(messageStart + "even.");
Console.WriteLine(lineBreak + lineBreak);

//E Conditionals: Text Adventure
string descisionPrompt = "\tWhat would you like to do?";
int firstDecision, secondDecision;
string firstOption = "\t1. ", secondOption = "\t2. ", thirdOption = "\t3. ";

Console.WriteLine("You wake up, slowly opening your eyes to the view of a barely lit up room." + lineBreak + 
    "Only a single window shine a faint sun ray into the dreary room." + lineBreak + 
    "You are free to do what you want in the room." + lineBreak + descisionPrompt + lineBreak +
    firstOption + "Search for clues around the room" + lineBreak +
    secondOption + "Look outside of the small window" + lineBreak +
    thirdOption + "Try to speak to see if someone answers");
firstDecision = int.Parse(Console.ReadLine());

switch (firstDecision)
{
    case 1:
        Console.WriteLine("You look around the room and realize that you are in a prison cell." + lineBreak +
            "You have no recolection how you got here, or why you might be in prison to begin with." + lineBreak +
            "Lifting the mattress on the bed on which you slept, you see a small key." + lineBreak + descisionPrompt + lineBreak +
            firstOption + "Attempt to unlock the door to the prison cell" + lineBreak +
            secondOption + "Search for a secret lock inside the room" + lineBreak +
            thirdOption + "Try to speak to see if someone answers");
        secondDecision = int.Parse(Console.ReadLine());
        break;
    case 2:
        Console.WriteLine("You look outisde the window and see a wide open field." + lineBreak +
            "There seems to be nothing but grass for miles and miles." + lineBreak +
            "It seems that the building is on a hill and that there is no one in sight." + lineBreak + descisionPrompt + lineBreak +
            firstOption + "Jump through the window to the field" + lineBreak +
            secondOption + "Soak in the sparse sun for another minute" + lineBreak +
            thirdOption + "Sit in a dark corner and cry that you are not outside");
        secondDecision = int.Parse(Console.ReadLine());
        break;
    case 3:
        Console.WriteLine("You shout out, asking if any one hears you." + lineBreak +
            "At first it seems that there is no answer, only silence and your thundering echo." + lineBreak +
            "Then a shriveling voice sqeaks, leting you know they exists. A small white mouse is sitting next to you." + lineBreak + descisionPrompt + lineBreak +
            firstOption + "Ask it for its name" + lineBreak +
            secondOption + "Shoo it away" + lineBreak +
            thirdOption + "Ignore the mouse altogether");
        secondDecision = int.Parse(Console.ReadLine());
        break;
    default:
        Console.WriteLine("Invalid choice, terminating game");
        break;
}
Console.WriteLine("The continuation of the story arrives with the next update.");
Console.WriteLine(lineBreak);
