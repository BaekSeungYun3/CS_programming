//9.(이중반복문) 5층짜리 피라미드를 그려 출력

for(int i = 1; i<= 5; i++)
{
    for (int j = 1; j <= 5 - i; j++)
        Console.Write(" ");
    for (int j = 1; j <= 2 * i - 1; j++)
        Console.Write("*");
    Console.WriteLine();
}