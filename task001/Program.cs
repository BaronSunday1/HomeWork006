// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int Task(string text)
{
    System.Console.WriteLine(text);
    string number = Console.ReadLine();
    int result = Convert.ToInt32(number);
    return result;
}
int EnterArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Task($"Введите {i + 1} элемент");
    }
    return array;
}
void PrintResult(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"[{i}] = {array[i]}");
    }
}
int MoreThanZero(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}
int size = Task("Введите элементы(через пробел): ");
int[] array;
array = EnterArray(size);
PrintResult(array);
System.Console.WriteLine($"The number of numbers greater than zero is equal to = {MoreThanZero(array)}");
