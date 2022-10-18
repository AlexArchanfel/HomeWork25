// Задача 25. Напишите цикл, который принимает на вход два числа А и В и возводит А в натуральную степень В 
int Roma (int A, int B)
{
    int Rom = 1;
    int i = 0;

    while (i < B)
    {
        Rom = Rom * A;
        i = i + 1;
    } 
    return Rom;
}
Console.Clear();
Console.Write ("Введите первое число: ");
int A = int.Parse (Console.ReadLine ()!);
Console.Write ("Введите второе число: ");
int B = int.Parse (Console.ReadLine ()!);
Console.WriteLine (Roma(A, B));
