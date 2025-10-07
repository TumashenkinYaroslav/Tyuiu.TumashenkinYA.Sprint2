using Tyuiu.TumashenkinYA.Sprint2.Task3.V15.Lib;

Console.Title = "Спринт #2 | Выполнил: Тумашенкин Я. А. | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #15                                                             *");
Console.WriteLine("* Выполнил: Тумашенкин Ярослав Анатольевич | ПКТб-25-1                    *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и*");
Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
DataService ds = new DataService();
Console.WriteLine("Введите значение X: ");
double x = Convert.ToDouble(Console.ReadLine());
double result = ds.Calculate(x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");


Console.WriteLine("Значение функции = " + result);
Console.ReadKey();