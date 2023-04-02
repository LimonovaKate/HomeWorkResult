/* Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длинна которых меньше либо равна 3 символа. */

Console.Write("Введите позиции в массиве: "); //ввод данных из консоли в массив
string [] array=Console.ReadLine()!.Split(' ','.',',').ToArray(); 

Console.Write("[");  // ввыводим в консоль получившийся массив (красиво)
for (int i=0; i<array.Length-1; i++)
    Console.Write($"{array[i]}, ");
Console.Write($"{array[array.Length-1]}] -> [");

for (int i=0; i<array.Length; i++) // проверяем длину элементов и при выполнении условия выводим в консоль
{
    if (array[i].Length<=3)
        Console.Write($"{array[i]} ");
}
Console.Write("]");