// Вывод случайного трехзначного числа и удаление второй цифры этого числа

Random random = new Random();

int number = 0;

int number = random.Next(100, 1000);

Console.WriteLine("сгенерировано " + number);

Console.WriteLine("Вторая цифра этого числа - " +number[0]+ number[2]);

//Console.WriteLine($"После удаления второй цифры рультат " + a + b);//a b замен. на text1 text