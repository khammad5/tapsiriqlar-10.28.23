


////4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. Example1: 3333 = 733338
//using System;

//Console.WriteLine("eded daxil et");
//string str1 = Console.ReadLine(); /////int num=int.Parse(Console.ReadLine());
//int num1 = int.Parse(str1);
//if (num1 < 1000 || num1 > 9999)

//{
//    Console.WriteLine($"{num1}-4reqemli deyil");
//    return;
//}

//    int num2 = 7 * 10000;
//    num2 = num1 + num2;
//    num2 *= 10;
//    num2 += 8;
//    Console.WriteLine(num2);


////3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir. example: 333 = 333333;

//Console.WriteLine("3 reqemli ededi daxil et");
//int num1 = int.Parse(Console.ReadLine());
//if (num1 < 100 || num1 > 999)
//{
//    Console.WriteLine($"{num1}-3reqemli deyil");
//return;
//}
//int num2 = num1 * 1000;
//num2 = num2 + num1;
//Console.WriteLine(num2);

///5 reqemli eded verilib. Bu ededin evvel 18 % sonra ise 3 % tap.

//Console.WriteLine("5 reqemli ededi daxil et");
//double num = double.Parse(Console.ReadLine());
//if (num < 10000 || num > 99999) 
//{
//    Console.WriteLine($"{ num} - 5 reqemli eded deyil" );
//    return;
//}
//double result = num * 18 / 100;
//Console.WriteLine(result);
//result *= 3d / 100;  ///result = result * 3 / 100;
//Console.WriteLine(result);

///3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;

//Console.WriteLine("3 reqemli ededi daxil et");
//int num = int.Parse(Console.ReadLine());
//if (num < 100 || num > 999) 
//{
//    Console.WriteLine($"{ num} - 3reqemli eded deyil");
//    return;
//}
//Console.WriteLine(" ededin axirina 7 artir");
//int num2 = num * 10 + 7;
//Console.WriteLine(num2);
//Console.WriteLine("ededin 7%ni tap");
//double result = num2 * 7d / 100;
//Console.WriteLine(result);

//4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap.

//Console.WriteLine("4 reqemli ededi daxil edin");
//int num = int.Parse(Console.ReadLine());
//if(num<1000 || num > 9999) 
//{
//    Console.WriteLine($"{num } - 4 reqemli deyil");
//    return;
//}
//int num1 = 4 * 10000 + num;
//int num2 = num1 * 100 + 44;
//Console.WriteLine(num2);

//double result = num2 * 44d / 100;
//Console.WriteLine(result);


//4 reqemli eded verilib. Bu ededin evvel 20%-ni , sonra ise cavabin 10% tap. Alinan cavabin kvadratini tap.

//Console.WriteLine("4 reqemli ededi daxil edin");
//int num1 = int.Parse(Console.ReadLine());
//if (num1 < 1000 || num1 > 9999) 
//{
//    Console.WriteLine($"{num1} - 4reqemli deyil");
//    return;
//}
//double num2 = num1 * 20d / 100;
//Console.WriteLine(num2);
//double num3 = num2 * 10d / 100;
//Console.WriteLine(num3);
//num3 = Math.Pow(num3, 2);  ///num3 = num3 * num3;
//Console.WriteLine(num3);

// 2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap

//Console.WriteLine("write first 5 number");
//int num1 = int.Parse(Console.ReadLine());
//if (num1 < 10000 || num1 > 99999)
//{
//    Console.WriteLine($"{num1} - 5 reqemli deyil");
//    return;
//}

//Console.WriteLine("write second 5 number");
//int num2 = int.Parse(Console.ReadLine());
//if (num2 < 10000 || num2 > 99999)
//{
//    Console.WriteLine($"{num2} - 5 reqemli deyil");
//    return;
//}
//int num3 = num1 + num2;
//Console.WriteLine(num3);
//int Pow = 100000;
//if (num3 > 99999)
//    Pow = 1000000;
//num3 = 5 * Pow + num3;
//Console.WriteLine(num3);
//num3 = num3 * 10 + 5;
//Console.WriteLine(num3);
//double reslt = num3 * 5d / 100;
//Console.WriteLine(reslt);


