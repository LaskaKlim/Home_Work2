Console.WriteLine("Введите трехзначное число: ");

string number = Console.ReadLine();

if (number.Length == 3) Console.WriteLine("Третья цифра этого числа : " + number[2]);
if (number.Length < 3) Console.WriteLine("Третьей цифры не существует");
if (number.Length > 3) Console.WriteLine("Введенное чbсло не корректно");