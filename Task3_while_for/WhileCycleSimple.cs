namespace NoobCodersPractice.Task3_while_for;

public class WhileCycleSimple
{
    // В консоль пользователем вводится целое положительно число.
    // Используя цикл while, напишите программу, которая выводит на экран через пробел числа от нуля
    // до введенного пользователем числа включительно.
    
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int iterations = 0;
        
        while (iterations <= num)
        {
            Console.Write($"{iterations} ");
            iterations++;
        }
    }
}