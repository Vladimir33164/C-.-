//S1.11. Составить программу вывода на экран «столбиком» четырех любых чисел.

//Random rnd = new Random();
//int a = rnd.Next(0,255);
//int b = rnd.Next(0,255);
//int c = rnd.Next(0,255);
//int d = rnd.Next(0,255);
//Console.WriteLine($"{a}\n{b}\n{c}\n{d}");

Random rnd3 = new Random();
Console.WriteLine("{0}\n{1}\n{2}\n{3}", rnd3.Next(), rnd3.Next(), rnd3.Next(), rnd3.Next());