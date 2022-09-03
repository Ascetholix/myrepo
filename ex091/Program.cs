// Замена элемнта массива
//Максимум элемента массива с помоцью функции (метод)

int Max(int ar1, int ar2, int ar3)
{
    int result = ar1;
    if (ar2 > ar1) result = ar2;
    if (ar3 > ar2) result = ar3;
    return result;
}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

array[0] = 12;

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine($"Земена 0 индескса на: {array[0]}");
Console.WriteLine($"Максимальный элемент массива: {max}");
