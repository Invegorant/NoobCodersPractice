namespace NoobCodersPractice.Task2;

public class FromZeroToFive
{
    /*
     * Напишите программу, в которой пользователь вводит с клавиатуры число от 0 до 5.
     * Программа должна вывести счёт от введённого числа и до 5.
     */

    public static void Main()
    {
        Console.WriteLine("Please, enter the number from 0 to 5:");
        int a = Convert.ToInt32(Console.ReadLine());

        //Тут будет Ваш код
        switch (a)
        {
            case 0:
                WriteNumbers(0);
                break;
            case 1:
                WriteNumbers(1);
                break;
            case 2:
                WriteNumbers(2);
                break;
            case 3:
                WriteNumbers(3);
                break;
            case 4:
                WriteNumbers(4);
                break;
            case 5:
                WriteNumbers(5);
                break;
            default:
                Console.WriteLine("You can't pass this number! It takes from 0 to 5 only!");
                break;
        }
    }

    public static void WriteNumbers(int number)
    {
        for (int i = number; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
    }
}