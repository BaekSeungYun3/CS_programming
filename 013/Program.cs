//13.  (함수) 9번 문제를 활용해 n층의 피라미드를 그리는 함수를 작성(3,5,7층)

static void DrawPyramid(int n)
{
    for(int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n - i; j++)
            Console.Write(" ");

        for (int j = 1; j <= 2 * i - 1; j++)
            Console.Write("*");

        Console.WriteLine();
    }
}
DrawPyramid(3);
DrawPyramid(5);
DrawPyramid(7);
