namespace NoobCodersPractice.Task3_while_for;

public class WhileSumLessThanNumber
{
    // Немного доработаем предыдущую программу. Теперь пользователь вводит целое положительное число,
    // но от вас требуется вывести на экран все числа от нуля столбиком, чтобы при этом сумма всех чисел в столбце
    // была строго меньше введенного пользователем числа.
    
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        
        for (int i = 0; i < num; i++)
        {
            if (i + sum >= num)
            {
                break;
            }
            Console.WriteLine(i);
            sum += i;
        }
    }
}