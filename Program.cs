//Задача 19.
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*

void Palindrom(int first, int fifth, int second, int fourth)
{
    if (first == fifth)
    {
        if (second == fourth)
        Console.WriteLine("Yes");
    }
    else Console.WriteLine("No");
}

Console.WriteLine("Input 5-digit number: ");
int numberUser = Convert.ToInt32(Console.ReadLine());

if (numberUser > 9999 && numberUser < 99999)
{
    int first_number = numberUser / 10000;
    int fifth_number = numberUser % 10;
    int second_number = numberUser / 1000 % 10;
    int fourth_number = numberUser /10 % 10;

    Palindrom(first_number, fifth_number, second_number, fourth_number);
}
else Console.WriteLine("Impossible number!");

*/

//Задача 21.
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double LongLine3D (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double lengthAB = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2));
    //double lengthAB1 = Math.Round (lengthAB, 2);
    return lengthAB;
}
    Console.WriteLine ("Input X coordinate of A:");
    int xCoordA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Input Y coordinate of A:");
    int yCoordA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Input Z coordinate of A:");
    int zCoordA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Input X coordinate of B:");
    int xCoordB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Input Y coordinate of B:");
    int yCoordB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Input Z coordinate of B:");
    int zCoordB = Convert.ToInt32(Console.ReadLine());

    double dist = LongLine3D(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);

    Console.WriteLine($"Distance AB is {dist:f2}");

*/

//Задача 23.
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void KubFinder ()
{
    Console.WriteLine("Input number: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    if (numberN > 0 )
    {
        int current_i = 1;
        while (current_i <= numberN)
            {
                int res = current_i*current_i*current_i;
                Console.Write($"{res}, ");
                current_i ++;
            }
        Console.WriteLine("\b\b.");
    }   
    else Console.WriteLine("Impossible value!");
} 

KubFinder();

