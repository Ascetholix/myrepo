// Функция (Метод с возвратом)

int Max(int ar1, int ar2, int ar3)
{
    int result = ar1;
    if (ar2 > ar1) result = ar2;
    if (ar3 > ar2) result = ar3;
    return result;
}

int a1 = 14;
int b1 = 41;
int c1 = 16;

int a2 = 51;
int b2 = 122;
int c2 = 61;

int a3 = 11;
int b3 = 21;
int c3 = 15;

//int max1 = Max(a1, b1, c1);  Можно в таком ввиде писат
//int max2 = Max(a1, b2, c2);
//int max3 = Max(a3, b3, c3);

//int allmax = Max(max1, max2, max3);

int allmax = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(allmax);