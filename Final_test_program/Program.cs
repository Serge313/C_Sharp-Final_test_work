// Leave strings of 3 letters

TestCountThreeSymbolElements();
TestSortAndFillArray();

uint sizeOfArray;
try
{
    sizeOfArray = GetNumber("Enter size of the array: ");
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

string[] array = new string[sizeOfArray];
FillArray(array);
PrintArray(array);
string[] sortedArray = SortAndFillArray(array);
PrintSortedArray(sortedArray);



void TestSortAndFillArray()
{
    Console.WriteLine("Testing of the \"SortAndFillArray\" method has been launched... ");
    string[] testArray = { "1234", "1567", "-2", "computer science" };
    string[] expected = { "-2" };
    string[] actual = SortAndFillArray(testArray);
    if (expected.SequenceEqual(actual))
    {
        Console.WriteLine("Test completed successfully!");
    }
    else
    {
        Console.WriteLine("Error! Need to fix the method!");
    }
    Console.WriteLine();
}



void TestCountThreeSymbolElements()
{
    Console.WriteLine("Testing of the \"CountThreeSymbolElements\" method has been launched... ");
    string[] testArray = { "hello", "2", "world", ":-)" };
    int expected = 2;
    int actual = CountThreeSymbolElements(testArray);
    if (expected == actual)
    {
        Console.WriteLine("Test completed successfully!");
    }
    else
    {
        Console.WriteLine("Error! Need to fix the method!");
    }
    Console.WriteLine();
}



void PrintSortedArray(string[] array)
{
    Console.WriteLine();
    Console.WriteLine("Your sorted string array: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        else
        {
            Console.Write($"\"{array[i]}\"");
        }
    }
    Console.WriteLine();
}



string[] SortAndFillArray(string[] array)
{
    int sizeOfSortedArray = CountThreeSymbolElements(array);
    string[] sortedArray = new string[sizeOfSortedArray];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sortedArray[j] = array[i];
            j++;
        }
    }
    return sortedArray;
}



int CountThreeSymbolElements(string[] array)
{
    int countElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            countElements++;
        }
    }
    return countElements;
}



void PrintArray(string[] array)
{
    Console.WriteLine();
    Console.WriteLine("Your string array: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        else
        {
            Console.Write($"\"{array[i]}\"");
        }
    }
    Console.WriteLine();
}



void FillArray(string[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter {i + 1} string (element of the array): ");
        array[i] = Console.ReadLine();
    }
}



uint GetNumber(string message)
{
    Console.Write(message);
    bool isParsed = uint.TryParse(Console.ReadLine(), out uint number);
    bool isGreaterThanOne = number > 0;
    if (isParsed && isGreaterThanOne)
    {
        return number;
    }
    else
    {
        throw new FormatException("Invalid value entered!");
    }
}