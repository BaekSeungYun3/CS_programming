//7. (이중반복문) 구구단 출력

for (int y = 1; y <= 9; y++)
{
    for (int x = 2; x <= 9; x++)
    {
        Console.Write("{0}x{1}={2}\t", x, y, x * y);
    }
    Console.WriteLine();
}