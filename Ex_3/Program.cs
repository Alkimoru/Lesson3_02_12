void PrintArray(double[] print)
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
double[] array = { 1.1, 2.23, -3.14, 4.64, 5.87, 6.69, 7.95, -8.37, 9.12 };
PrintArray(array);
int index = 0;
double min = array[index];
double max = array[index];
while (index < array.Length)
{
    if (array[index] < min) min = array[index];
    index++;
}
index = 0;
while (index < array.Length)
{
    if (array[index] > max) max = array[index];
    index++;
}
Console.Write("Минимальным числом в массиве является: ");
Console.WriteLine(min);
Console.Write("Максимальным числом в массиве является: ");
Console.WriteLine(max);
Console.Write("Разница между максимальным и минимальным числом массива составила: ");
Console.Write(max - min);
// Только с этим задание возникли проблемы т.к. не смог найти понятной информации о том как "заставить"
// функцию генерировать случайные вещественные, а не целые числа. 
// Вечно выбивало ошибку "Ни одна из перегрузок метода "NextDouble" не принимает 2 аргументов." =(