#region task1
int num1 = 7;
int num2 = 39;
int counter = 0;
string GettingNumbersBetweenOddNumbers(int x, int y, int counter)
{
    for (int i = x; i < y; i++)
    {
        if (i % 2 == 1)
        {
            counter += i;
        }

    }
    return ($"{counter} bunlarin cemidir");
}

Console.WriteLine(GettingNumbersBetweenOddNumbers(num1, num2, counter));
#endregion
#region task2
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 13, 45, 67 };
int counter2 = 0;

string GettingNumbersBetweenOddNumbersFromArray(int[] numbers, int counter)
{
    foreach (int n in numbers)
    {
        if (n % 2 == 1)
        {
            counter += n;
        }
    }
    return ($"{counter}bunlarin cemini ifade dir");
}
Console.WriteLine(GettingNumbersBetweenOddNumbersFromArray(numbers, counter2));
#endregion
#region task3
int[] numbers2 = { 1, 2, 34, 5, 6, 7, 8, 9, 12, 14, 86 };
int counter3 = 0;
string GettingNumbersBetweenEvenNumbers(int[] numbers, int counter)
{
    foreach (int n in numbers)
    {
        if (n % 2 == 0)
        {
            counter++;

        }

    }
    return ($"cavab:{counter} ");
}

Console.WriteLine(GettingNumbersBetweenEvenNumbers(numbers2, counter3));
#endregion;
#region task4
int num = 14;
int counter4 = 0;
void DefiningSimpleAndComplex(int num1, int counter)
{
    for (int i = 1; i < num1; i++)
    {
        if (num1 % i == 0)
        {
            counter++;
        }
    }
    if (counter > 2)
    {
        Console.WriteLine("bu murekkebdir");

    }
    else
    {
        Console.WriteLine("sade");
    }

}
DefiningSimpleAndComplex(num, counter4);
#endregion
#region task5
int num3 = 23;
bool IsPower = true;
void GettingPowerOfTwo(int num)
{
    if (num < 0)
    {
        Console.WriteLine("bu munkun deyil");
    }
    else
    {
        while (num > 1)
        {
            if (num % 2 != 0)
            {
                IsPower = false;
                break;
            }
            num /= 2;

        }
    }

    if (IsPower)
    {
        Console.WriteLine("bu eded 2nin ustudur");
    }
    else
    {
        Console.WriteLine(" deyildir");
    }
}
GettingPowerOfTwo(num3);
#endregion
#region task6
int[] numbers3 = { 1, 3, 55, 6, 33 };
int counter5 = 1;
string SumOfThem(int[] numbers3, int counter)
{
    foreach (int num3 in numbers3)
    {
        if (num3 <= 20)
        {
            counter *= num3;
        }
    }
    return ($"cavab:{counter}");
}
Console.WriteLine(SumOfThem(numbers3, counter5));
#endregion
#region task7.
int[] numbers4 = { 1, 2, 3, 45, 6, 7, 8, 9, 12 };
int counter6 = 0;
int GettingEvenNumbers(int[] numbers, int counter)
{
    foreach (int num in numbers)
    {
        if (num % 2 == 0)
        {

            counter += num;
        }
    }
    return counter * counter;
}

Console.WriteLine(GettingEvenNumbers(numbers4, counter6));
#endregion
#region task8
int[] Numbers7 = { -7, 5, -6, -7, 8, 9 };

void ConvertingNegativeOnesToPostive(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
        {
            numbers[i] *= -1;
            Console.WriteLine(numbers[i]);

        }

    }

}
ConvertingNegativeOnesToPostive(Numbers7);

#endregion
