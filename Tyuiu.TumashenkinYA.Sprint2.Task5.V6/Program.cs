using Tyuiu.TumashenkinYA.Sprint2.Task5.V6.Lib;

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

Console.WriteLine("Введите номер масти: ");
int value1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер достоинства карты: ");
int value2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

var result = ds.FindCardNameAndValue(value1, value2);
Console.WriteLine(result);
Console.ReadKey();