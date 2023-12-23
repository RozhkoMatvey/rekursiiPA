int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for(int i = 0;i < size; i++ )
 {
    tempArray[i] = rand.Next(leftRange ,rightRange + 1) ; 
 }
 return tempArray;
}

void printA(int[] array)
{
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}
int size  = ReadInt ("Введите размер масссива : ");
int[] myArray = GenerateArray(size, 0 , 100);

void TTask (int[] myArray, int size)
{
    if(size - 1 < 0 ) return;
    System.Console.Write(myArray[size-1] + " ");
    TTask(myArray, size -= 1);
    System.Console.Write(myArray);
}

printA(myArray);
TTask(myArray, size);