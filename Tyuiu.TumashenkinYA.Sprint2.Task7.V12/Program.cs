using Tyuiu.TumashenkinYA.Sprint2.Task7.V12.Lib;
Console.Title = "Спринт #2 | Выполнил: Тумашенкин Я. А. | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #12                                                             *");
Console.WriteLine("* Выполнил: Тумашенкин Ярослав Анатольевич | ПКТб-25-1                    *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("*Написать программу на C#, которая запрашивает исходные данные (вещественн*");
Console.WriteLine("*ные значения) и вычисляет, находится ли точка с координатами X,Y в заштри*");
Console.WriteLine("*ихованной области.                                                       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

var result = ds.CheckDotInShadedArea(x, y);

Console.WriteLine(result);
Console.ReadKey();
