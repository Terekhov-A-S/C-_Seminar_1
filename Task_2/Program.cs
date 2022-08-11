// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear ();
Console.WriteLine ("Искусственный интеллект Core 2.0 приветствует Вас! ");
Console.Write ("Пожалуйста, введите первое число для сравнения ");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Замечательно! Теперь введите второе число для сравнения ");
int b = Convert.ToInt32 (Console.ReadLine ());
if (a >= b) {Console.WriteLine ($"Так получилось, что {a} больше, либо равно {b} ");}
else Console.WriteLine ($"Мне кажется, {b} больше {a} ");
Console.Write ("Всего доброго! Буду рад пообщаться снова ");
