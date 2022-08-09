//S1.8. Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.

//Random rnd = new Random();
//int a = rnd.Next(0,255);
//int b = rnd.Next(0,255);
//int c = rnd.Next(0,255);
//int d = rnd.Next(0,255);
//Console.WriteLine($"{a} {b} {c} {d}");

Random rnd2 = new Random();
Console.WriteLine("{0} {1} {2} {3}", rnd2.Next(), rnd2.Next(), rnd2.Next(), rnd2.Next());