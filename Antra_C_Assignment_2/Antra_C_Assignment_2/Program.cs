/*1.When to use String vs. StringBuilder in C# ?
If a string is going to remain constant throughout the program, then use String
class object because a String object is immutable.
If a string can change (example: lots of logic and operations in the construction of the string)
then using a StringBuilder is the best option.

2. What is the base class for all arrays in C#?
he Array class gives methods for creating, manipulating, searching, and sorting arrays.

3.How do you sort an array in C#?
The simplest way to sort an array in C# is using Array. Sort method. 

4.What property of an array object can be used to get the total number of elements in
an array?
length is a property of arrays in JavaScript that returns or sets the number of elements in a given array.

5. Can you store multiple data types in System.Array?
No, we cannot store multiple datatype in an Array, we can store similar datatype only in an Array.

6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?*/
/*The Clone() method returns a new array object containing all the elements in the original array.
 * This method creates a copy of an array as an object, therefore needs to be cast to the actual array type
 * before it can be used to do very much. The clone is of the same Type as the original Array.
*/
/*The CopyTo() method copies the elements into another existing array. It copies the elements of one array to another
 * pre-existing array starting from a given index (usually 0).*/

/*Both perform a shallow copy . Shallow copying is creating a new object and then copying the non static
 * fields of the current object to the new object. If the field is a value type, a bit by bit copy of the
 * field is performed. If the field is a reference type, the reference is copied but the referred object is not,
 * therefore the original object and its clone refer to the same object. A shallow copy of an object is a new object whose
 * instance variables are identical to the old object.*/

/*1. Copying an Array
Write code to create a copy of an array. First, start by creating an initial array. (You can use
whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
assign it a new array with 10 items in it. Use the things we’ve discussed to put some values
in the array.
Now create a second array variable. Give it a new array with the same length as the first.
Instead of using a number for this length, use the Length property to get the size of the
original array.
Use a loop to read values from the original array and place them in the new array. Also
print out the contents of both arrays, to be sure everything copied correctly.*/
/*
int[] array1 = {1,2,3,4,5,6,7,8,9,10};
int[] array2 = new int[10];

for(int i = 0; i < array1.Length; i++)
{
    array2[i] = array1[i];
}

for (int i = 0; i < array1.Length; i++)
{
    Console.WriteLine(array1[i]);
}
Console.WriteLine("New array contents");
for (int i = 0; i < array2.Length; i++)
{
    Console.WriteLine(array2[i]);
}*/

/*2. Write a simple program that lets the user manage a list of elements. It can be a grocery list,
"to do" list, etc. Refer to Looping Based on a Logical Expression if necessary to see how to
implement an infinite loop. Each time through the loop, ask the user to perform an
operation, and then show the current contents of their list. The operations available should
be Add, Remove, and Clear. The syntax should be as follows.............*/
/*
String[] arrayOfItems = new String[1];
String item;

while(true)
{
    Console.WriteLine("Type 1 to ADD");
    Console.WriteLine("Type 2 to REMOVE");
    Console.WriteLine("Type 3 to CLEAR");

    int option = int.Parse(Console.ReadLine());

    if (option == 1) 
    {
        Console.WriteLine("Name an item you would like to add to your list");
        item = Console.ReadLine();
        arrayOfItems = arrayOfItems.Concat(new[] { item }).ToArray(); //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    }
    if (option == 2) //|BUGGGGY| will have to come back to it, this soultion causes errors due to static array.
    {
        Console.WriteLine("Please type the number you want to remove from the list");
        int removeItemByNumber = int.Parse(Console.ReadLine());
        arrayOfItems[removeItemByNumber] = "";
    }
    if (option == 3) 
    {
        Console.WriteLine("Cleared entire grocery list...!");
        arrayOfItems = new String[100];
    }

    Console.WriteLine("Grocery List");
    Console.WriteLine("--------------------------------");
    int count = 0;

    foreach (string i in arrayOfItems)//$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    {
        Console.WriteLine(count + " " + i);
        count++;
    }
    Console.WriteLine("--------------------------------");
}

*/

/*3. Write a method that calculates all prime numbers in given range and returns them as array
of integers..........*/

/*4. Write a program to read an array of n integers (space separated on a single line) and an
integer k, rotate the array right k times and sum the obtained arrays after each rotation as
shown below.*/

/*5. Write a program that finds the longest sequence of equal elements in an array of integers.
If several longest sequences exist, print the leftmost one....................*/

/*7. Write a program that finds the most frequent number in a given sequence of numbers. In
case of multiple numbers with the same maximal frequency, print the leftmost of them
*/

/*1. Write a program that reads a string from the console, reverses its letters and prints the
result back at the console.
Write in two ways
Convert the string to char array, reverse it, then convert it to string again
Print the letters of the string in back direction (from the last to the first) in a for-loop*/

/*2. Write a program that reverses the words in a given sentence without changing the
punctuation and spaces..............*/

/*3. Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
and prints them on the console on a single line, separated by comma and space.Print all
unique palindromes (no duplicates), sorted*/

/*4. Write a program that parses an URL given in the following format:
[protocol]://[server]/[resource]
The parsing extracts its parts: protocol, server and resource.*/