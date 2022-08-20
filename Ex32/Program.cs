//Заменить эл-ты массива на противоположные

void Fill(int[] arr) 
{
    
    Console.Write("[");
    for (int i = 0 ; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 9);
        Console.Write($" {arr[i]}");
       
        
    }
    Console.Write(" ]");
    Console.WriteLine();
    for (int i = 0 ; i < arr.Length; i++)
    {
        
        arr[i] *= -1;
        Console.Write($" {arr[i]}");}
   
}

int[] massiv = new int[12];
Fill(massiv);
