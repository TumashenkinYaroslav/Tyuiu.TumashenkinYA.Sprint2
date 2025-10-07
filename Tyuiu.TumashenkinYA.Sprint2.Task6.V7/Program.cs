using Tyuiu.TumashenkinYA.Sprint2.Task6.V7.Lib;

Console.Title = "Спринт #2 | Выполнил: Тумашенкин Я. А. | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Оператор switch                                                         *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Тумашенкин Ярослав Анатольевич | ПКТб-25-1                    *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("*Написать программу, которая использует оператор switch вычисляет требуемо*");
Console.WriteLine("*ое значение и возвращает результат.                                      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
DataService ds = new DataService();
Console.WriteLine(" Месяц начала года: ");
var MSY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Сколько прошло месяцев с начала года: ");
var n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

var result = ds.FindMonthName(MSY, n);
Console.WriteLine(result);
Console.ReadKey();