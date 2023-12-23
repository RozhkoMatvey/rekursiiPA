int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int M = ReadInt("Введите начальное значение M :  ");
int N = ReadInt("Введите конечное значение N :  ");

void FTask(int N, int M)
{
    
    if (M > N ) return;
    FTask(N - 1, M);
    System.Console.Write(N + " ");
}

FTask(N,M);

