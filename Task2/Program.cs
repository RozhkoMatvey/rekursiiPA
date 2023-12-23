
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int m = ReadInt("Введите начальное значение m :  ");
int n = ReadInt("Введите конечное значение n :  ");

int Akk (int m , int n)
{
    if(m ==0) 
    return n +1;

    else if((m>0 )&&( n==0)) 
    return Akk(m - 1 , 1);

    else
    return Akk(m-1, Akk(m,n-1));
}

System.Console.Write(Akk(m,n));
