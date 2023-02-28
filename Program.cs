Console.Clear();
Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine());
int[] Array(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 150);
    }
    return result;
}
int GetSum(int[] Array)
{
    int sum = 0;
    for(int i = 1; i < Array.Length; i = i + 2)
    {
        sum = sum + Array[i];
    }
    return sum; 
}
int[] mass = Array(size);
int n = GetSum(mass);
Console.WriteLine(String.Join(" ", mass));
Console.WriteLine($"Сумма нечетных элементов равна - {n}");