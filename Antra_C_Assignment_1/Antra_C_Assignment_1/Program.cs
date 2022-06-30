// See https://aka.ms/new-console-template for more information

/*
1. What type would you choose for the following “numbers”?
---------------------------------------------------------------------------------------------------
A person’s telephone number
-uint
A person’s height
-ufloat
A person’s age
-byte
A person’s gender (Male, Female, Prefer Not To Answer)
-string
A person’s salary
-decimal
A book’s ISBN
-int
A book’s price
-decimal
A book’s shipping weight
-float
A country’s population
-uint
The number of stars in the universe
-ulong
The number of employees in each of the small or medium businesses in the
United Kingdom (up to about 50,000 employees per business)
-uint

2. What are the difference between value type and reference type variables?
What is boxing and unboxing?
---------------------------------------------------------------------------------------------------
-Value (default): stores values in stack, calling the copy constructor

-Reference (ref): stores values in heap, passing a the memory address (a.k.a, pointer) of the desired value allowing the passed data
to be modified outside of something like a function.

3. What is meant by the terms managed resource and unmanaged resource in .NET
---------------------------------------------------------------------------------------------------
-Managed resource: The basic difference between a managed and unmanaged resource is that the garbage collector
knows about all managed resources, at some point in time the GC will come along and clean up all the memory and
resources associated with a managed object. The GC does not know about unmanaged resources, such as files, stream
and handles, so if you do not clean them up explicitly in your code then you will end up with memory leaks and locked resources.

-Unmanaged resource: The term "unmanaged resource" is usually used to describe something
not directly under the control of the garbage collector. For example, if you open a connection to a
database server this will use resources on the server (for maintaining the connection) and possibly
other non-.net resources on the client machine, if the provider isn't written entirely in managed code.

This is why, for something like a database connection, it's recommended you write your code thusly:

using (var connection = new SqlConnection("connection_string_here"))
{
    // Code to use connection here
}

As this ensures that .Dispose() is called on the connection object, ensuring that any unmanaged resources are cleaned up.

4. Whats the purpose of Garbage Collector in .NET?
---------------------------------------------------------------------------------------------------
. NET's garbage collector manages the allocation and release of memory for your application.

 */

/*
Using just the ReadLine and WriteLine methods and your current knowledge of variables,
you can have the user pass in quite a few bits of information. Using this approach, create a
console application that asks the user a few questions and then generates some custom
output for them. For instance, your program could generate their "hacker name" by asking
them their favorite color, their astrology sign, and their street address number. The result
might be something like "Your hacker name is RedGemini480."
*/

/*
//Playing with Console App
Console.WriteLine("Welcome hacker!\n" +
    "Today begins your vigirious Journey into the world of computers and the internet that connects them all.\n" +
    "Create an account and we'll get started...\n\n");
Console.WriteLine("Please enter your hacker name");
Console.ReadLine();

Console.WriteLine("Enter your favorite color");
Console.ReadLine();

Console.WriteLine("Write something cool you think about computers");
Console.ReadLine();
*/

//Practice number sizes and ranges

/*
Console.WriteLine("Type: sbyte" + " " + "Byte Size: " + sizeof(sbyte) + " " +
                  "Minimum Value: " + sbyte.MinValue + " " + "Maximum Value: " + sbyte.MaxValue);

Console.WriteLine("Type: byte" + " " + "Byte Size: " + sizeof(byte) + " " +
                  "Minimum Value: " + byte.MinValue + " " + "Maximum Value: " + byte.MaxValue);

Console.WriteLine("Type: short" + " " + "Byte Size: " + sizeof(short) + " " +
                  "Minimum Value: " + short.MinValue + " " + "Maximum Value: " + short.MaxValue);

Console.WriteLine("Type: ushort" + " " + "Byte Size: " + sizeof(ushort) + " " +
                  "Minimum Value: " + ushort.MinValue + " " + "Maximum Value: " + ushort.MaxValue);

Console.WriteLine("Type: int" + " " + "Byte Size: " + sizeof(int) + " " +
                  "Minimum Value: " + int.MinValue + " " + "Maximum Value: " + int.MaxValue);

Console.WriteLine("Type: uint" + " " + "Byte Size: " + sizeof(uint) + " " +
                  "Minimum Value: " + uint.MinValue + " " + "Maximum Value: " + uint.MaxValue);

Console.WriteLine("Type: long" + " " + "Byte Size: " + sizeof(long) + " " +
                  "Minimum Value: " + long.MinValue + " " + "Maximum Value: " + long.MaxValue);

Console.WriteLine("Type: ulong" + " " + "Byte Size: " + sizeof(ulong) + " " +
                  "Minimum Value: " + ulong.MinValue + " " + "Maximum Value: " + ulong.MaxValue);

Console.WriteLine("Type: float" + " " + "Byte Size: " + sizeof(float) + " " +
                  "Minimum Value: " + float.MinValue + " " + "Maximum Value: " + float.MaxValue);

Console.WriteLine("Type: double" + " " + "Byte Size: " + sizeof(double) + " " +
                  "Minimum Value: " + double.MinValue + " " + "Maximum Value: " + double.MaxValue);

Console.WriteLine("Type: decimal" + " " + "Byte Size: " + sizeof(decimal) + " " +
                  "Minimum Value: " + decimal.MinValue + " " + "Maximum Value: " + decimal.MaxValue);
*/

