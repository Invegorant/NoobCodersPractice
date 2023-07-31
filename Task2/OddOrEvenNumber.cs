namespace NoobCodersPractice.Task2;

public class OddOrEvenNumber
{
    // Дополните код чтобы он мог определять чётное или нечётное число было введено и выводило соответсвующие строки:
    // "ODD" (нечётное) или "EVEN" (чётное).
    // В этом решение нужно использовать тернарный оператор!
    
    public static void Main()
    {
        int num = Int32.Parse(Console.ReadLine()); // Запрашиваем ввод из консоли и вытягиваем из него число

        string answer = (num % 2) == 0 ? "EVEN" : "ODD";
        Console.WriteLine(answer);
    }
}