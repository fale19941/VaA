Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int counter = 1;
while (n >= counter) // n(Введённое пользователем число) больше или равно нашему Counter делаем следующее
 {
    if (counter % 2 == 0) //Выводим в консоль если число делится без остатка, если делится с остатком то ====> counter +1, и делаем цикл по новой вплоть до введённого пользователем числа.
    {
        Console.Write(counter + " ");
    }
    counter ++;
}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8