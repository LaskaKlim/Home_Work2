Console.WriteLine("Введите порядковый номер дня недели: ");

int number =Convert.ToInt32(Console.ReadLine());

if (number == 6) Console.WriteLine("Да!");
if (number == 7) Console.WriteLine("Да!");
if (number < 6) Console.WriteLine("Нет!");
if (number > 7) Console.WriteLine("Некорректное число");