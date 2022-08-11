// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear ();
Console.WriteLine ("Искусственный интеллект Core 2.0 приветствует Вас! ");
Console.Write ("Пожалуйста, введите первое число для сравнения ");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Замечательно! Теперь введите второе число для сравнения ");
int b = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Превосходно! Введите и третье число ");
int c = Convert.ToInt32 (Console.ReadLine ());
int max = a;
if (b >= a) {max = b;}
else if (c >= a) {max = c;}
Console.Write ($"Максимальным из введенных Вами чисел является {max}. Всего доброго! Буду рад пообщаться снова ");
