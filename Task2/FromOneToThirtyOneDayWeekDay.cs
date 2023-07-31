namespace NoobCodersPractice.Task2;

public class FromOneToThirtyOneDayWeekDay
{
    //Напишите программу, в который пользователь вводит цифру от 1 до 31.
    //То есть день месяца.  Учитывая что 1 число, это понедельник, программа должна выводить какой сегодня день недели.
    //Примеры вывода для копирования
    //"Понедельник"
    //"Вторник"
    //"Среда"
    //"Четверг"
    //"Пятница"
    //"Суббота"
    //"Воскресенье" 
    
    public static void Main()
    {        
        int dayNumber = Convert.ToInt32(Console.ReadLine());


        //Пространство для вашего творчества
        int remain = dayNumber % 7;

        switch (remain)
        {
            case 0:
                Console.WriteLine("Воскресенье");
                break;
            case 1:
                Console.WriteLine("Понедельник");
                break;
            case 2:
                Console.WriteLine("Вторник");
                break;
            case 3:
                Console.WriteLine("Среда");
                break;
            case 4:
                Console.WriteLine("Четверг");
                break;
            case 5:
                Console.WriteLine("Пятница");
                break;
            case 6:
                Console.WriteLine("Суббота");
                break;
            default:
                Console.WriteLine("Нет такого дня в месяце");
                break;
        }
    }
}