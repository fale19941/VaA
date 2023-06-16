Console.Clear();
Console.WriteLine("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
if (first > second){ //Если первое число больше второго то консоль пишет что Макс число это первое, а мин число это второе
    Console.WriteLine($"Max:{first}");
    Console.WriteLine($"Min:{second}");
}
else if (first < second){ //Если второе число больше первого то в консоль выводится что мин число это первое, а макс число второе
    Console.WriteLine($"Max: {second}");
    Console.WriteLine($"Min: {first}");
}
else { // Если первое число равно второму то 
    Console.WriteLine("Не могу выявить максимальное, они равны");
}
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3