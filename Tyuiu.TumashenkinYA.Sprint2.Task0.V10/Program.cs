using Tyuiu.TumashenkinYA.Sprint2.Task0.V10.Lib;

Console.Title = "Спринт #2 | Выполнил: Тумашенкин Я. А. | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Тумашенкин Ярослав Анатольевич | ПКТб-25-1                    *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравненийи арифметических выражений,     *");
Console.WriteLine("* которая вернет логическую последовательность:                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(" x = 1305, y = 475");


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
DataService ds = new DataService();
var result = ds.GetCompareOperations(1305, 475);
Console.WriteLine(String.Join(",", result));
Console.ReadKey();
