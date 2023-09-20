// 8. (이중반복문) 1000까지의 소수를 출력하고 개수 출력

int nprime = 0;
for (int x = 2; x <= 1000; x++)
{
    int i;
    for (i = 2; i < x; i++)
    {
        if (x % i == 0)
            break;
    }
    if (i == x)
    {
        Console.Write("{0}\t", x);
        nprime++;
    }
}
Console.WriteLine();
Console.WriteLine("소수의 개수 = {0}", nprime);
