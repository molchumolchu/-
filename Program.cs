
Console.Write("Введите количество элементов массива: ");
int rows = Convert.ToInt32(Console.ReadLine()); // Задали количество элементов в массиве
int count = 0;
string [] massiv1 = new string [rows]; // создали массив, который будем анализировать
string [] massiv2 = new string [massiv1.Length]; // создали массив, в который будем переносить данные

for (int i = 0;i<rows;i++) // заполняем массив
{
    Console.Write ($"Введите значение или текст {i+1} элемента массива: ");
    massiv1[i] = Console.ReadLine();
    Console.Write("");
}

for (int i = 0; i < massiv1.Length; i++) // перебираем первый массив
{
    if(massiv1[i].Length <= 3) //отсекаем значения меньше 3
    {
        massiv2[count] = massiv1[i]; // переносим их во второй массив
        Console.Write($"{massiv2[count]} "); // и сразу печатаем
        count++;
    }
}


