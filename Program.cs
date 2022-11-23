string [] ShortWords (string [] a)
{
    string [] ShortWords = new string [a.Length];
    int ii = 0;
    for (int i = 0; i < a.Length; i++)
    {
        string j = a[i];
        if (j.Length <= 3 ) 
        {
            ShortWords[ii] = j;
            ii++;
        }  
    }
    return ShortWords;
}

void PrintArr (string [] arr)
{
       for (int i=0; i<arr.Length; i++)
    {
            Console.Write(arr[i] + " " );
    }
  Console.WriteLine();
}

Console.WriteLine("Введите предложение");
string str = Console.ReadLine();
string [] words = str.Split(' ');
string [] NewWords = ShortWords (words);
PrintArr (NewWords);
