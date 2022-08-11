// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear ();
Console.WriteLine ("Искусственный интеллект Core 2.0 приветствует Вас! ");
Console.Write ("Пожалуйста, введите число для вывода на экран всех четных чисел от единицы до этого числа ");
int a = Convert.ToInt32 (Console.ReadLine ());
int ball = 1;
while (ball <= a) {
    if (ball % 2 == 0) {Console.Write ($"{ball} ");}
    ball++;
}
Console.WriteLine ($". Вот так я вижу ряд четных чисел от 1 до {a}");
Console.WriteLine ("Всего доброго! Буду рад пообщаться снова ");