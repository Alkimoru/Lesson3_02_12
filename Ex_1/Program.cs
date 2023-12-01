void Generation(int[] collection)
{
    int index_generation = 0;
    while (index_generation < collection.Length)
    {
        collection[index_generation] = new Random().Next(10, 100);
        index_generation++;
    }
}
void PrintArray(int[] print)
{
    int position = 0;
    Console.Write("{");
    while (position < print.Length)
    {

        Console.Write(print[position]);
        Console.Write(", ");

        position++;
    }
    Console.Write("}");
}
int[] array = new int[10];
Generation(array);
PrintArray(array);
int index = 0;
int result = 0;
while (index < array.Length)
{
    if (array[index] <= 90 && array[index] >= 20) result++;
    index++;
}
Console.WriteLine(" ");
Console.Write("Колличество элементов массива лежащих в отрезке [20;90] равно ");
Console.Write(result);