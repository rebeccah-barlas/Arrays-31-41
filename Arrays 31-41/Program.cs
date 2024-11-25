// Exercise 31:

int[] numberArray = { 2, 8, 0, 24, 51 };
Console.WriteLine("Enter a number 0-4 and I will display the element that corresponds with that index");
int arrayIndex = int.Parse(Console.ReadLine());
var element = numberArray.ElementAt(arrayIndex);
Console.WriteLine(element);

// Exercise 32:

int[] numberArrayTwo = { 2, 8, 0, 24, 51 };
Console.WriteLine("Enter a number to see if it is in the array");
int userGuess = int.Parse(Console.ReadLine());
var index = Array.IndexOf(numberArrayTwo, userGuess);
Console.WriteLine(index);

// Exercise 33:

int[] numberArrayThree = { 2, 8, 0, 24, 51 };
Console.WriteLine("Enter the index (0-4) of the number you want to replace");
int indexArray = int.Parse(Console.ReadLine());
if (indexArray >= 0 && indexArray <= numberArrayThree.Length)
{
    Console.WriteLine("Enter the new number to replace");
    int newNumber = int.Parse(Console.ReadLine());
    numberArrayThree[indexArray] = newNumber;
}
foreach (int number in numberArrayThree)
{
    Console.WriteLine(number);
}

// Exercise 34:

int[] numberArrayFour = { 16, 32, 64, 128, 256 };
Console.WriteLine($"Enter a command: you can either \"half\" or \"double\" all the elements in the array");
string userCommand = Console.ReadLine();
if (userCommand == "half")
{
    var halvedArray = numberArrayFour.Select(x => x / 2).ToArray();
    foreach (var array1 in halvedArray)
    {
        Console.WriteLine(array1);
    }
}
if (userCommand == "double")
{
    var doubleArray = numberArrayFour.Select(x => x * 2).ToArray();
    foreach (var array2 in doubleArray)
    {
        Console.WriteLine(array2);
    }
}

// Exercise 35:

string[] animalTypes = { "cow", "elephant", "jaguar", "horse", "crow" };
Console.WriteLine("Enter two indices: the first index specifies the word (0-4), and the second specifies the letter in that word.");
string[] indices = Console.ReadLine().Split(' ');
int wordIndex = int.Parse(indices[0]);
int letterIndex = int.Parse(indices[1]);
if (wordIndex >= 0 && wordIndex <= animalTypes.Length)
{
    string word = animalTypes[wordIndex];
    {
        if (letterIndex >= 0 && letterIndex <= word.Length)
        {
            char letter = word[letterIndex];
            Console.WriteLine($"The word is: {word}");
            Console.WriteLine($"The letter at index {letterIndex} is: {letter}");
        }
    }
}

// Exercise 36:

int[] christmasNumbers = new int[] { 12, 11, 10, 9, 8 };
string[] christmasVerse = new string[] { "Drummers Drumming", "Pipers Piping", "Lords a-Leaping", "Ladies Dancing", "Maids a-Milking" };
Console.WriteLine("Enter a command: \'sing\' or \'quit\'");
string userSing = Console.ReadLine();
if (userSing == "sing")
{
    for (int i = 0; i < christmasNumbers.Length; i++)
    {
        Console.WriteLine($"{christmasNumbers[i]} {christmasVerse[i]}");
    }
}
else
{
    Console.WriteLine("Goodbye!");
}

// Exercise 37:

int[] userArray = new int[5];
int sum1 = 0;
for (int i = 0; i < userArray.Length; i++)
{
    Console.WriteLine("Enter a number");
    int userNumber = int.Parse(Console.ReadLine());
    sum1 = sum1 + userNumber;
}
Console.WriteLine(sum1);

// Exercise 38:

int[] userArrayTwo = new int[5];
double average = 0;
int sum2 = 0;
for (int i = 0; i < userArrayTwo.Length; i++)
{
    Console.WriteLine("Enter a number");
    int userNumberTwo = int.Parse(Console.ReadLine());
    sum2 = sum2 + userNumberTwo;
    average = (double)sum2 / userArrayTwo.Length;
}
Console.WriteLine(average);

// Exercise 39:

int[] userArrayThree = new int[5];
for (int i = 0; i < userArrayThree.Length; i++)
{
    Console.WriteLine("Enter a number");
    userArrayThree[i] = int.Parse(Console.ReadLine());
}
var ascendingOrder = userArrayThree.OrderBy(x => x).ToArray();
foreach (var number in ascendingOrder)
{
    Console.WriteLine(number);
}

// Exercise 40:

int[] userArrayFour = new int[5];
for (int i = 0; i < userArrayFour.Length; i++)
{
    Console.WriteLine("Enter a number");
    userArrayFour[i] = int.Parse(Console.ReadLine());
}
var medianNumber = userArrayFour.OrderBy(x => x).ToArray();
int count = medianNumber.Length;
double median = median = medianNumber[count / 2];
Console.WriteLine(median);

// Exercise 41:

Console.WriteLine("Enter a number");
double numberOne = double.Parse(Console.ReadLine());
Console.WriteLine("Enter a second number");
double numberTwo = double.Parse(Console.ReadLine());
double divideResult = (numberOne / numberTwo);
Console.WriteLine($"{divideResult:F2}"); // "F2" truncates to 2 decimal places

