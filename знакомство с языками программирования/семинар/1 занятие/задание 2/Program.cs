Console.WriteLine("Введите число возведенное в квадрат");
int userNumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которое возводится в квадрат");
int userNumberB = Convert.ToInt32(Console.ReadLine());
int square = userNumberB * userNumberB;
if(square == userNumberA)
{
Console.WriteLine("Да");
}
else
{
   Console.WriteLine("Нет") ;
}