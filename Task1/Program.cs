// Разложите натуральное число n на простые множители и определите
//    сколько раз встречается множитель 2 в произведении
//    наименьший множитель произведения
//    сколько различных множителей в произведении

int n = new Random().Next(90,91);
Console.WriteLine(n);
Console.WriteLine($"наименьший делитель {Min(n)}");
int count2 = 0;
while (n%2 == 0)
{
    n = n/2;
    count2++;
}
if (count2>0) Console.WriteLine($"множитель 2 встречается {count2}");

int delitel = 3;
int count = 0;
while (n>1)
{
    while (n%delitel == 0)
    {
        n= n/delitel;
        if (n%delitel!=0)
            count++;
    }
    delitel++;
}


if (count2>0) Console.WriteLine($"колличество уникальных множителей = {count +1}");
else Console.WriteLine($"колличество уникальных множителей = {count}");

int Min(int n)
{
    int mindiv = 0;
    for (int i = 2; i <= n; i++)
    {
        if (n % i == 0)
        {
            mindiv = i;
            return mindiv;
        }
    }
    return mindiv;
}

