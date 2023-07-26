// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Task68();

void Task68()
{
    Console.Write("Введите целое положительное число M: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите целое положительное число N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int FuncAckermann(int x, int y)
    {
        if (x == 0) return y + 1;
        if (x > 0 && y == 0) return FuncAckermann(x - 1, 1);
        if (x > 0 && y > 0) return FuncAckermann(x - 1, FuncAckermann(x, y - 1));
        else throw new ArgumentException("Функция Аккермана определена только для неотрицательных целых чисел.");
    }

    Console.WriteLine($"Функция Аккермана A({m}, {n}) = {FuncAckermann(m, n)}");
}

