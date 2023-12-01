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
    int index_printarray = 0;
    Console.Write("{");
    while (index_printarray < print.Length)
    {

        Console.Write(print[index_printarray]);
        Console.Write(", ");

        index_printarray++;
    }
    Console.Write("}");
    Console.WriteLine(" ");
}
int[] array = new int[10];
Generation(array);
PrintArray(array);
int index = 0;
int result = 0;
while (index < array.Length)
{
    if (array[index] % 2 == 0)
    {
        result++;
    }

    index++;
}
Console.Write("Колличество чётных элементов в массиве равно: ");
Console.Write(result);