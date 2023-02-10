// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

namespace HW6
{
    public class ConsoleApp
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the positive numbers counter!");
            Console.WriteLine("Insert numbers devided by comma (ex: 0, 1, 8):");
            var posCount = CountPositiveNumbers((Console.ReadLine() ?? string.Empty));
            Console.WriteLine(posCount);
        }

        static int CountPositiveNumbers(string input)
        {
            return input.Split(',')
                    .Select( x => { var result = 0; 
                                    int.TryParse(x.Trim(), out result);
                                    return result; 
                                  } )
                    .Count(x => x > 0);
        }
    }
}
