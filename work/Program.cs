Random random = new Random();

int number = 0;

number = random.Next(10, 100);
Console.WriteLine("сгенерировано " + number);

int a =  number / 10;
int b = number % 10;

if (a > b)
    Console.WriteLine("a > b");
else if(b > a)
    Console.WriteLine("b > a");
else if (b == a)
    Console.WriteLine("b == a");

// //способ вывода 
// string text1 = "first"; 
// string text2 = "Next";
// //1
// Console.WriteLine("Hello {1} and {0} ", text1, text2); //text1-{0} text2-{1}

// //способ вывода 2
// Console.WriteLine($"hello {text1 + text2} hello");
