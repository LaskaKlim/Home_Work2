// Вывод случайного трехзначного числа и удаление второй цифры этого числа

Random random = new Random();

int number = 0;

number = random.Next(100, 1000);

Console.WriteLine("сгенерировано " + number);

int a =  number / 100;
int b = number % 10;

// int text1 = a;
// int text2 = b; возможное присвоение 

Console.WriteLine($"После удаления второй цифры рультат " + a + b);//a b замен. на text1 text2