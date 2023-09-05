// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int size = Input("Введите количество строк: ");
string [] array = new string [size];
    
for (int i=0; i<size; i++)
{
    Console.Write($"Введите значение {i+1} элемента: ");
    array[i]=Console.ReadLine();
}
    
// Console.Write($"Массив_1: ");
// for (int i=0; i<size; i++)
// {
//     Console.Write($"{array[i]}; ");
// }

int count = 0;
for (int i =0; i<size; i++)
{
    if (array[i].Length<=3) count++;
}
    
// Console.Write($"{count}"); 

string []array_2=new string[count];

count=0;
for (int i=0; i<size; i++)
{
    if (array[i].Length<=3)
    {
        array_2[count]=array[i];
        count++;
    }
}
Console.Write($"Массив_2: ");
for (int j=0; j<count; j++)
{
    Console.Write($"{array_2[j]}; ");
}





