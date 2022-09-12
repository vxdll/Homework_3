//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= N; i++){
    double result = Math.Pow(i, 3);
    Console.WriteLine(result + " ");
} 
