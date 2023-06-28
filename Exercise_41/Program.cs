// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] ArrayFromUser(int size)
{
    int[] usersArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input your number №{i+1}:");
        usersArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return usersArray;
}

void PrintArray (int [] arrayPrint)
{
    Console.Write("Your sequence of numbers is: ");
    for (int i = 0; i < arrayPrint.Length; i++)
        if (i != arrayPrint.Length - 1)
            Console.Write(arrayPrint[i] + ", ");
        else
            Console.Write(arrayPrint[i]);

    Console.WriteLine();
}

int CountOfPositiveElems (int [] arrayCount)
{
    int countPos = 0;
    for (int i = 0; i < arrayCount.Length; i++)
    {
        if (arrayCount[i] > 0)
            countPos++;
    }
    return countPos;
}

Console.WriteLine("How many numbers will you input?");
int m = Convert.ToInt32(Console.ReadLine());
if (m <= 0)
    Console.WriteLine("Incorrect number. Try again");
else
{
    int [] array = ArrayFromUser(m);
    PrintArray(array);
    Console.WriteLine("Counting positions satisfying the principle Number > 0 ...");
    Console.WriteLine($"Your result is {CountOfPositiveElems(array)}");
}




