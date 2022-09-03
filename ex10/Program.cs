void Fillarray(int[] argCol)
{
    int len = argCol.Length;
    int index = 0;
    while (index < len)
    {
        argCol[index] = new Random().Next(1, 10);
        index++;
    }
}

void printArray(int[] argArr)
{
    int N = argArr.Length;
    int i = 0;
    while(i<N)
    {
        Console.WriteLine(argArr[i]);
        i++;
    }

}

int[] array = new int[10];
 
 Fillarray(array);
 printArray(array);