//Write program to enter an integer number of centuries and convert it to years, days, hours,
//minutes, seconds, milliseconds, microseconds, nanoseconds.
/*
string a;
Console.WriteLine("Input: ");
a = Console.ReadLine();
Int32.TryParse(a, out int b);

Console.WriteLine($"\nOutput: {b} centuries = {b*100} years = {b*100*365.24} days = {b*100*365.24*24} hours" +
    $" = {b * 100 * 365.24 * 24 *60} minutes = {b * 100 * 365.24 * 24* 60 * 60} seconds = {b * 100 * 365.24 * 24 * 60 * 60 * 1000} " +
    $"milliseconds = {b * 100 * 365.24 * 24 * 60 * 60 * 1000 * 1000} microseconds + = {b * 100 * 365.24 * 24 * 60 * 60 * 1000 * 1000 * 1000} nanoseconds");
*/

/*
 * (Types of errors: Syntax/Compiler-Time, Run-Time, Linker, Logical, Semantic)
1.What happens when you divide an int variable by 0? 
Run-Time ERROR

2. What happens when you divide a double variable by 0?
Run-Time ERROR

3. What happens when you overflow an int variable, that is, set it to a value beyond its
range?
Run-Time ERROR

4. What is the difference between x = y++; and x = ++y;?
Pre-increment operator: is used to increment the value of a variable before using it in an expression
Post-increment operator: is used to increment the value of the variable
after executing the expression.

5.What is the difference between break, continue, and return when used inside a loop
statement?
Break: break is used to exit from a loop or a switch-case.
Continue: continue is used to move the control to the next iteration of the loop.
Return: return is used to return a value from a function.

6. What are the three parts of a for statement and which of them are required?
for(int i = 1; i < 10; i++) {}
 1. Initalization: initialize the loop variable which will iterate through the loop.
 2. Condition/Comparison: condition for loop variable regarding how much time it should iterate.
 3. Increment/Decrement: The value keeps changing until the condition is fulfilled.

7. What is the difference between the = and == operators?
Assignment operator (=): sets the variable on the left of the = to the value of the expression that is on its right
Comparison operator (==): Comparison operators can compare numbers or strings and perform evaluations

8. Does the following statement compile? for ( ; true; ) ;
Yes, but it's an infinite loop.

9. What does the underscore _ represent in a switch expression?
The underscore (_) character replaces the default keyword to signify that it should match anything if reached. 

10. What interface must an object implement to be enumerated over by using the foreach statement?
The IEnumerable interface permits enumeration by using a foreach loop.

*/

/*What will happen if this code executes?
int max = 500;
for (byte i = 0; i < max; i++)
{
    WriteLine(i);
}
*/

/*
1. FizzBuzzis a group word game for children to teach them about division. Players take turns
to count incrementally, replacing any number divisible by three with the word /fizz/, any
number divisible by five with the word /buzz/, and any number divisible by both with /
fizzbuzz/.
Create a console application in Chapter03 named Exercise03 that outputs a simulated
FizzBuzz game counting up to 100.
*/

/*
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    } 
    else
    {
        Console.WriteLine(i);
    }
}
*/

//What will happen if this code executes?
/*
int max = 500;
for (byte i = 0; i < max; i++)
{
    Console.WriteLine(i);
}

What code could you add (don’t change any of the preceding code) to warn us about the
problem?
Type byte's range is 0, 255 which is never reached causing the loop to increment past 255, resting back to 0, creating an infinite loop.
 */

////////////////////////TIP FOR MYELF - WHILE A LOOP CONDITION IS TRUE, CONTINUE, ELSE FALSE BREAK;////////////////////////

