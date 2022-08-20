//Найти сумму положительных и отрицательных эл-тов массива

void Fill(int[] arr)
{
    int i = 0;
    int sumpos = 0;
    int sumneg = 0;
    Console.Write("[");
    for (int length = arr.Length; i < length; i++)
    {
        arr[i] = new Random().Next(-9, 9);
        Console.Write($" {arr[i]}");
        if (arr[i] > 0) sumpos += arr[i];
        else sumneg += arr[i];
    }
    Console.Write(" ]");
    Console.WriteLine();
    Console.WriteLine($"Сумма положительных элементов = {sumpos}");
    Console.WriteLine($"Сумма отрицательных элементов = {sumneg}");
}

int[] massiv = new int[12];
Fill(massiv);

