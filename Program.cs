//Задача2
/*System.Console.WriteLine("Введите числа a и b");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    System.Console.WriteLine(a);

}
else
{
    System.Console.WriteLine(b);
}*/


//Задача 4
/*System.Console.WriteLine("Введите числа a,b,с");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if(a > b )
{
    if(a > c)
    {
         System.Console.WriteLine(a);
    }
    else
    {
        System.Console.WriteLine(c);
    }
  
}
else if(b > c)
{
    System.Console.WriteLine(b);
}
else
{
    System.Console.WriteLine(c);
}*/


//Задача 6
/*System.Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
int num = a % 2;
if(num == 0)
{
    System.Console.WriteLine("Введенное число четное");
}
else
{
    System.Console.WriteLine("Введенное число нечетное");
}*/

//Задача 8
/*System.Console.WriteLine("Введите диапозон чисел");
int a = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i < a; i++)
if(i % 2 == 0)
{
    System.Console.Write(i + " " );
}*/


//Задача 10
/*System.Console.WriteLine("Введите трехзначное число");
int a= Convert.ToInt32(Console.ReadLine());
int Length = a.ToString().Length;
if (Length == 3) 
{
	int result = ( a/10 ) % 10;
	Console.WriteLine("Второе число " + result);
} 
else 
{
	Console.WriteLine("Не трехзначное число");
}*/


//Задача 15
/*System.Console.WriteLine("Введите день недели");
int Day_of_Week = Convert.ToInt32(Console.ReadLine());
if (Day_of_Week >= 1 && Day_of_Week <=7)
{
    if (Day_of_Week >= 6) 
    {
		System.Console.WriteLine("Этот день выходной");
	} 
    else 
    {
		System.Console.WriteLine("Рабочий день недели");
	}
} 
else 
{
	System.Console.WriteLine("Введите точное число дня недели");
}*/


//Задача 13
/*System.Console.WriteLine("Введите число");
int Value2 = Convert.ToInt32(Console.ReadLine());
int Length2 = Value2.ToString().Length;
if (Length2 >= 3) 
{
	while (Value2 > 999)
	{
		Value2 = Value2 / 10;
	}
	int result = Value2 % 10;
	Console.WriteLine("Третье число " + result);
} 
else 
{
	Console.WriteLine("У данного числа нет третьей цифры");
}*/
