using Tyuiu.TumashenkinYA.Sprint2.Task4.V25.Lib;

Console.Title = "Спринт #2 | Выполнил: Тумашенкин Я. А. | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тернарный оператор                                                      *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Тумашенкин Ярослав Анатольевич | ПКТб-25-1                    *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("*Написать программу, которая вычисляет требуемое значение с использованием*");
Console.WriteLine("*м тернарного оператора, где пользователь вводит значение переменных x,y с*");
Console.WriteLine("*с клавиатуры                                                             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
DataService ds = new DataService();

Console.WriteLine("Введите значение X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y: ");
double y = Convert.ToDouble(Console.ReadLine());

double result = ds.Calculate(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Значение функции = " + result);

Console.ReadKey();