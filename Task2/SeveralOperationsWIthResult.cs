namespace NoobCodersPractice.Task2;

public class SeveralOperationsWIthResult
{
    // Изменим предыдущую программу Теперь пользователь кроме номера операции вводит и два числа,
    // и в зависимости от номера операции с введенными числами выполняются определенные действия
    // (например, при вводе числа 3 числа умножаются). Результат операции выводится на консоль
    // (только в том случае, когда операция известна).
    // Во избежание проблем с автопроверкой из-за несовпадающих символов, просто скопируйте эти варианты для вывода:
    // "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение"
    // "Результат операции {result}"
    // "Неизвестная операция!"
    
    public static void Main()
    {
        Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        int operation = Convert.ToInt32(splitString[0]);
        double a = Convert.ToDouble(splitString[1]);
        double b = Convert.ToDouble(splitString[2]);
        double result = 0;

        switch (operation)
        {
            case 1:
                result = a + b;
                Console.WriteLine($"Результат операции {result}");
                break;
            case 2:
                result = a - b;
                Console.WriteLine($"Результат операции {result}");
                break;
            case 3:
                result = a * b;
                Console.WriteLine($"Результат операции {result}");
                break;
            default:
                Console.WriteLine("Неизвестная операция!");
                break;
        }
    }
}