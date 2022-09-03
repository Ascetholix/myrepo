// Поиск индекса масива

int[] array = { 1, 2, 3, 4, 5, 6, 4, 8 };
int n = array.Length;

Console.Write("Введите число : ");
int find =Convert.ToInt32(Console.ReadLine());

int index = 0;

while (index < n)
{
    if (find == array[index])
    {
        Console.WriteLine(index);
    }
    index++;
}
