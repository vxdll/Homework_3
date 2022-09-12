//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(num);

if (number.Length == 5)
{
    if ( number[0] == number[4] & number[1] == number[3])
    {
     Console.WriteLine(number + " является палиндромом");
    }
    else
    {
    Console.WriteLine(number + " не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число!");
}






