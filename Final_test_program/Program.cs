uint size;
try
{
    size = GetNumber("Enter size of the array: ");
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

string[] array = new string[size];
FillArray(array);
Console.WriteLine();
PrintArray(array);
string[] sortedArray = SortAndFillArray(array);
Console.WriteLine();
PrintArray(sortedArray);



string[] SortAndFillArray(string[] array)
{
    int sizeOfSortedArray = CountLettersOfArrayElement(array);
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



int CountLettersOfArrayElement(string[] array)
{
    int countLetters = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            countLetters++;
        }
    }
    return countLetters;
}



void PrintArray(string[] array)
{
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
}



void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter {i + 1} string: ");
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