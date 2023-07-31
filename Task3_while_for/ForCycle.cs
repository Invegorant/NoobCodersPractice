namespace NoobCodersPractice.Task3_while_for;

public class ForCycle
{
    // Простая задачка для закрепления материала. Пользователь вводит в консоль число.
    // Выведите на экран приветственное сообщение "Hello, NoobCoder's!" несколько раз, в зависимости от того,
    // какое число было введено пользователем.
    
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Hello, NoobCoder's!");
        }
    }
}