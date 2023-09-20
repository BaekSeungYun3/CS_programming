// 5. (반복문) 1에서 100을 더하고 여기서 짝수의 합, 홀수의 합, 역수의 합 구하여 출력
// 짝수 = even / 홀수 = odd

int sum = 0;
int esum = 0;
int osum = 0;

for(int i = 1; i <= 100; i++)
{
    sum += i;   //1~100의 합

    if (i % 2 == 0)
        esum += i;
    else
        osum += i;
}
double asum = 0;

for (int i = 1; i <= 100; i++)
    asum = 1.0 / i;     //역수의 합

Console.WriteLine("1~100의 합 = {0}", sum);
Console.WriteLine("1~100의 짝수의 합 = {0}", esum);
Console.WriteLine("1~100의 홀수의 합 = {0}", osum);
Console.WriteLine("1~100의 역수의 합 = {0}", asum);