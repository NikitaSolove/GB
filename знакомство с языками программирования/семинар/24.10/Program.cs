int getRandomNumberFromRange(int minBorder, int maxBorder)
{
    int result = new int();
    result = new Random().Next(minBorder, maxBorder + 1);
    return result;
}
int getMaxDigitFromNumber(int number)
{
    int maxDigit = 0;
    while(number > 0)
    {
        int currentDigit = number % 10;
        if(maxDigit < currentDigit)
        {
            maxDigit = currentDigit;
        }
        Console.WriteLine(number);
        number = number / 10;
    }
    return maxDigit;

}

    int RandomNumber = getRandomNumberFromRange(100,999);
    Console.WriteLine($"Случайное значение {RandomNumber}");
    int maxDigit = getMaxDigitFromNumber(RandomNumber);
    Console.WriteLine($"Для числа {RandomNumber} большая цифра {maxDigit}");

