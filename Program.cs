
Console.Write("Введите количество элементов массива: ");
int rows = Convert.ToInt32(Console.ReadLine()); // Задали количество элементов в массиве
int count = 0;
string [] massive_1 = new string [rows]; // создали массив, который будем анализировать
string [] massive_2 = new string [massive_1.Length]; // создали массив, в который будем переносить данные

for (int i = 0;i<rows;i++) // заполняем массив
{
    Console.Write ($"Введите значение или текст {i+1} элемента массива: ");
    massive_1[i] = Console.ReadLine();
    Console.Write("");
}

for (int i = 0; i < massive_1.Length; i++) // перебираем первый массив
{
    if(massive_1[i].Length <= 3) //отсекаем значения меньше 3
    {
        massive_2[count] = massive_1[i]; // переносим их во второй массив
        count++;
    }
}

for (int i = 0; i < massive_2.Length; i++) // выводим массив 2 на печать
{
    Console.Write($"{massive_2[i]} ");
}
Console.WriteLine();