/*
int correctNumber = new Random().Next(3) + 1;
bool isCorrect = false;

while(!isCorrect)
{
    Console.WriteLine("Guess a number between 1 and 3");
    int convertGuess = int.Parse(Console.ReadLine());

    if (convertGuess == correctNumber)
    {
        Console.WriteLine("Correct!");
        isCorrect = true;
    }
    else if (convertGuess > correctNumber)
    {
        Console.WriteLine("Lower!");
    }
    else if (convertGuess < correctNumber)
    {
        Console.WriteLine("Higher!");
    }
}
*/

/*Print - a - Pyramid.
The first of the two inner loops prints the correct number of spaces, while the
second inner loop prints out the correct number of stars.
Plus 2
1       *
3      ***
5     *****
7    *******
9   *********
*/

////////////////////////TIP FOR MYELF - WHILE A LOOP CONDITION IS TRUE, CONTINUE, ELSE FALSE BREAK;////////////////////////
/*
int pHeight = 5;
for(int i = 1; i <= pHeight; i++)
{
    for (int i = 1; i <= pHeight; i++)
    {
        for (int j = pHeight - 1; j >= 1; j--) // Spaces
        {
            String spaceAmount = new string(' ', j);
            Console.Write(spaceAmount);
            Console.Write($"J: {j}");//////////////////////////////////////DEBUG/////////////////////
            
        }
        Console.WriteLine();
    }

    for (int k = 1; k < pHeight; k+=2) // Stars
    {
        String starAmount = new string('*',k);
        Console.Write(starAmount);
        Console.Write($"K: {k}");//////////////////////////////////////DEBUG/////////////////////
    }
*/

/*Write a simple program that defines a variable representing a birth date and calculates
how many days old the person with that birth date is currently.

For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
Note: once you figure out their age in days, you can calculate the days until the next
anniversary using int daysToNextAnniversary = 10000 - (days % 10000);.*/
/*
Console.WriteLine("Write your Birthday");

Console.WriteLine("Starting with Month (Format: MM)");
int birthMonth = int.Parse(Console.ReadLine());

Console.WriteLine("Day (Format: DD)");
int birthDay = int.Parse(Console.ReadLine());

Console.WriteLine("Year (Format: YYYY)");
int birthYear = int.Parse(Console.ReadLine());

Console.WriteLine($"You are currently this many days old today!");

Console.WriteLine($"{(System.DateTime.Now.Year-birthYear) * 365 + (System.DateTime.Now.Month-birthMonth) * 30.4167 + (System.DateTime.Now.Day-birthDay)}");

*/

/*Write a program that greets the user using the appropriate greeting for the time of day.
Use only if , not else or switch , statements to do so. Be sure to include the following
greetings:
"Good Morning"
"Good Afternoon"
"Good Evening"
"Good Night"
It 's up to you which times should serve as the starting and ending ranges for each of the
greetings.If you need a refresher on how to get the current time, see DateTime
Formatting. When testing your program, you'll probably want to use a DateTime variable
you define, rather than the current time. Once you're confident the program works
correctly, you can substitute DateTime.Now for your variable (or keep your variable and just
assign DateTime.Now as its value, which is often a better approach).*/

/*int timeOfToday = Convert.ToInt32(DateTime.Now.TimeOfDay.Hours);

if(timeOfToday >= 6 && timeOfToday <= 11)
{
    Console.WriteLine("Good Morning");
}
if (timeOfToday >= 12 && timeOfToday <= 17)
{
    Console.WriteLine("Good Afternoon");
}
if (timeOfToday >= 18 && timeOfToday <= 21)
{
    Console.WriteLine("Good Evening");
}
if (timeOfToday >= 22 || timeOfToday <= 5 && !(timeOfToday > 24))
{
    Console.WriteLine("Good Night");
}*/

/*Write a program that prints the result of counting up to 24 using four different increments.
First, count by 1s, then by 2s, by 3s, and finally by 4s.
Use nested for loops with your outer loop counting from 1 to 4. You inner loop should
count from 0 to 24, but increase the value of its /loop control variable/ by the value of the /
loop control variable/ from the outer loop. This means the incrementing in the /
afterthought/ expression will be based on a variable.*/
/*
for(int i = 1; i <= 4; i++)
{
    for(int j = 0; j <= 24; j+=i)
    {
        Console.Write(j);
        if (j + i <= 24) Console.Write(",");
    }
    Console.WriteLine();
}
*/

//DUE WEDNESDAY!!