// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] arr(int num, int x, int y)
{
   int[] array = new int[num];
   for(int i = 0; i < num; i++)
   {
      array[i] = new Random().Next(x, y + 1);
   }
   return array;
}
void SeachNum (int[] arr, int elem)
{
bool Label = false;
for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elem) Label = true;

    }
    if (Label)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

int[] array33 = arr(25, -9, 9);
Console.WriteLine(string.Join(" ", array33));
SeachNum(array33, 0);